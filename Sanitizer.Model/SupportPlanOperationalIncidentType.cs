using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class SupportPlanOperationalIncidentType
    {
        public SupportPlanOperationalIncidentType()
        {
            SupportPlan = new HashSet<SupportPlan>();
        }

        public Guid SupportPlanOperationalIncidentTypeId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<SupportPlan> SupportPlan { get; set; }
    }
}
