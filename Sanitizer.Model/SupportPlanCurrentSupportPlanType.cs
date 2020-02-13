using System;

namespace Sanitizer.Model
{
    public partial class SupportPlanCurrentSupportPlanType
    {
        public Guid SupportPlanCurrentSupportPlanTypeId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid SupportPlanId { get; set; }
        public Guid SupportPlanTypeId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual SupportPlan SupportPlan { get; set; }
        public virtual SupportPlanType SupportPlanType { get; set; }
    }
}
