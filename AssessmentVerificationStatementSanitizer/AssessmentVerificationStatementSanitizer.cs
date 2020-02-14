using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Sanitizer.Contracts;
using Sanitizer.Model;

namespace AssessmentVerificationStatementSanitizer
{
    [Export(typeof(ISanitizer))]
    public class AssessmentVerificationStatementSanitizer : ISanitizer
    {
        public AssessmentVerificationStatementSanitizer()
        {
            Console.WriteLine("AssessmentVerificationStatementSanitizer Loaded.");
        }

        public string Name
        {
            get { return "AssessmentVerificationStatementSanitizer"; }
        }
        public string Description
        {
            get { return "Sanitizes AssessmentVerificationStatementSanitizer table."; }
        }

        public int Sanitize(DbContext dbToSanitize)
        {
            var context = (RailSmartContext)dbToSanitize;

            var objList = context.AssessmentVerificationStatement;

            var template = new Faker<AssessmentVerificationStatement>(locale: "en_GB")
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                .RuleFor(o => o.RatingReason, f => f.WaffleText(paragraphs: 4, includeHeading: false))
                .RuleFor(o => o.RecommendedAction, f => f.WaffleText(paragraphs: 4, includeHeading: false))
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .FinishWith((f, u) =>
                {
                    //Console.WriteLine(
                    //    $"User name {u.User.FullName},  Town = {u.BirthplaceTown}, Postcode = {u.BirthplacePostcode}");
                });

            var batchNumber = 0;
            var batchSize = 100;

            var batch = objList.Take(batchSize);
            while (batch.Any())
            {
                foreach (var obj in batch)
                {
                    template.Populate(obj);
                }
                batchNumber++;
                batch = objList.Skip(batchNumber * batchSize).Take(batchSize);
            }

            return context.SaveChanges();
        }

    }
}

