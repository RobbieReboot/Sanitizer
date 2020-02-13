using System;

namespace Sanitizer.Model
{
    public partial class SupportPlanApproval
    {
        public Guid SupportPlanApprovalId { get; set; }
        public Guid SupportPlanApprovalUserId { get; set; }
        public Guid SupportPlanApprovalTypeId { get; set; }
        public bool? ApprovedSupportPlan { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual SupportPlanApprovalType SupportPlanApprovalType { get; set; }
        public virtual SupportPlanApprovalUser SupportPlanApprovalUser { get; set; }
    }
}
