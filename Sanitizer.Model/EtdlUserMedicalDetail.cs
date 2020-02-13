using System;

namespace Sanitizer.Model
{
    public partial class EtdlUserMedicalDetail
    {
        public Guid EtdlUserMedicalDetailId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid EtdlUserDetailId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool? NeedGlasses { get; set; }
        public bool? NeedContactLenses { get; set; }
        public bool? HasTintedLenses { get; set; }
        public bool? NeedHearingAid { get; set; }
        public Guid? OrrDoctorId { get; set; }
        public DateTime? MedicalExaminationDate { get; set; }
        public Guid? OrrPsychologistId { get; set; }
        public DateTime? PsychologicalAssessmentDate { get; set; }
        public Guid? EtdlApplicationMedicalExaminationPassedId { get; set; }
        public Guid? EtdlApplicationPsychologicalAssessmentPassedId { get; set; }
        public Guid? EtdlApplicationGeneralCompetencyTrainingPassedId { get; set; }

        public virtual Company Company { get; set; }
        public virtual EtdlApplicationGeneralCompetencyTrainingPassed EtdlApplicationGeneralCompetencyTrainingPassed { get; set; }
        public virtual EtdlApplicationMedicalExaminationPassed EtdlApplicationMedicalExaminationPassed { get; set; }
        public virtual EtdlApplicationPsychologicalAssessmentPassed EtdlApplicationPsychologicalAssessmentPassed { get; set; }
        public virtual EtdlUserDetail EtdlUserDetail { get; set; }
        public virtual OrrDoctorInformation OrrDoctor { get; set; }
        public virtual OrrDoctorInformation OrrPsychologist { get; set; }
    }
}
