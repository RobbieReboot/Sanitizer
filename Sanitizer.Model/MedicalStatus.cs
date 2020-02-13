using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class MedicalStatus
    {
        public MedicalStatus()
        {
            UserMedicalDetailMedicalStatus = new HashSet<UserMedicalDetailMedicalStatus>();
        }

        public Guid MedicalStatusId { get; set; }
        public string Reference { get; set; }
        public string Colour { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<UserMedicalDetailMedicalStatus> UserMedicalDetailMedicalStatus { get; set; }
    }
}
