using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Sanitizer;
using Sanitizer.Contracts;
using Sanitizer.Model;

namespace Sanitizers
{
    [Export(typeof(ISanitizer))]
    public class AssessorVerificationResponseSanitizer : ISanitizer
    {
        public AssessorVerificationResponseSanitizer()
        {
            Name = this.GetType().Name.Replace("Sanitizer", String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }

        public int Sanitize(DbContext dbToSanitize)
        {
            var template = new Faker<AssessorVerificationResponse>(locale: "en_GB")
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .FinishWith((f, u) =>
                {
                    //Console.WriteLine(
                    //    $"User name {u.User.FullName},  Town = {u.BirthplaceTown}, Postcode = {u.BirthplacePostcode}");
                });

            var context = (RailSmartContext)dbToSanitize;

            var total = SanitizerUtil.SanitizeAsync<AssessorVerificationResponse>(dbToSanitize, context.AssessorVerificationResponse, template);

            return total.Result;
        }

    }
}

