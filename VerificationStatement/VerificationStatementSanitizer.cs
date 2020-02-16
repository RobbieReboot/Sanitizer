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
    public class VerificationStatementSanitizer : ISanitizer
    {
        public VerificationStatementSanitizer()
         {
            Name = this.GetType().Name.Replace("Sanitizer",String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }
		
        public int Sanitize()
        {
            var template = new Faker<VerificationStatement>(locale: "en_GB")
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .RuleFor(o => o.Statement, f => f.WaffleText(paragraphs: 1, includeHeading: false));

            var total = SanitizerUtil.SanitizeAsync<VerificationStatement, RailSmartContext>((RailSmartContext TContext) => TContext.VerificationStatement, template, batchSize: 1000);

            return total.Result;
        }

    }
}

