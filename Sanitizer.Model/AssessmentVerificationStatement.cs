using System;

namespace Sanitizer.Model
{
    public partial class AssessmentVerificationStatement
    {
        public Guid AssessmentVerificationStatementId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid AssessmentId { get; set; }
        public Guid VerificationStatementId { get; set; }
        public Guid? VerificationStatementRatingId { get; set; }
        public string RatingReason { get; set; }
        public string RecommendedAction { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Assessment Assessment { get; set; }
        public virtual Company Company { get; set; }
        public virtual VerificationStatement VerificationStatement { get; set; }
        public virtual VerificationStatementRating VerificationStatementRating { get; set; }
    }
}
