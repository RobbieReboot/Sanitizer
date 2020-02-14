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
    public class SupportPlanSanitizer : ISanitizer
    {
        public SupportPlanSanitizer()
         {
            Name = this.GetType().Name.Replace("Sanitizer",String.Empty);
            Console.WriteLine($"{Name} Sanitizer Loaded.");
        }
        public string Name { get; set; }
		
        public int Sanitize(DbContext context)
        {
            var template = new Faker<SupportPlan>(locale: "en_GB")
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .RuleFor(o => o.ReasonForSupportPlanNotes, f => f.WaffleText(paragraphs: 1, includeHeading: false))
                .RuleFor(o => o.EmployeePersonalCommitmentAction, f => f.WaffleText(paragraphs: 1, includeHeading: false))
                .RuleFor(o => o.EmployeePersonalCommitmentJustification, f => f.WaffleText(paragraphs: 1, includeHeading: false))
                .RuleFor(o => o.FinalFeedback, f => f.WaffleText(paragraphs: 1, includeHeading: false))
                .RuleFor(o => o.VerifierFinalFeedback, f => f.WaffleText(paragraphs: 1, includeHeading: false));

            var total = SanitizerUtil.SanitizeAsync<SupportPlan>(context, ((RailSmartContext)context).SupportPlan, template);

            return total.Result;
        }

    }
}

