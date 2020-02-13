using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class IncidentType
    {
        public IncidentType()
        {
            Incident = new HashSet<Incident>();
            SupportPlan = new HashSet<SupportPlan>();
        }

        public Guid IncidentTypeId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Incident> Incident { get; set; }
        public virtual ICollection<SupportPlan> SupportPlan { get; set; }
    }
}
