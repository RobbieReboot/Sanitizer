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
    public class UserFileNoteSanitizer : ISanitizer
    {
        public UserFileNoteSanitizer()
         {
            Name = this.GetType().Name.Replace("Sanitizer",String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }
		
        public int Sanitize()
        {
            var template = new Faker<UserFileNote>(locale: "en_GB")
                .RuleFor(o => o.Notes, f => f.WaffleText(paragraphs: 2, includeHeading: false));

            var total = SanitizerUtil.SanitizeAsync<UserFileNote, RailSmartContext>((RailSmartContext TContext) => TContext.UserFileNote, template, batchSize: 1000);

            return total.Result;
        }

    }
}

