using System;

namespace Sanitizer.Model
{
    public partial class SupportPlanVerificationStatement
    {
        public Guid SupportPlanVerificationStatementId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid SupportPlanId { get; set; }
        public Guid VerificationStatementId { get; set; }
        public Guid? VerificationStatementRatingId { get; set; }
        public string RatingReason { get; set; }
        public string RecommendedAction { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual SupportPlan SupportPlan { get; set; }
        public virtual VerificationStatement VerificationStatement { get; set; }
        public virtual VerificationStatementRating VerificationStatementRating { get; set; }
    }
}
