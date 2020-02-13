using System;

namespace Sanitizer.Model
{
    public partial class CompetencyElementLearningResource
    {
        public Guid CompetencyElementLearningResourceId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid CompetencyElementId { get; set; }
        public string StorageFileName { get; set; }
        public string DisplayFileName { get; set; }
        public string FileMimeType { get; set; }
        public long FileSizeBytes { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual CompetencyElement CompetencyElement { get; set; }
    }
}
