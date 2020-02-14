using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Sanitizer;
using Sanitizer.Contracts;
using Sanitizer.Model;

namespace AssessmentNoteSanitizer
{
    [Export(typeof(ISanitizer))]
    public class AssessmentNoteSanitizer : ISanitizer
    {
        public AssessmentNoteSanitizer()
        {
            Console.WriteLine("AssessmentNoteSanitizer Loaded.");
        }

        public string Name
        {
            get { return "AssessmentNoteSanitizer"; }
        }
        public string Description
        {
            get { return "Sanitizes AssessmentNoteSanitizer table."; }
        }

        public int Sanitize(DbContext dbToSanitize)
        {
            var template = new Faker<AssessmentNote>(locale: "en_GB")
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                .RuleFor(o => o.Note, f => f.WaffleText(paragraphs: 4, includeHeading: false))
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .FinishWith((f, u) =>
                {
                    //Console.WriteLine(
                    //    $"User name {u.User.FullName},  Town = {u.BirthplaceTown}, Postcode = {u.BirthplacePostcode}");
                });

            var context = (RailSmartContext)dbToSanitize;

            SanitizerUtil.Sanitize<AssessmentNote>(dbToSanitize, context.AssessmentNote, template);

            return context.SaveChanges();
        }

    }
}

