using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class AssessmentCompetency
    {
        public AssessmentCompetency()
        {
            Assessment = new HashSet<Assessment>();
        }

        public Guid AssessmentCompetencyId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Colour { get; set; }

        public virtual ICollection<Assessment> Assessment { get; set; }
    }
}
