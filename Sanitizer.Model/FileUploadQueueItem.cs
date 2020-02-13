using System;

namespace Sanitizer.Model
{
    public partial class FileUploadQueueItem
    {
        public Guid FileUploadQueueItemId { get; set; }
        public string Filename { get; set; }
        public string ContainerName { get; set; }
        public byte[] FileData { get; set; }
        public string MimeType { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateLastAttemptUploaded { get; set; }
        public int UploadAttemptCount { get; set; }
        public string Exception { get; set; }
    }
}
