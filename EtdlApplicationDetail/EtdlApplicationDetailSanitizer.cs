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
		
        public int Sanitize(DbContext context)
        {
            var template = new Faker<EtdlApplicationDetail>(locale: "en_GB")
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .RuleFor(o => o.SafetyOrganisationAppliedTo, f => f.Internet.Mac())
                .RuleFor(o => o.LicenceEuropeanIdentificationNumber, f => f.Internet.Random.Hash())
                .RuleFor(o => o.AccompanyingDocumentationNotes, f => f.Rant.Review());


            var total = SanitizerUtil.SanitizeAsync<EtdlApplicationDetail>(context, ((RailSmartContext)context).EtdlApplicationDetail, template);

            return total.Result;
        }

    }
}

