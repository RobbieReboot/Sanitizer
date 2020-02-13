using System;

namespace Sanitizer.Model
{
    public partial class UserFileAccess
    {
        public Guid UserFileAccessId { get; set; }
        public Guid UserId { get; set; }
        public string Filename { get; set; }
        public string ContainerName { get; set; }
        public string BaseAccessUrl { get; set; }
        public string SasToken { get; set; }
        public DateTime ExpiryDate { get; set; }

        public virtual User User { get; set; }
    }
}
