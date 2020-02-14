using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Sanitizer.Contracts;
using Sanitizer.Model;

namespace AssessmentCriteriaCardSanitizer
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
    public class AssessmentCriteriaCardSanitizer : ISanitizer
    {
        public AssessmentCriteriaCardSanitizer()
        {
            Console.WriteLine("AssessmentCriteriaCardSanitizer Loaded.");
        }

        public string Name
        {
            get { return "AssessmentCriteriaCardSanitizer"; }
        }
        public string Description
        {
            get { return "Sanitizes AssessmentCriteriaCardSanitizer table."; }
        }

        public int Sanitize(DbContext dbToSanitize)
        {
            var context = (RailSmartContext)dbToSanitize;

            var assessments = context.AssessmentCriteriaCard;

            var assessmentTemplate = new Faker<AssessmentCriteriaCard>(locale: "en_GB")
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                .RuleFor(o => o.ReasonForRating, f => f.WaffleText(paragraphs: 4, includeHeading: false))
                .RuleFor(o => o.ModifiedDate, f => f.Date.Recent(100))
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
                batch = assessments.Skip(batchNumber * batchSize).Take(batchSize);
            }

            return context.SaveChanges();
        }

    }
}

