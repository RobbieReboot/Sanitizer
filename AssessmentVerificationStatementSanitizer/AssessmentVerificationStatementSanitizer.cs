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
    public class AssessmentVerificationStatementSanitizer : ISanitizer
    {
        public AssessmentVerificationStatementSanitizer()
        {
            Name = this.GetType().Name.Replace("Sanitizer", String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }

        public int Sanitize(DbContext dbToSanitize)
        {
            var template = new Faker<AssessmentVerificationStatement>(locale: "en_GB")
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                .RuleFor(o => o.RatingReason, f => f.WaffleText(paragraphs: 4, includeHeading: false))
                .RuleFor(o => o.RecommendedAction, f => f.WaffleText(paragraphs: 4, includeHeading: false))
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .FinishWith((f, u) =>
                {
                    //Console.WriteLine(
                    //    $"User name {u.User.FullName},  Town = {u.BirthplaceTown}, Postcode = {u.BirthplacePostcode}");
                });

            var context = (RailSmartContext)dbToSanitize;

            var total = SanitizerUtil.SanitizeAsync<AssessmentVerificationStatement>(dbToSanitize, context.AssessmentVerificationStatement, template);

            return total.Result;
        }

    }
}

