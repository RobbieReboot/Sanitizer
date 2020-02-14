using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Bogus;
using CountryData;
using Microsoft.EntityFrameworkCore;
using Sanitizer;
using Sanitizer.Contracts;
using Sanitizer.Model;

namespace UserAndUserProfileSanitizer
{
//    [Export("UserAndProfileSanitizer", typeof(ISanitizer))]
    [Export(typeof(ISanitizer))]
    public class UserAndUserProfileSanitizer : ISanitizer
    {
        private static readonly ICountry CountryData = CountryLoader.LoadUnitedKingdomLocationData();
        private static readonly IReadOnlyDictionary<string, IReadOnlyList<IPlace>> PostCodeData = CountryData.PostCodes();

        public UserAndUserProfileSanitizer()
        {
            Console.WriteLine("UserAndUserProfileSanitizer Loaded.");
        }

        public string Name
        {
            get { return "UserAndProfileSanitizer"; }
        }
        public string Description
        {
            get { return "Sanitizes User and UserProfile table."; }
        }

        public int Sanitize(DbContext dbToSanitize)
        {
            var context = (RailSmartContext) dbToSanitize;
            var uniqueSuffix = 0;

            var objList = context.UserProfile
                .Include(up => up.User)
                .Include(up => up.Gender)
                .Include(up => up.Company);

            var userProfileTemplate = new Faker<UserProfile>(locale: "en_GB")
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .RuleFor(o => o.LicenceNumber, f => f.Random.Hash())
                .RuleFor(o => o.DateOfBirth, f => f.Date.Past(40, new DateTime(2000, 1, 1)))
                .RuleFor(o => o.LicenceNumber, f => new Randomizer().Replace("UK##########"))
                .RuleFor(o => o.BirthplacePostcode, f =>
                    f.PickRandom<IReadOnlyList<IPlace>>(f.PickRandom<KeyValuePair<string, IReadOnlyList<IPlace>>>(PostCodeData)
                        .Value).First<IPlace>().PostCode
                    + " " + new Randomizer().Replace("#*?"))
                .RuleFor(o => o.BirthplaceTown, (f, u) =>
                        PostCodeData.SingleOrDefault<KeyValuePair<string, IReadOnlyList<IPlace>>>(p =>
                        p.Key == u.BirthplacePostcode.Substring(0, u.BirthplacePostcode.IndexOf(' '))).Value[0]?.Name)
                .FinishWith((f, u) =>
                {
                    //Console.WriteLine(
                    //    $"User name {u.User.FullName},  Town = {u.BirthplaceTown}, Postcode = {u.BirthplacePostcode}");
                });

            var userTemplate = new Faker<User>()
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                .RuleFor(o => o.Forename, f => f.Name.FirstName())
                .RuleFor(o => o.Surname, f => f.Name.LastName())
                .RuleFor(o => o.FullName, (f, u) => u.Forename + " " + u.Surname)
                //.RuleFor(o => o.Title, f => f.Name.Prefix(f.Person.Gender))
                .RuleFor(o => o.Email, (f, u) => f.Internet.Email(u.Forename, u.Surname))
                .RuleFor(o => o.Telephone, f => f.Phone.PhoneNumber("##### ######"))
                .RuleFor(o => o.Username,
                    (f, u) => (u.Company.CompanyCode + u.Forename[0] + u.Surname).Replace("'", string.Empty)+$"_{uniqueSuffix}")
                .RuleFor(o => o.LoweredUsername,
                    (f, u) => (u.Company.CompanyCode + u.Forename[0] + u.Surname).ToLower().Replace("'", string.Empty) + $"_{uniqueSuffix++}")
                .RuleFor(o => o.LastActivityDate, f => f.Date.Recent(365 * 5))
                //Password for ALL users = 'Ra1lPa55w0rd'
                .RuleFor(o => o.Password,
                    f =>
                        "PtUrP5vS0h0u4IAaEsscGbv41jUYxzqNqDRSVq8qfOC6WHbz4omGfkrYeKNMQ1JzJ9dmhmg5wAn+Jt44KsabPFzaUyS8PwtNR3KoS81uH/0=")
                .RuleFor(o => o.PasswordSalt, f => "XNpTJLw/C01HcqhLzW4f/Q==")
                .RuleFor(o => o.CreatedDate, f => f.Date.Between(new DateTime(2010, 1, 1), new DateTime(2018, 12, 31)))
                .RuleFor(o => o.LastLoginDate, f => f.Date.Recent(365))
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .RuleFor(o => o.MobileNumber, f => f.Phone.PhoneNumber("##### ######"))
                .RuleFor(o => o.LastLoginDateMobile, f => f.Date.Recent(365))
                .FinishWith((f, u) =>
                {
                    //Console.WriteLine($"UserName = {u.Username}");
                });

            //var batchNumber = 0;
            //var batchSize = 100;

            //var batch= profiles.Take(batchSize);
            //while (batch.Any())
            //{
            //    foreach (var profile in batch)
            //    {
            //        userProfileTemplate.Populate(profile);
            //        userTemplate.Populate(profile.User);
            //    }
            //    batchNumber++;
            //    batch = profiles.Skip(batchNumber * batchSize).Take(batchSize);
            //}
            //SanitizerUtil.Sanitize<UserProfile>(dbToSanitize,objList,userProfileTemplate);
            var batchNumber = 0;
            var batchSize = 100;

            var batch = objList.Take(batchSize);
            var total = objList.Count();
            var batches = total / batchSize;

            while (batch.Any())
            {
                foreach (var obj in batch)
                {
                    userProfileTemplate.Populate(obj);
                    userTemplate.Populate(obj.User);
                }
                batchNumber++;
                batch = objList.Skip(batchNumber * batchSize).Take(batchSize);
                Console.Write($"Completed {((double)batchNumber / (double)batches) * 100.0:##0.00}%, Batch {batchNumber}\r\r\r\r");
            }

            return context.SaveChanges();
        }

    }
}

