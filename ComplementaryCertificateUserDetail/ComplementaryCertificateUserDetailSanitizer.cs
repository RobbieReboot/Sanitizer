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
    public class ComplementaryCertificateUserDetailSanitizer : ISanitizer
    {
        public ComplementaryCertificateUserDetailSanitizer()
         {
            Name = this.GetType().Name.Replace("Sanitizer",String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }
		
        public int Sanitize()
        {
            var template = new Faker<ComplementaryCertificateUserDetail>(locale: "en_GB")
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .RuleFor(o => o.AdditionalInformation, f => f.WaffleText(paragraphs: 4, includeHeading: false))
                .RuleFor(o => o.Notes, f => f.WaffleText(paragraphs: 4, includeHeading: false));

            var total = SanitizerUtil.SanitizeAsync<ComplementaryCertificateUserDetail, RailSmartContext>((RailSmartContext TContext) => TContext.ComplementaryCertificateUserDetail, template, batchSize: 1000);

            return total.Result;
        }

    }
}

