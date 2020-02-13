using System;

namespace Sanitizer.Model
{
    public partial class AssessmentCriteriaCardAttachment
    {
        public Guid AssessmentCriteriaCardAttachmentId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid AssessmentCriteriaCardId { get; set; }
        public Guid AssessmentCriteriaCardAttachmentTypeId { get; set; }
        public string StorageFileName { get; set; }
        public string DisplayFileName { get; set; }
        public DateTime DateUploaded { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public bool IsDeleted { get; set; }
        public string FileMimeType { get; set; }
        public long FileSizeBytes { get; set; }

        public virtual AssessmentCriteriaCard AssessmentCriteriaCard { get; set; }
        public virtual AssessmentCriteriaCardAttachmentType AssessmentCriteriaCardAttachmentType { get; set; }
        public virtual Company Company { get; set; }
    }
}
