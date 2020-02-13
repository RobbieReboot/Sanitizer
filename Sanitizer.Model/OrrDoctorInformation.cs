using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class OrrDoctorInformation
    {
        public OrrDoctorInformation()
        {
            EtdlUserMedicalDetailOrrDoctor = new HashSet<EtdlUserMedicalDetail>();
            EtdlUserMedicalDetailOrrPsychologist = new HashSet<EtdlUserMedicalDetail>();
        }

        public Guid OrrDoctorInformationId { get; set; }
        public string RegisterNumber { get; set; }
        public string Name { get; set; }
        public string NameOfPractice { get; set; }
        public string Building { get; set; }
        public string NumberAndStreet { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<EtdlUserMedicalDetail> EtdlUserMedicalDetailOrrDoctor { get; set; }
        public virtual ICollection<EtdlUserMedicalDetail> EtdlUserMedicalDetailOrrPsychologist { get; set; }
    }
}
