using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class MedicationInformationCategory
    {
        public MedicationInformationCategory()
        {
            UserMedicationInformation = new HashSet<UserMedicationInformation>();
        }

        public Guid MedicationInformationCategoryId { get; set; }
        public string Reference { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<UserMedicationInformation> UserMedicationInformation { get; set; }
    }
}
