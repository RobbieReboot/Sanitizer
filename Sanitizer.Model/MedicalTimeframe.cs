using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class MedicalTimeframe
    {
        public MedicalTimeframe()
        {
            MedicalAssessmentDetail = new HashSet<MedicalAssessmentDetail>();
        }

        public Guid MedicalTimeframeId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<MedicalAssessmentDetail> MedicalAssessmentDetail { get; set; }
    }
}
