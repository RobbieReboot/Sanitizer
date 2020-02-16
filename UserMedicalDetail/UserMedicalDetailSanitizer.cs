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
    public class UserMedicalDetailSanitizer : ISanitizer
    {
        public UserMedicalDetailSanitizer()
         {
            Name = this.GetType().Name.Replace("Sanitizer",String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }
		
        public int Sanitize()
        {
            var template = new Faker<UserMedicalDetail>(locale: "en_GB")
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .RuleFor(o => o.GeneralHealthSummary, f => f.WaffleText(paragraphs: 1, includeHeading: false))
                .RuleFor(o => o.Recommendations, f => f.WaffleText(paragraphs: 1, includeHeading: false));

            var total = SanitizerUtil.SanitizeAsync<UserMedicalDetail, RailSmartContext>((RailSmartContext TContext) => TContext.UserMedicalDetail, template, batchSize: 1000);

            return total.Result;
        }

    }
}

