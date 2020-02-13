using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class EtdlApplicationMedicalExaminationPassed
    {
        public EtdlApplicationMedicalExaminationPassed()
        {
            EtdlUserMedicalDetail = new HashSet<EtdlUserMedicalDetail>();
        }

        public Guid EtdlApplicationMedicalExaminationPassedId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<EtdlUserMedicalDetail> EtdlUserMedicalDetail { get; set; }
    }
}
