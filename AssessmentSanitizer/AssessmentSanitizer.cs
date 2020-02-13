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
            get { return "AssessmentSanitizer"; }
        }
        public string Description
        {
            get { return "Sanitizes assessments table."; }
        }

        public int Sanitize(DbContext dbToSanitize)
        {
            var context = (RailSmartContext) dbToSanitize;

            var assessments = context.Assessment;

            var assessmentTemplate = new Faker<Assessment>(locale: "en_GB")
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

            var batch = assessments.Take(batchSize);
            while (batch.Any())
            {
                foreach (var assessment in batch)
                {
                    assessmentTemplate.Populate(assessment);
                }
                batchNumber++;
                batch = assessments.Skip(batchNumber*batchSize).Take(batchSize);
            }

            return context.SaveChanges();
        }

    }
}

