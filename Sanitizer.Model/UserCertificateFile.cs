using System;

namespace Sanitizer.Model
{
    public partial class UserCertificateFile
    {
        public Guid UserCertificateFileId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateAdded { get; set; }
        public string Notes { get; set; }
        public string DisplayFileName { get; set; }
        public string StorageFileName { get; set; }
        public string FileMimeType { get; set; }
        public long FileSizeBytes { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string DisplayName { get; set; }

        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
    }
}
