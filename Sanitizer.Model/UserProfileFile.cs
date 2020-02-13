using System;

namespace Sanitizer.Model
{
    public partial class UserProfileFile
    {
        public Guid UserProfileFileId { get; set; }
        public Guid UserProfileFileTypeId { get; set; }
        public Guid UserProfileId { get; set; }
        public string DisplayFileName { get; set; }
        public string StorageFileName { get; set; }
        public string FileMimeType { get; set; }
        public long FileSizeBytes { get; set; }
        public bool IsDeleted { get; set; }

        public virtual UserProfile UserProfile { get; set; }
        public virtual UserProfileFileType UserProfileFileType { get; set; }
    }
}
