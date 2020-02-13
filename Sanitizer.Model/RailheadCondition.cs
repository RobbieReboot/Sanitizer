using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class RailheadCondition
    {
        public RailheadCondition()
        {
            AssessmentConditionCardEndRailheadCondition = new HashSet<AssessmentConditionCard>();
            AssessmentConditionCardStartRailheadCondition = new HashSet<AssessmentConditionCard>();
        }

        public Guid RailheadConditionId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<AssessmentConditionCard> AssessmentConditionCardEndRailheadCondition { get; set; }
        public virtual ICollection<AssessmentConditionCard> AssessmentConditionCardStartRailheadCondition { get; set; }
    }
}
