using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Sanitizer;
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
            var template = new Faker<AssessmentCriteriaCard>(locale: "en_GB")
                //.CustomInstantiator(f => new TableUser(customerId++.ToString()))
                .RuleFor(o => o.ReasonForRating, f => f.WaffleText(paragraphs: 4, includeHeading: false))
                .FinishWith((f, u) =>
                {
                    //Console.WriteLine(
                    //    $"User name {u.User.FullName},  Town = {u.BirthplaceTown}, Postcode = {u.BirthplacePostcode}");
                });
            var context = (RailSmartContext)dbToSanitize;
            SanitizerUtil.Sanitize(dbToSanitize, context.AssessmentCriteriaCard, template);

            return context.SaveChanges();
        }

    }
}

