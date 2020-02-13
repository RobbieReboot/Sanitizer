using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class IncidentResponsibilityLevel
    {
        public IncidentResponsibilityLevel()
        {
            Incident = new HashSet<Incident>();
        }

        public Guid IncidentResponsibilityLevelId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Incident> Incident { get; set; }
    }
}
