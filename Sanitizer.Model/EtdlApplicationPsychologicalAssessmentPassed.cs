using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class EtdlApplicationPsychologicalAssessmentPassed
    {
        public EtdlApplicationPsychologicalAssessmentPassed()
        {
            EtdlUserMedicalDetail = new HashSet<EtdlUserMedicalDetail>();
        }

        public Guid EtdlApplicationPsychologicalAssessmentPassedId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<EtdlUserMedicalDetail> EtdlUserMedicalDetail { get; set; }
    }
}
