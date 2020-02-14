﻿using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Sanitizer.Contracts;
using Sanitizer.Model;

namespace AssessmentSanitizer
{
    /// <summary>
    /// Cleans the Assessments table
    /// </summary>
    /// <remarks>
    ///-- Notes nvarchar(max)
    ///-- AssessorFeedback nvarchar(max)
    ///-- VerifierFinalFeedback nvarchar(max)
    ///-- AssessorVerificationResponseNotes nvarchar(max)
    /// </remarks>
    [Export(typeof(ISanitizer))]
    public class AssessmentSanitizer : ISanitizer
    {
        public AssessmentSanitizer()
        {
            Console.WriteLine("AssessmentSanitizer Loaded.");
        }

        public string Name
        {
            get { return "Assessment"; }
        }
        public string Description
        {
            get { return "Sanitizes assessments table."; }
        }

        public int Sanitize(DbContext dbToSanitize)
        {
            var context = (RailSmartContext) dbToSanitize;

            var objList = context.Assessment;

            var template  = new Faker<Assessment>(locale: "en_GB")
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                .RuleFor(o => o.Notes, f => f.WaffleText(paragraphs: 4, includeHeading: false))
                .RuleFor(o => o.AssessorFeedback, f => f.WaffleText(paragraphs: 4, includeHeading: false))
                .RuleFor(o => o.VerifierFinalFeedback, f => f.WaffleText(paragraphs: 4, includeHeading: false))
                .RuleFor(o => o.AssessorVerificationResponseNotes, f => f.WaffleText(paragraphs: 4, includeHeading: false))

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
                batch = objList.Skip(batchNumber * batchSize).Take(batchSize);
                Console.Write($"Completed {((double)batchNumber / (double)batches) * 100.0:##0.00}%, Batch {batchNumber}\r\r\r\r");
            }
            return context.SaveChanges();
        }

    }
}

