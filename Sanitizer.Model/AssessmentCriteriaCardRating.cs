using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class AssessmentCriteriaCardRating
    {
        public AssessmentCriteriaCardRating()
        {
            AssessmentCriteriaCard = new HashSet<AssessmentCriteriaCard>();
        }

        public Guid AssessmentCriteriaCardRatingId { get; set; }
        public string Reference { get; set; }
        public int OrderIndex { get; set; }
        public string Colour { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<AssessmentCriteriaCard> AssessmentCriteriaCard { get; set; }
    }
}
