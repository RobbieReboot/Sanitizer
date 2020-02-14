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
		
        public int Sanitize(DbContext context)
        {
            var template = new Faker<CompetencyCycleAssessmentWindow>(locale: "en_GB")
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                //.RuleFor(o => o.Note, f => f.WaffleText(paragraphs: 4, includeHeading: false))
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100));

            var total = SanitizerUtil.SanitizeAsync<CompetencyCycleAssessmentWindow>(context, ((RailSmartContext)context).CompetencyCycleAssessmentWindow, template);
            return total.Result;
        }

    }
}

