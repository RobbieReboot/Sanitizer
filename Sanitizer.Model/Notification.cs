using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Notification
    {
        public Notification()
        {
            NotificationUser = new HashSet<NotificationUser>();
        }

        public Guid NotificationId { get; set; }
        public Guid UserId { get; set; }
        public Guid NotificationTypeId { get; set; }
        public DateTime ProcessedDateTime { get; set; }
        public Guid? RelatedItemId { get; set; }
        public string RelatedItemDescription { get; set; }
        public bool IsDeleted { get; set; }

        public virtual NotificationType NotificationType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<NotificationUser> NotificationUser { get; set; }
    }
}
