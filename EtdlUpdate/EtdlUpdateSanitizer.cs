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
    public class EtdlUpdateSanitizer : ISanitizer
    {
        public EtdlUpdateSanitizer()
         {
            Name = this.GetType().Name.Replace("Sanitizer",String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }
		
        public int Sanitize(DbContext context)
        {
            var template = new Faker<EtdlUpdate>(locale: "en_GB")
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                .RuleFor(o => o.Date, f => f.Date.Recent(100))
                .RuleFor(o => o.Notes, f => f.WaffleText(paragraphs: 4, includeHeading: false));

            var total = SanitizerUtil.SanitizeAsync<EtdlUpdate>(context, ((RailSmartContext)context).EtdlUpdate, template);

            return total.Result;
        }

    }
}

