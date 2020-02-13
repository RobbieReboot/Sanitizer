using System;

namespace Sanitizer.Model
{
    public partial class TrainingDocument
    {
        public Guid TrainingDocumentId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid TrainingId { get; set; }
        public string DisplayFileName { get; set; }
        public string StorageFileName { get; set; }
        public string FileMimeType { get; set; }
        public long FileSizeBytes { get; set; }
        public Guid ModifiedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual Training Training { get; set; }
    }
}
