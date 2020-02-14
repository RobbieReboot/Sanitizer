using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Sanitizer;
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

            var context = (RailSmartContext)dbToSanitize;

            SanitizerUtil.Sanitize<Assessment>(dbToSanitize, context.Assessment, template);

            return context.SaveChanges();

        }

    }
}

