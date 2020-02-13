using System;

namespace Sanitizer.Model
{
    public partial class TeamOwner
    {
        public Guid TeamOwnerId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid TeamId { get; set; }
        public Guid OwnerUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool NotificationsEnabled { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual User OwnerUser { get; set; }
        public virtual Team Team { get; set; }
    }
}
