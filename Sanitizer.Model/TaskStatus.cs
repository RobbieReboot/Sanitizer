using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class TaskStatus
    {
        public TaskStatus()
        {
            ForceUpdateCompetencyCycleQueue = new HashSet<ForceUpdateCompetencyCycleQueue>();
            NotificationQueue = new HashSet<NotificationQueue>();
        }

        public Guid TaskStatusId { get; set; }
        public string Reference { get; set; }

        public virtual ICollection<ForceUpdateCompetencyCycleQueue> ForceUpdateCompetencyCycleQueue { get; set; }
        public virtual ICollection<NotificationQueue> NotificationQueue { get; set; }
    }
}
