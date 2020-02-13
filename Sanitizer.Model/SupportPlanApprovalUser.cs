using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class SupportPlanApprovalUser
    {
        public SupportPlanApprovalUser()
        {
            SupportPlanApproval = new HashSet<SupportPlanApproval>();
        }

        public Guid SupportPlanApprovalUserId { get; set; }
        public Guid SupportPlanId { get; set; }
        public Guid UserId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual SupportPlan SupportPlan { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<SupportPlanApproval> SupportPlanApproval { get; set; }
    }
}
