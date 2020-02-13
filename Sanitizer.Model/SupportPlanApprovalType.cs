using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class SupportPlanApprovalType
    {
        public SupportPlanApprovalType()
        {
            SupportPlanApproval = new HashSet<SupportPlanApproval>();
            SupportPlanSignature = new HashSet<SupportPlanSignature>();
        }

        public Guid SupportPlanApprovalTypeId { get; set; }
        public string Reference { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<SupportPlanApproval> SupportPlanApproval { get; set; }
        public virtual ICollection<SupportPlanSignature> SupportPlanSignature { get; set; }
    }
}
