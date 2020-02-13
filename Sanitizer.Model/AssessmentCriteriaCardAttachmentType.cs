using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class AssessmentCriteriaCardAttachmentType
    {
        public AssessmentCriteriaCardAttachmentType()
        {
            AssessmentCriteriaCardAttachment = new HashSet<AssessmentCriteriaCardAttachment>();
        }

        public Guid AssessmentCriteriaCardAttachmentTypeId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<AssessmentCriteriaCardAttachment> AssessmentCriteriaCardAttachment { get; set; }
    }
}
