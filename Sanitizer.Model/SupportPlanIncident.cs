using System;

namespace Sanitizer.Model
{
    public partial class SupportPlanIncident
    {
        public Guid SupportPlanIncidentId { get; set; }
        public Guid SupportPlanId { get; set; }
        public Guid IncidentId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime? DateCreated { get; set; }
        public Guid? CreatedByUserId { get; set; }

        public virtual User CreatedByUser { get; set; }
        public virtual Incident Incident { get; set; }
        public virtual SupportPlan SupportPlan { get; set; }
    }
}
