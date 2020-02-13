using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class MedicalIndicator
    {
        public MedicalIndicator()
        {
            MedicalAssessmentDetail = new HashSet<MedicalAssessmentDetail>();
        }

        public Guid MedicalIndicatorId { get; set; }
        public string Reference { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<MedicalAssessmentDetail> MedicalAssessmentDetail { get; set; }
    }
}
