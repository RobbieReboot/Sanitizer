using System;

namespace Sanitizer.Model
{
    public partial class IncidentReport
    {
        public Guid IncidentReportId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid IncidentId { get; set; }
        public string StorageFileName { get; set; }
        public string DisplayFileName { get; set; }
        public string FileMimeType { get; set; }
        public long FileSizeBytes { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Company Company { get; set; }
        public virtual Incident Incident { get; set; }
    }
}
