using System;

namespace Sanitizer.Model
{
    public partial class TrainingClassroom
    {
        public Guid TrainingClassroomId { get; set; }

        public virtual Training TrainingClassroomNavigation { get; set; }
    }
}
