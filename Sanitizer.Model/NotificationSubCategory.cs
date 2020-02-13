using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class NotificationSubCategory
    {
        public NotificationSubCategory()
        {
            NotificationType = new HashSet<NotificationType>();
        }

        public Guid NotificationSubCategoryId { get; set; }
        public Guid NotificationCategoryId { get; set; }
        public string Reference { get; set; }

        public virtual NotificationCategory NotificationCategory { get; set; }
        public virtual ICollection<NotificationType> NotificationType { get; set; }
    }
}
