using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class NotificationGroup
    {
        public NotificationGroup()
        {
            NotificationType = new HashSet<NotificationType>();
        }

        public Guid NotificationGroupId { get; set; }
        public string Reference { get; set; }
        public string Colour { get; set; }

        public virtual ICollection<NotificationType> NotificationType { get; set; }
    }
}
