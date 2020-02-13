using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Platform
    {
        public Platform()
        {
            AssessmentCompletedOnPlatform = new HashSet<Assessment>();
            AssessmentCreatedOnPlatform = new HashSet<Assessment>();
            AssessmentCriteriaCard = new HashSet<AssessmentCriteriaCard>();
        }

        public Guid PlatformId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Assessment> AssessmentCompletedOnPlatform { get; set; }
        public virtual ICollection<Assessment> AssessmentCreatedOnPlatform { get; set; }
        public virtual ICollection<AssessmentCriteriaCard> AssessmentCriteriaCard { get; set; }
    }
}
