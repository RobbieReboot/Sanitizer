using System;

namespace Sanitizer.Model
{
    public partial class ForceUpdateCompetencyCycleQueue
    {
        public Guid ForceUpdateCompetencyCycleQueueId { get; set; }
        public Guid NewCompetencyCycleId { get; set; }
        public Guid TaskStatusId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? LastProcessedDateTime { get; set; }
        public Guid? CreatedByUserId { get; set; }

        public virtual User CreatedByUser { get; set; }
        public virtual CompetencyCycle NewCompetencyCycle { get; set; }
        public virtual TaskStatus TaskStatus { get; set; }
    }
}
