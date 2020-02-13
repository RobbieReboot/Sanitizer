using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Visibility
    {
        public Visibility()
        {
            AssessmentConditionCardEndVisibility = new HashSet<AssessmentConditionCard>();
            AssessmentConditionCardStartVisibility = new HashSet<AssessmentConditionCard>();
        }

        public Guid VisibilityId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<AssessmentConditionCard> AssessmentConditionCardEndVisibility { get; set; }
        public virtual ICollection<AssessmentConditionCard> AssessmentConditionCardStartVisibility { get; set; }
    }
}
