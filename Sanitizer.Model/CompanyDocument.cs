using System;

namespace Sanitizer.Model
{
    public partial class CompanyDocument
    {
        public Guid CompanyDocumentId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid CompanyDocumentTypeId { get; set; }
        public string DisplayFileName { get; set; }
        public string StorageFileName { get; set; }
        public string FileMimeType { get; set; }
        public bool IsDeleted { get; set; }
        public long FileSizeBytes { get; set; }
        public string Title { get; set; }

        public virtual Company Company { get; set; }
        public virtual CompanyDocumentType CompanyDocumentType { get; set; }
    }
}
