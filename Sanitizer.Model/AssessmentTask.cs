using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class AssessmentTask
    {
        public AssessmentTask()
        {
            AssessmentPlannedAssessmentTask = new HashSet<AssessmentPlannedAssessmentTask>();
            AssessmentTaskCompanyRole = new HashSet<AssessmentTaskCompanyRole>();
            AssessmentTaskTime = new HashSet<AssessmentTaskTime>();
        }

        public Guid AssessmentTaskId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<AssessmentPlannedAssessmentTask> AssessmentPlannedAssessmentTask { get; set; }
        public virtual ICollection<AssessmentTaskCompanyRole> AssessmentTaskCompanyRole { get; set; }
        public virtual ICollection<AssessmentTaskTime> AssessmentTaskTime { get; set; }
    }
}
