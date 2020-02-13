using System;

namespace Sanitizer.Model
{
    public partial class SupportPlanSignature
    {
        public Guid SupportPlanSignatureId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid SupportPlanId { get; set; }
        public string StorageFileName { get; set; }
        public DateTime Date { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Guid SupportPlanApprovalTypeId { get; set; }
        public string DisplayFileName { get; set; }
        public string FileMimeType { get; set; }
        public long FileSizeBytes { get; set; }

        public virtual Company Company { get; set; }
        public virtual SupportPlan SupportPlan { get; set; }
        public virtual SupportPlanApprovalType SupportPlanApprovalType { get; set; }
    }
}
