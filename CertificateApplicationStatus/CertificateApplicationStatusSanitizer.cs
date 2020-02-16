using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Sanitizer;
using Sanitizer.Contracts;
using Sanitizer.Model;

namespace Sanitizers
{
    [Export(typeof(ISanitizer))]
    public class CertificateApplicationStatusSanitizer : ISanitizer
    {
        public CertificateApplicationStatusSanitizer()
        {
            Name = this.GetType().Name.Replace("Sanitizer", String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }

        public int Sanitize()
        {
            var template = new Faker<CertificateApplicationStatus>(locale: "en_GB")
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100));

            var total = SanitizerUtil.SanitizeAsync<CertificateApplicationStatus, RailSmartContext>((RailSmartContext TContext) => TContext.CertificateApplicationStatus, template, batchSize: 1000);

            return total.Result;
        }

    }
}

