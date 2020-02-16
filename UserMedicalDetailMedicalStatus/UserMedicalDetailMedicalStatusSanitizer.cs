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
    public class UserMedicalDetailMedicalStatusSanitizer : ISanitizer
    {
        public UserMedicalDetailMedicalStatusSanitizer()
         {
            Name = this.GetType().Name.Replace("Sanitizer",String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }
		
        public int Sanitize()
        {
            var template = new Faker<UserMedicalDetailMedicalStatus>(locale: "en_GB")
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .RuleFor(o => o.Notes, f => f.WaffleText(paragraphs: 2, includeHeading: false));

            var total = SanitizerUtil.SanitizeAsync<UserMedicalDetailMedicalStatus, RailSmartContext>((RailSmartContext TContext) => TContext.UserMedicalDetailMedicalStatus, template, batchSize: 1000);

            return total.Result;
        }

    }
}

