using System;

namespace Sanitizer.Model
{
    public partial class AssessmentTaskTime
    {
        public Guid AssessmentTaskTimeId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid AssessmentId { get; set; }
        public Guid AssessmentTaskId { get; set; }
        public bool IsPractical { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Assessment Assessment { get; set; }
        public virtual AssessmentTask AssessmentTask { get; set; }
        public virtual Company Company { get; set; }
    }
}
