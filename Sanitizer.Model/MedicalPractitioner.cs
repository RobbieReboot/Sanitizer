using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class MedicalPractitioner
    {
        public MedicalPractitioner()
        {
            UserMedicalDetail = new HashSet<UserMedicalDetail>();
        }

        public Guid MedicalPractitionerId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public Guid AddressId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Address Address { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<UserMedicalDetail> UserMedicalDetail { get; set; }
    }
}
