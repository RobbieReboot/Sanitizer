using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class NotificationType
    {
        public NotificationType()
        {
            Notification = new HashSet<Notification>();
            NotificationQueue = new HashSet<NotificationQueue>();
        }

        public Guid NotificationTypeId { get; set; }
        public string Reference { get; set; }
        public Guid NotificationGroupId { get; set; }
        public Guid NotificationSubCategoryId { get; set; }

        public virtual NotificationGroup NotificationGroup { get; set; }
        public virtual NotificationSubCategory NotificationSubCategory { get; set; }
        public virtual ICollection<Notification> Notification { get; set; }
        public virtual ICollection<NotificationQueue> NotificationQueue { get; set; }
    }
}
