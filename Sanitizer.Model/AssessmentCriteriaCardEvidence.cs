using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class AssessmentCriteriaCardEvidence
    {
        public AssessmentCriteriaCardEvidence()
        {
            AssessmentCriteriaCard = new HashSet<AssessmentCriteriaCard>();
        }

        public Guid AssessmentCriteriaCardEvidenceId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<AssessmentCriteriaCard> AssessmentCriteriaCard { get; set; }
    }
}
