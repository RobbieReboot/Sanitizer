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
    public class EmployeeAuthorityToWorkStatusSanitizer : ISanitizer
    {
        public EmployeeAuthorityToWorkStatusSanitizer()
         {
            Name = this.GetType().Name.Replace("Sanitizer",String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }
		
        public int Sanitize()
        {
            var template = new Faker<EmployeeAuthorityToWorkStatus>(locale: "en_GB")
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .RuleFor(o => o.Reference, f => f.WaffleText(paragraphs: 4, includeHeading: false));

            var total = SanitizerUtil.SanitizeAsync<EmployeeAuthorityToWorkStatus, RailSmartContext>((RailSmartContext TContext) => TContext.EmployeeAuthorityToWorkStatus, template, batchSize: 1000);

            return total.Result;
        }

    }
}

