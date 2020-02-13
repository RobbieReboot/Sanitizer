using System;

namespace Sanitizer.Model
{
    public partial class UserMedicationInformation
    {
        public Guid UserMedicationInformationId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public Guid MedicationInformationCategoryId { get; set; }
        public string Name { get; set; }
        public string PrescriptionReason { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Notes { get; set; }
        public bool ReviewRequired { get; set; }
        public DateTime? ReviewDate { get; set; }
        public bool IsArchived { get; set; }
        public Guid? ArchivedByUserId { get; set; }
        public DateTime? DateArchived { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual User ArchivedByUser { get; set; }
        public virtual Company Company { get; set; }
        public virtual MedicationInformationCategory MedicationInformationCategory { get; set; }
        public virtual User User { get; set; }
    }
}
