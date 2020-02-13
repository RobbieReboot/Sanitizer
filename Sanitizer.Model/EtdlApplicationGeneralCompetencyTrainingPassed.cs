using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class EtdlApplicationGeneralCompetencyTrainingPassed
    {
        public EtdlApplicationGeneralCompetencyTrainingPassed()
        {
            EtdlUserMedicalDetail = new HashSet<EtdlUserMedicalDetail>();
        }

        public Guid EtdlApplicationGeneralCompetencyTrainingPassedId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<EtdlUserMedicalDetail> EtdlUserMedicalDetail { get; set; }
    }
}
