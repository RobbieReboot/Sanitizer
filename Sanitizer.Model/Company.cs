using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Company
    {
        public Company()
        {
            Address = new HashSet<Address>();
            AppUserInformation = new HashSet<AppUserInformation>();
            Assessment = new HashSet<Assessment>();
            AssessmentConditionCard = new HashSet<AssessmentConditionCard>();
            AssessmentConditionCardRoute = new HashSet<AssessmentConditionCardRoute>();
            AssessmentCriteriaCard = new HashSet<AssessmentCriteriaCard>();
            AssessmentCriteriaCardAttachment = new HashSet<AssessmentCriteriaCardAttachment>();
            AssessmentDocument = new HashSet<AssessmentDocument>();
            AssessmentNote = new HashSet<AssessmentNote>();
            AssessmentPlannedAssessmentTask = new HashSet<AssessmentPlannedAssessmentTask>();
            AssessmentSignature = new HashSet<AssessmentSignature>();
            AssessmentTask = new HashSet<AssessmentTask>();
            AssessmentTaskCompanyRole = new HashSet<AssessmentTaskCompanyRole>();
            AssessmentTaskTime = new HashSet<AssessmentTaskTime>();
            AssessmentVerificationStatement = new HashSet<AssessmentVerificationStatement>();
            CertificateLost = new HashSet<CertificateLost>();
            CertificateStolen = new HashSet<CertificateStolen>();
            CertificateWithdrawn = new HashSet<CertificateWithdrawn>();
            CompanyDocument = new HashSet<CompanyDocument>();
            CompanyRole = new HashSet<CompanyRole>();
            CompetencyCriteria = new HashSet<CompetencyCriteria>();
            CompetencyCycle = new HashSet<CompetencyCycle>();
            CompetencyCycleAssessmentWindow = new HashSet<CompetencyCycleAssessmentWindow>();
            CompetencyCycleCriteria = new HashSet<CompetencyCycleCriteria>();
            CompetencyElement = new HashSet<CompetencyElement>();
            CompetencyElementLearningResource = new HashSet<CompetencyElementLearningResource>();
            CompetencyUnit = new HashSet<CompetencyUnit>();
            ComplementaryCertificate = new HashSet<ComplementaryCertificate>();
            ComplementaryCertificateCompanyDetail = new HashSet<ComplementaryCertificateCompanyDetail>();
            ComplementaryCertificateUserDetail = new HashSet<ComplementaryCertificateUserDetail>();
            ComplementaryCertificateUserDetailDrivingCategory = new HashSet<ComplementaryCertificateUserDetailDrivingCategory>();
            ComplementaryCertificateUserDetailLanguageSkill = new HashSet<ComplementaryCertificateUserDetailLanguageSkill>();
            Department = new HashSet<Department>();
            DriverIrregularity = new HashSet<DriverIrregularity>();
            DrugsAlcoholAndDiabetesAssessment = new HashSet<DrugsAlcoholAndDiabetesAssessment>();
            EtdlApplication = new HashSet<EtdlApplication>();
            EtdlApplicationDetail = new HashSet<EtdlApplicationDetail>();
            EtdlCompanyDetail = new HashSet<EtdlCompanyDetail>();
            EtdlUpdate = new HashSet<EtdlUpdate>();
            EtdlUserDetail = new HashSet<EtdlUserDetail>();
            EtdlUserMedicalDetail = new HashSet<EtdlUserMedicalDetail>();
            HearingAssessment = new HashSet<HearingAssessment>();
            Incident = new HashSet<Incident>();
            IncidentEvent = new HashSet<IncidentEvent>();
            IncidentReport = new HashSet<IncidentReport>();
            InfrastructureAuthorisedToOperate = new HashSet<InfrastructureAuthorisedToOperate>();
            IssuingOrganisationNavigation = new HashSet<IssuingOrganisation>();
            LearningResource = new HashSet<LearningResource>();
            LearningResourceFile = new HashSet<LearningResourceFile>();
            Location = new HashSet<Location>();
            MedicalAssessmentDetail = new HashSet<MedicalAssessmentDetail>();
            MedicalPractitioner = new HashSet<MedicalPractitioner>();
            RollingStockAuthorisedToOperate = new HashSet<RollingStockAuthorisedToOperate>();
            Route = new HashSet<Route>();
            SafetyBrief = new HashSet<SafetyBrief>();
            Skill = new HashSet<Skill>();
            SupportLevel = new HashSet<SupportLevel>();
            SupportPlan = new HashSet<SupportPlan>();
            SupportPlanAimObjective = new HashSet<SupportPlanAimObjective>();
            SupportPlanCurrentSupportPlanType = new HashSet<SupportPlanCurrentSupportPlanType>();
            SupportPlanDocument = new HashSet<SupportPlanDocument>();
            SupportPlanInteraction = new HashSet<SupportPlanInteraction>();
            SupportPlanManagerJustification = new HashSet<SupportPlanManagerJustification>();
            SupportPlanNote = new HashSet<SupportPlanNote>();
            SupportPlanSignature = new HashSet<SupportPlanSignature>();
            SupportPlanVerificationStatement = new HashSet<SupportPlanVerificationStatement>();
            Team = new HashSet<Team>();
            TeamOwner = new HashSet<TeamOwner>();
            Traction = new HashSet<Traction>();
            Training = new HashSet<Training>();
            TrainingDocument = new HashSet<TrainingDocument>();
            TrainingTemplate = new HashSet<TrainingTemplate>();
            TrainingTemplateDocument = new HashSet<TrainingTemplateDocument>();
            TrainingTemplateSkill = new HashSet<TrainingTemplateSkill>();
            User = new HashSet<User>();
            UserApiSyncTime = new HashSet<UserApiSyncTime>();
            UserAuthorityToWorkStatus = new HashSet<UserAuthorityToWorkStatus>();
            UserCertificateFile = new HashSet<UserCertificateFile>();
            UserCompanyRole = new HashSet<UserCompanyRole>();
            UserCompanyRoleArchive = new HashSet<UserCompanyRoleArchive>();
            UserDepartmentAccess = new HashSet<UserDepartmentAccess>();
            UserEndedCompetencyCycle = new HashSet<UserEndedCompetencyCycle>();
            UserFileNote = new HashSet<UserFileNote>();
            UserFileNoteDocument = new HashSet<UserFileNoteDocument>();
            UserMedicalDetail = new HashSet<UserMedicalDetail>();
            UserMedicalDetailFile = new HashSet<UserMedicalDetailFile>();
            UserMedicalDetailMedicalStatus = new HashSet<UserMedicalDetailMedicalStatus>();
            UserMedicalTestRequest = new HashSet<UserMedicalTestRequest>();
            UserMedicationInformation = new HashSet<UserMedicationInformation>();
            UserPreference = new HashSet<UserPreference>();
            UserProfile = new HashSet<UserProfile>();
            UserRecruitmentDetail = new HashSet<UserRecruitmentDetail>();
            UserRecruitmentDetailFile = new HashSet<UserRecruitmentDetailFile>();
            UserSafetyBriefing = new HashSet<UserSafetyBriefing>();
            UserSafetyBriefingDocument = new HashSet<UserSafetyBriefingDocument>();
            UserSafetyCriticalStatus = new HashSet<UserSafetyCriticalStatus>();
            UserSkill = new HashSet<UserSkill>();
            UserSupportLevel = new HashSet<UserSupportLevel>();
            UserTeam = new HashSet<UserTeam>();
            UserTimeWithManager = new HashSet<UserTimeWithManager>();
            UserTimeWithManagerDocument = new HashSet<UserTimeWithManagerDocument>();
            VerificationStatement = new HashSet<VerificationStatement>();
            VisionAssessment = new HashSet<VisionAssessment>();
            YouRole = new HashSet<YouRole>();
        }

        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string Culture { get; set; }
        public decimal BaseLocationLatitude { get; set; }
        public decimal BaseLocationLongitude { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? AddressId { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public Guid SafetyOrganisationId { get; set; }
        public Guid? IssuingOrganisationId { get; set; }
        public int ReportingWeekEndDay { get; set; }
        public TimeSpan ReportingWeekEndTime { get; set; }
        public string CompanyCode { get; set; }
        public int UserLicencesLimit { get; set; }
        public long StorageFileBytesLimit { get; set; }
        public bool? Enabled { get; set; }
        public bool IsTrainingAndDevelopmentActive { get; set; }

        public virtual Address AddressNavigation { get; set; }
        public virtual IssuingOrganisation IssuingOrganisation { get; set; }
        public virtual SafetyOrganisation SafetyOrganisation { get; set; }
        public virtual CompanyFeature CompanyFeature { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<AppUserInformation> AppUserInformation { get; set; }
        public virtual ICollection<Assessment> Assessment { get; set; }
        public virtual ICollection<AssessmentConditionCard> AssessmentConditionCard { get; set; }
        public virtual ICollection<AssessmentConditionCardRoute> AssessmentConditionCardRoute { get; set; }
        public virtual ICollection<AssessmentCriteriaCard> AssessmentCriteriaCard { get; set; }
        public virtual ICollection<AssessmentCriteriaCardAttachment> AssessmentCriteriaCardAttachment { get; set; }
        public virtual ICollection<AssessmentDocument> AssessmentDocument { get; set; }
        public virtual ICollection<AssessmentNote> AssessmentNote { get; set; }
        public virtual ICollection<AssessmentPlannedAssessmentTask> AssessmentPlannedAssessmentTask { get; set; }
        public virtual ICollection<AssessmentSignature> AssessmentSignature { get; set; }
        public virtual ICollection<AssessmentTask> AssessmentTask { get; set; }
        public virtual ICollection<AssessmentTaskCompanyRole> AssessmentTaskCompanyRole { get; set; }
        public virtual ICollection<AssessmentTaskTime> AssessmentTaskTime { get; set; }
        public virtual ICollection<AssessmentVerificationStatement> AssessmentVerificationStatement { get; set; }
        public virtual ICollection<CertificateLost> CertificateLost { get; set; }
        public virtual ICollection<CertificateStolen> CertificateStolen { get; set; }
        public virtual ICollection<CertificateWithdrawn> CertificateWithdrawn { get; set; }
        public virtual ICollection<CompanyDocument> CompanyDocument { get; set; }
        public virtual ICollection<CompanyRole> CompanyRole { get; set; }
        public virtual ICollection<CompetencyCriteria> CompetencyCriteria { get; set; }
        public virtual ICollection<CompetencyCycle> CompetencyCycle { get; set; }
        public virtual ICollection<CompetencyCycleAssessmentWindow> CompetencyCycleAssessmentWindow { get; set; }
        public virtual ICollection<CompetencyCycleCriteria> CompetencyCycleCriteria { get; set; }
        public virtual ICollection<CompetencyElement> CompetencyElement { get; set; }
        public virtual ICollection<CompetencyElementLearningResource> CompetencyElementLearningResource { get; set; }
        public virtual ICollection<CompetencyUnit> CompetencyUnit { get; set; }
        public virtual ICollection<ComplementaryCertificate> ComplementaryCertificate { get; set; }
        public virtual ICollection<ComplementaryCertificateCompanyDetail> ComplementaryCertificateCompanyDetail { get; set; }
        public virtual ICollection<ComplementaryCertificateUserDetail> ComplementaryCertificateUserDetail { get; set; }
        public virtual ICollection<ComplementaryCertificateUserDetailDrivingCategory> ComplementaryCertificateUserDetailDrivingCategory { get; set; }
        public virtual ICollection<ComplementaryCertificateUserDetailLanguageSkill> ComplementaryCertificateUserDetailLanguageSkill { get; set; }
        public virtual ICollection<Department> Department { get; set; }
        public virtual ICollection<DriverIrregularity> DriverIrregularity { get; set; }
        public virtual ICollection<DrugsAlcoholAndDiabetesAssessment> DrugsAlcoholAndDiabetesAssessment { get; set; }
        public virtual ICollection<EtdlApplication> EtdlApplication { get; set; }
        public virtual ICollection<EtdlApplicationDetail> EtdlApplicationDetail { get; set; }
        public virtual ICollection<EtdlCompanyDetail> EtdlCompanyDetail { get; set; }
        public virtual ICollection<EtdlUpdate> EtdlUpdate { get; set; }
        public virtual ICollection<EtdlUserDetail> EtdlUserDetail { get; set; }
        public virtual ICollection<EtdlUserMedicalDetail> EtdlUserMedicalDetail { get; set; }
        public virtual ICollection<HearingAssessment> HearingAssessment { get; set; }
        public virtual ICollection<Incident> Incident { get; set; }
        public virtual ICollection<IncidentEvent> IncidentEvent { get; set; }
        public virtual ICollection<IncidentReport> IncidentReport { get; set; }
        public virtual ICollection<InfrastructureAuthorisedToOperate> InfrastructureAuthorisedToOperate { get; set; }
        public virtual ICollection<IssuingOrganisation> IssuingOrganisationNavigation { get; set; }
        public virtual ICollection<LearningResource> LearningResource { get; set; }
        public virtual ICollection<LearningResourceFile> LearningResourceFile { get; set; }
        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<MedicalAssessmentDetail> MedicalAssessmentDetail { get; set; }
        public virtual ICollection<MedicalPractitioner> MedicalPractitioner { get; set; }
        public virtual ICollection<RollingStockAuthorisedToOperate> RollingStockAuthorisedToOperate { get; set; }
        public virtual ICollection<Route> Route { get; set; }
        public virtual ICollection<SafetyBrief> SafetyBrief { get; set; }
        public virtual ICollection<Skill> Skill { get; set; }
        public virtual ICollection<SupportLevel> SupportLevel { get; set; }
        public virtual ICollection<SupportPlan> SupportPlan { get; set; }
        public virtual ICollection<SupportPlanAimObjective> SupportPlanAimObjective { get; set; }
        public virtual ICollection<SupportPlanCurrentSupportPlanType> SupportPlanCurrentSupportPlanType { get; set; }
        public virtual ICollection<SupportPlanDocument> SupportPlanDocument { get; set; }
        public virtual ICollection<SupportPlanInteraction> SupportPlanInteraction { get; set; }
        public virtual ICollection<SupportPlanManagerJustification> SupportPlanManagerJustification { get; set; }
        public virtual ICollection<SupportPlanNote> SupportPlanNote { get; set; }
        public virtual ICollection<SupportPlanSignature> SupportPlanSignature { get; set; }
        public virtual ICollection<SupportPlanVerificationStatement> SupportPlanVerificationStatement { get; set; }
        public virtual ICollection<Team> Team { get; set; }
        public virtual ICollection<TeamOwner> TeamOwner { get; set; }
        public virtual ICollection<Traction> Traction { get; set; }
        public virtual ICollection<Training> Training { get; set; }
        public virtual ICollection<TrainingDocument> TrainingDocument { get; set; }
        public virtual ICollection<TrainingTemplate> TrainingTemplate { get; set; }
        public virtual ICollection<TrainingTemplateDocument> TrainingTemplateDocument { get; set; }
        public virtual ICollection<TrainingTemplateSkill> TrainingTemplateSkill { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<UserApiSyncTime> UserApiSyncTime { get; set; }
        public virtual ICollection<UserAuthorityToWorkStatus> UserAuthorityToWorkStatus { get; set; }
        public virtual ICollection<UserCertificateFile> UserCertificateFile { get; set; }
        public virtual ICollection<UserCompanyRole> UserCompanyRole { get; set; }
        public virtual ICollection<UserCompanyRoleArchive> UserCompanyRoleArchive { get; set; }
        public virtual ICollection<UserDepartmentAccess> UserDepartmentAccess { get; set; }
        public virtual ICollection<UserEndedCompetencyCycle> UserEndedCompetencyCycle { get; set; }
        public virtual ICollection<UserFileNote> UserFileNote { get; set; }
        public virtual ICollection<UserFileNoteDocument> UserFileNoteDocument { get; set; }
        public virtual ICollection<UserMedicalDetail> UserMedicalDetail { get; set; }
        public virtual ICollection<UserMedicalDetailFile> UserMedicalDetailFile { get; set; }
        public virtual ICollection<UserMedicalDetailMedicalStatus> UserMedicalDetailMedicalStatus { get; set; }
        public virtual ICollection<UserMedicalTestRequest> UserMedicalTestRequest { get; set; }
        public virtual ICollection<UserMedicationInformation> UserMedicationInformation { get; set; }
        public virtual ICollection<UserPreference> UserPreference { get; set; }
        public virtual ICollection<UserProfile> UserProfile { get; set; }
        public virtual ICollection<UserRecruitmentDetail> UserRecruitmentDetail { get; set; }
        public virtual ICollection<UserRecruitmentDetailFile> UserRecruitmentDetailFile { get; set; }
        public virtual ICollection<UserSafetyBriefing> UserSafetyBriefing { get; set; }
        public virtual ICollection<UserSafetyBriefingDocument> UserSafetyBriefingDocument { get; set; }
        public virtual ICollection<UserSafetyCriticalStatus> UserSafetyCriticalStatus { get; set; }
        public virtual ICollection<UserSkill> UserSkill { get; set; }
        public virtual ICollection<UserSupportLevel> UserSupportLevel { get; set; }
        public virtual ICollection<UserTeam> UserTeam { get; set; }
        public virtual ICollection<UserTimeWithManager> UserTimeWithManager { get; set; }
        public virtual ICollection<UserTimeWithManagerDocument> UserTimeWithManagerDocument { get; set; }
        public virtual ICollection<VerificationStatement> VerificationStatement { get; set; }
        public virtual ICollection<VisionAssessment> VisionAssessment { get; set; }
        public virtual ICollection<YouRole> YouRole { get; set; }
    }
}
