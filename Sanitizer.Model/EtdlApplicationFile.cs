using System;

namespace Sanitizer.Model
{
    public partial class EtdlApplicationFile
    {
        public Guid EtdlApplicationFileId { get; set; }
        public Guid? EtdlApplicationFileTypeId { get; set; }
        public Guid EtdlApplicationId { get; set; }
        public string DisplayFileName { get; set; }
        public string StorageFileName { get; set; }
        public string FileMimeType { get; set; }
        public long FileSizeBytes { get; set; }
        public bool IsDeleted { get; set; }

        public virtual EtdlApplication EtdlApplication { get; set; }
        public virtual EtdlApplicationFileType EtdlApplicationFileType { get; set; }
    }
}
