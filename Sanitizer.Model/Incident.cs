using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Incident
    {
        public Incident()
        {
            IncidentEvent = new HashSet<IncidentEvent>();
            IncidentReport = new HashSet<IncidentReport>();
            SupportPlanIncident = new HashSet<SupportPlanIncident>();
        }

        public Guid IncidentId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateOfIncident { get; set; }
        public Guid IncidentTypeId { get; set; }
        public string Description { get; set; }
        public Guid? IncidentResponsibilityLevelId { get; set; }
        public Guid ReportCompletedByUserId { get; set; }
        public Guid? SupportPlanTypeId { get; set; }
        public Guid? CreatedByUserId { get; set; }
        public DateTime? DateCreated { get; set; }
        public Guid? ArchivedByUserId { get; set; }
        public DateTime? DateArchived { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsArchived { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual User ArchivedByUser { get; set; }
        public virtual Company Company { get; set; }
        public virtual User CreatedByUser { get; set; }
        public virtual IncidentResponsibilityLevel IncidentResponsibilityLevel { get; set; }
        public virtual IncidentType IncidentType { get; set; }
        public virtual User ReportCompletedByUser { get; set; }
        public virtual SupportPlanType SupportPlanType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<IncidentEvent> IncidentEvent { get; set; }
        public virtual ICollection<IncidentReport> IncidentReport { get; set; }
        public virtual ICollection<SupportPlanIncident> SupportPlanIncident { get; set; }
    }
}
