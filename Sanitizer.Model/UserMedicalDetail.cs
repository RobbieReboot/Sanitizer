using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class UserMedicalDetail
    {
        public UserMedicalDetail()
        {
            UserMedicalDetailFile = new HashSet<UserMedicalDetailFile>();
            UserMedicalDetailMedicalStatus = new HashSet<UserMedicalDetailMedicalStatus>();
        }

        public Guid UserMedicalDetailId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public Guid MedicalAssessmentDetailId { get; set; }
        public Guid MedicalPractitionerId { get; set; }
        public Guid VisionAssessmentId { get; set; }
        public Guid HearingAssessmentId { get; set; }
        public Guid DrugsAndAlcoholAssessmentId { get; set; }
        public string OrrRegistrationNumber { get; set; }
        public string GeneralHealthSummary { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid? MedicalAssessmentTypeId { get; set; }
        public string Recommendations { get; set; }
        public bool ReviewRequired { get; set; }
        public DateTime? DateOfReview { get; set; }
        public Guid? ArchivedByUserId { get; set; }
        public DateTime? DateArchived { get; set; }
        public bool IsArchived { get; set; }
        public Guid? CreatedByUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? OverrideNextAssessmentDate { get; set; }

        public virtual User ArchivedByUser { get; set; }
        public virtual Company Company { get; set; }
        public virtual User CreatedByUser { get; set; }
        public virtual DrugsAlcoholAndDiabetesAssessment DrugsAndAlcoholAssessment { get; set; }
        public virtual HearingAssessment HearingAssessment { get; set; }
        public virtual MedicalAssessmentDetail MedicalAssessmentDetail { get; set; }
        public virtual MedicalAssessmentType MedicalAssessmentType { get; set; }
        public virtual MedicalPractitioner MedicalPractitioner { get; set; }
        public virtual User User { get; set; }
        public virtual VisionAssessment VisionAssessment { get; set; }
        public virtual ICollection<UserMedicalDetailFile> UserMedicalDetailFile { get; set; }
        public virtual ICollection<UserMedicalDetailMedicalStatus> UserMedicalDetailMedicalStatus { get; set; }
    }
}
