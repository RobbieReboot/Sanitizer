using System;

namespace Sanitizer.Model
{
    public partial class UserMedicalDetailMedicalStatus
    {
        public Guid UserMedicalDetailMedicalStatusId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? UserMedicalDetailId { get; set; }
        public Guid MedicalStatusId { get; set; }
        public Guid? UpdatedByUserId { get; set; }
        public string Notes { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsOverridden { get; set; }
        public Guid? UserId { get; set; }

        public virtual Company Company { get; set; }
        public virtual MedicalStatus MedicalStatus { get; set; }
        public virtual User UpdatedByUser { get; set; }
        public virtual User User { get; set; }
        public virtual UserMedicalDetail UserMedicalDetail { get; set; }
    }
}
