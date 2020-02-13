using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class MedicalAssessmentType
    {
        public MedicalAssessmentType()
        {
            UserMedicalDetail = new HashSet<UserMedicalDetail>();
        }

        public Guid MedicalAssessmentTypeId { get; set; }
        public string Reference { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<UserMedicalDetail> UserMedicalDetail { get; set; }
    }
}
