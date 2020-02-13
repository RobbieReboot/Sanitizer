using System;

namespace Sanitizer.Model
{
    public partial class UserApiSyncTime
    {
        public Guid UserApiSyncTimeId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public DateTime SyncStartDate { get; set; }
        public DateTime? SyncEndDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? ParseStartDate { get; set; }
        public DateTime? ParseEndDate { get; set; }
        public string Device { get; set; }
        public string DeviceVersion { get; set; }
        public string SoftwareVersion { get; set; }

        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
    }
}
