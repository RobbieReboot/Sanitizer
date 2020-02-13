using System;

namespace Sanitizer.Model
{
    public partial class AssessmentPlannedAssessmentTask
    {
        public Guid AssessmentPlannedAssessmentTaskId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid AssessmentId { get; set; }
        public Guid AssessmentTaskId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Assessment Assessment { get; set; }
        public virtual AssessmentTask AssessmentTask { get; set; }
        public virtual Company Company { get; set; }
    }
}
