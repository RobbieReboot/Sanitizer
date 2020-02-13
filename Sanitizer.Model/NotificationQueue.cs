using System;

namespace Sanitizer.Model
{
    public partial class NotificationQueue
    {
        public Guid NotificationQueueId { get; set; }
        public Guid UserId { get; set; }
        public Guid NotificationTypeId { get; set; }
        public Guid TaskStatusId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? LastProcessedDateTime { get; set; }
        public Guid? RelatedItemId { get; set; }
        public string RelatedItemDescription { get; set; }

        public virtual NotificationType NotificationType { get; set; }
        public virtual TaskStatus TaskStatus { get; set; }
        public virtual User User { get; set; }
    }
}
