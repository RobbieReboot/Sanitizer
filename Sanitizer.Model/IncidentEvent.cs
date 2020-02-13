using System;

namespace Sanitizer.Model
{
    public partial class IncidentEvent
    {
        public Guid IncidentEventId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid IncidentId { get; set; }
        public DateTime? Date { get; set; }
        public string Notes { get; set; }
        public int OrderIndex { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual Incident Incident { get; set; }
    }
}
