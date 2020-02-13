using System;

namespace Sanitizer.Model
{
    public partial class UserFileNoteDocument
    {
        public Guid UserFileNoteDocumentId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserFileNoteId { get; set; }
        public string DisplayFileName { get; set; }
        public string StorageFileName { get; set; }
        public string FileMimeType { get; set; }
        public long FileSizeBytes { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual UserFileNote UserFileNote { get; set; }
    }
}
