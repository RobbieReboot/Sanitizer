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
    public class AssessmentCriteriaCardSanitizer : ISanitizer
    {
        public AssessmentCriteriaCardSanitizer()
        {
            Name = this.GetType().Name.Replace("Sanitizer",String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }
        
        public int Sanitize()
        {
            var template = new Faker<AssessmentCriteriaCard>(locale: "en_GB")
                .RuleFor(o => o.ReasonForRating, f => f.WaffleText(paragraphs: 4, includeHeading: false));

            var total = SanitizerUtil.SanitizeAsync<AssessmentCriteriaCard,RailSmartContext>((RailSmartContext TContext) => TContext.AssessmentCriteriaCard, template,batchSize:1000);

            return total.Result;
        }

    }
}

