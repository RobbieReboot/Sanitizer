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
    public class AssessmentSanitizer : ISanitizer
    {
        public AssessmentSanitizer()
        {
            Name = this.GetType().Name.Replace("Sanitizer", String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }

        public int Sanitize(DbContext dbToSanitize)
        {
            var template  = new Faker<Assessment>(locale: "en_GB")
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                .RuleFor(o => o.Notes, f => f.WaffleText(paragraphs: 2, includeHeading: false))
                .RuleFor(o => o.AssessorFeedback, f => f.WaffleText(paragraphs: 2, includeHeading: false))
                .RuleFor(o => o.VerifierFinalFeedback, f => f.WaffleText(paragraphs: 2, includeHeading: false))
                .RuleFor(o => o.AssessorVerificationResponseNotes, f => f.WaffleText(paragraphs: 2, includeHeading: false))

                .FinishWith((f, u) =>
                {
                    //Console.WriteLine(
                    //    $"User name {u.User.FullName},  Town = {u.BirthplaceTown}, Postcode = {u.BirthplacePostcode}");
                });

            var context = (RailSmartContext)dbToSanitize;

            var total = SanitizerUtil.SanitizeAsync<Assessment>(dbToSanitize, context.Assessment, template);

            return total.Result;

        }

    }
}

