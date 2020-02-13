using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class VerificationStatementRating
    {
        public VerificationStatementRating()
        {
            AssessmentVerificationStatement = new HashSet<AssessmentVerificationStatement>();
            SupportPlanVerificationStatement = new HashSet<SupportPlanVerificationStatement>();
        }

        public Guid VerificationStatementRatingId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<AssessmentVerificationStatement> AssessmentVerificationStatement { get; set; }
        public virtual ICollection<SupportPlanVerificationStatement> SupportPlanVerificationStatement { get; set; }
    }
}
