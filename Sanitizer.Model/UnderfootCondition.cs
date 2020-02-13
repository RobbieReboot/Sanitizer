using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class UnderfootCondition
    {
        public UnderfootCondition()
        {
            AssessmentConditionCardEndUnderfootCondition = new HashSet<AssessmentConditionCard>();
            AssessmentConditionCardStartUnderfootCondition = new HashSet<AssessmentConditionCard>();
        }

        public Guid UnderfootConditionId { get; set; }
        public string Reference { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<AssessmentConditionCard> AssessmentConditionCardEndUnderfootCondition { get; set; }
        public virtual ICollection<AssessmentConditionCard> AssessmentConditionCardStartUnderfootCondition { get; set; }
    }
}
