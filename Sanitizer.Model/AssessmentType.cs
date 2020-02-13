using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class AssessmentType
    {
        public AssessmentType()
        {
            Assessment = new HashSet<Assessment>();
            CompetencyCycleAssessmentWindow = new HashSet<CompetencyCycleAssessmentWindow>();
        }

        public Guid AssessmentTypeId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Colour { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Assessment> Assessment { get; set; }
        public virtual ICollection<CompetencyCycleAssessmentWindow> CompetencyCycleAssessmentWindow { get; set; }
    }
}
