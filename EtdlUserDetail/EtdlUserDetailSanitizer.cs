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

namespace Sanitizer
{
    [Export(typeof(ISanitizer))]
    public class EtdlUserDetailSanitizer : ISanitizer
    {
        public EtdlUserDetailSanitizer()
         {
            Name = this.GetType().Name.Replace("Sanitizer",String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }
        private static readonly ICountry CountryData = CountryLoader.LoadUnitedKingdomLocationData();
        private static readonly IReadOnlyDictionary<string, IReadOnlyList<IPlace>> PostCodeData = CountryData.PostCodes();

        public int Sanitize()
        {
            var template = new Faker<EtdlUserDetail>(locale: "en_GB")
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .RuleFor(o => o.BirthplacePostcode, f => f.PickRandom<IReadOnlyList<IPlace>>(f.PickRandom<KeyValuePair<string, IReadOnlyList<IPlace>>>(PostCodeData)
                         .Value).First<IPlace>().PostCode
                     + " " + new Randomizer().Replace("#*?"))
                .RuleFor(o => o.BirthplaceTown, (f, u) =>
                        PostCodeData.SingleOrDefault<KeyValuePair<string, IReadOnlyList<IPlace>>>(p =>
                        p.Key == u.BirthplacePostcode.Substring(0, u.BirthplacePostcode.IndexOf(' '))).Value[0]?.Name)
                .RuleFor(o => o.Telephone, f => f.Phone.PhoneNumber("##### ######"));


            var total = SanitizerUtil.SanitizeAsync<EtdlUserDetail, RailSmartContext>((RailSmartContext TContext) => TContext.EtdlUserDetail, template, batchSize: 1000);

            return total.Result;
        }

    }
}

