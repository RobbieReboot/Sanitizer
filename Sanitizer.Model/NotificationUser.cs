using System;

namespace Sanitizer.Model
{
    public partial class NotificationUser
    {
        public Guid NotificationUserId { get; set; }
        public Guid UserId { get; set; }
        public Guid NotificationId { get; set; }
        public bool Read { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Notification Notification { get; set; }
        public virtual User User { get; set; }
    }
}
