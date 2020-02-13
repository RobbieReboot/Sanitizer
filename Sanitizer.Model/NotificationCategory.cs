using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class NotificationCategory
    {
        public NotificationCategory()
        {
            NotificationSubCategory = new HashSet<NotificationSubCategory>();
        }

        public Guid NotificationCategoryId { get; set; }
        public string Reference { get; set; }

        public virtual ICollection<NotificationSubCategory> NotificationSubCategory { get; set; }
    }
}
