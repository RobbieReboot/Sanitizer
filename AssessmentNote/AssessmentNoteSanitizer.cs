using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Bogus;
using Microsoft.EntityFrameworkCore;
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
            var context = (RailSmartContext)dbToSanitize;

            var objList = context.AssessmentNote;

            var template = new Faker<AssessmentNote>(locale: "en_GB")
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                .RuleFor(o => o.Note, f => f.WaffleText(paragraphs: 4, includeHeading: false))
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
                .FinishWith((f, u) =>
                {
                    //Console.WriteLine(
                    //    $"User name {u.User.FullName},  Town = {u.BirthplaceTown}, Postcode = {u.BirthplacePostcode}");
                });

            var batchNumber = 0;
            var batchSize = 100;

            var batch = objList.Take(batchSize);
            var total = objList.Count();
            var batches = total / batchSize;

            while (batch.Any())
            {
                foreach (var assessment in batch)
                {
                    template.Populate(assessment);
                }
                batchNumber++;
                Console.Write($"Completed {((double)batchNumber / (double)batches) * 100.0:##0.00}%, Batch {batchNumber}\r\r\r\r");
                batch = objList.Skip(batchNumber * batchSize).Take(batchSize);
            }

            return context.SaveChanges();
        }

    }
}

