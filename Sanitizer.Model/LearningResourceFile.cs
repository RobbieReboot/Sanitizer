using System;

namespace Sanitizer.Model
{
    public partial class LearningResourceFile
    {
        public Guid LearningResourceFileId { get; set; }
        public Guid LearningResourceId { get; set; }
        public Guid CompanyId { get; set; }
        public string DisplayFileName { get; set; }
        public string StorageFileName { get; set; }
        public string FileMimeType { get; set; }
        public long FileSizeBytes { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid ModifiedByUserId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual LearningResource LearningResource { get; set; }
        public virtual User ModifiedByUser { get; set; }
    }
}
