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
    public class SupportPlanManagerJustificationSanitizer : ISanitizer
    {
        public SupportPlanManagerJustificationSanitizer()
         {
            Name = this.GetType().Name.Replace("Sanitizer",String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }
		
        public int Sanitize()
        {
            var template = new Faker<SupportPlanManagerJustification>(locale: "en_GB")
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .RuleFor(o => o.Justification, f => f.WaffleText(paragraphs: 1, includeHeading: false));

            var total = SanitizerUtil.SanitizeAsync<SupportPlanManagerJustification, RailSmartContext>((RailSmartContext TContext) => TContext.SupportPlanManagerJustification, template, batchSize: 1000);

            return total.Result;
        }

    }
}

