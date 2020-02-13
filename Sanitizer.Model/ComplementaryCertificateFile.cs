using System;

namespace Sanitizer.Model
{
    public partial class ComplementaryCertificateFile
    {
        public Guid ComplementaryCertificateFileId { get; set; }
        public Guid? ComplementaryCertificateFileTypeId { get; set; }
        public Guid ComplementaryCertificateId { get; set; }
        public string DisplayFileName { get; set; }
        public string StorageFileName { get; set; }
        public string FileMimeType { get; set; }
        public long FileSizeBytes { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ComplementaryCertificate ComplementaryCertificate { get; set; }
        public virtual ComplementaryCertificateFileType ComplementaryCertificateFileType { get; set; }
    }
}
