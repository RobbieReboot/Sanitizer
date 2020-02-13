using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class SpeedRestrictionType
    {
        public SpeedRestrictionType()
        {
            AssessmentOtdrDetail = new HashSet<AssessmentOtdrDetail>();
        }

        public Guid SpeedRestrictionTypeId { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<AssessmentOtdrDetail> AssessmentOtdrDetail { get; set; }
    }
}
