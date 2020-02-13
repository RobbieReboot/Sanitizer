using System;

namespace Sanitizer.Model
{
    public partial class TrainingTemplateClassroom
    {
        public Guid TrainingTemplateClassroomId { get; set; }

        public virtual TrainingTemplate TrainingTemplateClassroomNavigation { get; set; }
    }
}
