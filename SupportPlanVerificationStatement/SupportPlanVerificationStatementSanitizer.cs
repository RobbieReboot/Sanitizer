using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Sanitizer;
using Sanitizer.Contracts;
using Sanitizer.Model;

namespace Sanitizer
{
    [Export(typeof(ISanitizer))]
    public class SupportPlanVerificationStatementSanitizer : ISanitizer
    {
        public SupportPlanVerificationStatementSanitizer()
         {
            Name = this.GetType().Name.Replace("Sanitizer",String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }
		
        public int Sanitize()
        {
            var template = new Faker<SupportPlanVerificationStatement>(locale: "en_GB")
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .RuleFor(o => o.RatingReason, f => f.WaffleText(paragraphs: 1, includeHeading: false))
                .RuleFor(o => o.RecommendedAction, f => f.WaffleText(paragraphs: 1, includeHeading: false));


            var total = SanitizerUtil.SanitizeAsync<SupportPlanVerificationStatement, RailSmartContext>((RailSmartContext TContext) => TContext.SupportPlanVerificationStatement, template, batchSize: 1000);

            return total.Result;
        }

    }
}

