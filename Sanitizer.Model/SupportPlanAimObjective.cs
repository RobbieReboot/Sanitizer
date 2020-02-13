using System;

namespace Sanitizer.Model
{
    public partial class SupportPlanAimObjective
    {
        public Guid SupportPlanAimObjectiveId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid SupportPlanId { get; set; }
        public string Description { get; set; }
        public int OrderIndex { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual SupportPlan SupportPlan { get; set; }
    }
}
