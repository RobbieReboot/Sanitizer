using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Sanitizer;
using Sanitizer.Contracts;
using Sanitizer.Model;

namespace AssessmentNoteSanitizer
{
    [Export(typeof(ISanitizer))]
    public class CompetencyCycleAssessmentWindowSanitizer : ISanitizer
    {
        public CompetencyCycleAssessmentWindowSanitizer()
         {
            Name = this.GetType().Name.Replace("Sanitizer",String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }
		
        public int Sanitize()
        {
            var template = new Faker<CompetencyCycleAssessmentWindow>(locale: "en_GB")
                .RuleFor(o => o.Notes, f => f.WaffleText(paragraphs: 4, includeHeading: false))
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100));

            var total = SanitizerUtil.SanitizeAsync<CompetencyCycleAssessmentWindow, RailSmartContext>((RailSmartContext TContext) => TContext.CompetencyCycleAssessmentWindow, template, batchSize: 1000);

            return total.Result;
        }

    }
}

