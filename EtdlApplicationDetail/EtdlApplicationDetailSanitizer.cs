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
    public class EtdlApplicationDetailSanitizer : ISanitizer
    {
        public EtdlApplicationDetailSanitizer()
         {
            Name = this.GetType().Name.Replace("Sanitizer",String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }
		
        public int Sanitize()
        {
            var template = new Faker<EtdlApplicationDetail>(locale: "en_GB")
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .RuleFor(o => o.SafetyOrganisationAppliedTo, f => f.Internet.Mac())
                .RuleFor(o => o.LicenceEuropeanIdentificationNumber, f => f.Internet.Random.Hash())
                .RuleFor(o => o.AccompanyingDocumentationNotes, f => f.Rant.Review());


            var total = SanitizerUtil.SanitizeAsync<EtdlApplicationDetail, RailSmartContext>((RailSmartContext TContext) => TContext.EtdlApplicationDetail, template, batchSize: 1000);

            return total.Result;
        }

    }
}

