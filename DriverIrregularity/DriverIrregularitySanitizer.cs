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
    public class DriverIrregularitySanitizer : ISanitizer
    {
        public DriverIrregularitySanitizer()
         {
            Name = this.GetType().Name.Replace("Sanitizer",String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }
		
        public int Sanitize(DbContext context)
        {
            var template = new Faker<DriverIrregularity>(locale: "en_GB")
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                .RuleFor(o => o.ModifiedDateTime, f => f.Date.Recent(100))
                .RuleFor(o => o.Notes, f => f.WaffleText(paragraphs: 4, includeHeading: false));

            var total = SanitizerUtil.SanitizeAsync<DriverIrregularity>(context, ((RailSmartContext)context).DriverIrregularity, template);

            return total.Result;
        }

    }
}

