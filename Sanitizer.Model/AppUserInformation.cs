using System;

namespace Sanitizer.Model
{
    public partial class AppUserInformation
    {
        public Guid UserId { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime? PreviousSynchronisedTimestamp { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Device { get; set; }
        public string DeviceVersion { get; set; }
        public string SoftwareVersion { get; set; }

        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
    }
}
