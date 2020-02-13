using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class User
    {
        public User()
        {
            AssessmentArchivedByUser = new HashSet<Assessment>();
            AssessmentAssessor = new HashSet<Assessment>();
            AssessmentCompletedByUser = new HashSet<Assessment>();
            AssessmentCreatedByUser = new HashSet<Assessment>();
            AssessmentCriteriaCard = new HashSet<AssessmentCriteriaCard>();
            AssessmentNote = new HashSet<AssessmentNote>();
            AssessmentUserAssessing = new HashSet<Assessment>();
            AssessmentVerifiedByUser = new HashSet<Assessment>();
            CompetencyCriteria = new HashSet<CompetencyCriteria>();
            CompetencyCycle = new HashSet<CompetencyCycle>();
            CompetencyElement = new HashSet<CompetencyElement>();
            CompetencyUnit = new HashSet<CompetencyUnit>();
            ComplementaryCertificateArchivedByUser = new HashSet<ComplementaryCertificate>();
            ComplementaryCertificateDateInfo = new HashSet<ComplementaryCertificateDateInfo>();
            ComplementaryCertificateSubmittedByUserIdDeprecatedNavigation = new HashSet<ComplementaryCertificate>();
            DriverIrregularityAssignment = new HashSet<DriverIrregularityAssignment>();
            EtdlApplicationArchivedByUser = new HashSet<EtdlApplication>();
            EtdlApplicationSubmittedByUser = new HashSet<EtdlApplication>();
            EtdlUserDetail = new HashSet<EtdlUserDetail>();
            ForceUpdateCompetencyCycleQueue = new HashSet<ForceUpdateCompetencyCycleQueue>();
            IncidentArchivedByUser = new HashSet<Incident>();
            IncidentCreatedByUser = new HashSet<Incident>();
            IncidentReportCompletedByUser = new HashSet<Incident>();
            IncidentUser = new HashSet<Incident>();
            InfrastructureAuthorisedToOperateSigningHistoryModifiedByUser = new HashSet<InfrastructureAuthorisedToOperateSigningHistory>();
            InfrastructureAuthorisedToOperateSigningHistorySignedByUser = new HashSet<InfrastructureAuthorisedToOperateSigningHistory>();
            LearningResource = new HashSet<LearningResource>();
            LearningResourceCompanyRole = new HashSet<LearningResourceCompanyRole>();
            LearningResourceFile = new HashSet<LearningResourceFile>();
            Notification = new HashSet<Notification>();
            NotificationQueue = new HashSet<NotificationQueue>();
            NotificationUser = new HashSet<NotificationUser>();
            OneTimeToken = new HashSet<OneTimeToken>();
            RollingStockAuthorisedToOperateSigningHistoryModifiedByUser = new HashSet<RollingStockAuthorisedToOperateSigningHistory>();
            RollingStockAuthorisedToOperateSigningHistorySignedByUser = new HashSet<RollingStockAuthorisedToOperateSigningHistory>();
            Skill = new HashSet<Skill>();
            SupportPlanApprovalUser = new HashSet<SupportPlanApprovalUser>();
            SupportPlanArchivedByUser = new HashSet<SupportPlan>();
            SupportPlanCreatedByUser = new HashSet<SupportPlan>();
            SupportPlanIncident = new HashSet<SupportPlanIncident>();
            SupportPlanInteraction = new HashSet<SupportPlanInteraction>();
            SupportPlanManagerJustification = new HashSet<SupportPlanManagerJustification>();
            SupportPlanNote = new HashSet<SupportPlanNote>();
            SupportPlanUser = new HashSet<SupportPlan>();
            SupportPlanVerifiedByUser = new HashSet<SupportPlan>();
            TeamOwner = new HashSet<TeamOwner>();
            TrainingArchivedByUser = new HashSet<Training>();
            TrainingDocument = new HashSet<TrainingDocument>();
            TrainingModifiedByUser = new HashSet<Training>();
            TrainingTemplateArchivedByUser = new HashSet<TrainingTemplate>();
            TrainingTemplateDocument = new HashSet<TrainingTemplateDocument>();
            TrainingTemplateModifiedByUser = new HashSet<TrainingTemplate>();
            TrainingTemplateSkill = new HashSet<TrainingTemplateSkill>();
            TrainingUser = new HashSet<Training>();
            UserApiSyncTime = new HashSet<UserApiSyncTime>();
            UserAuthorityToWorkStatusUpdatedByUser = new HashSet<UserAuthorityToWorkStatus>();
            UserAuthorityToWorkStatusUser = new HashSet<UserAuthorityToWorkStatus>();
            UserCertificateFile = new HashSet<UserCertificateFile>();
            UserCompanyRole = new HashSet<UserCompanyRole>();
            UserCompanyRoleArchive = new HashSet<UserCompanyRoleArchive>();
            UserCompanyRoleDateOfProductiveDuty = new HashSet<UserCompanyRoleDateOfProductiveDuty>();
            UserCompanyRoleRecertificationDate = new HashSet<UserCompanyRoleRecertificationDate>();
            UserDepartmentAccess = new HashSet<UserDepartmentAccess>();
            UserEndedCompetencyCycleEndedByUser = new HashSet<UserEndedCompetencyCycle>();
            UserEndedCompetencyCycleUser = new HashSet<UserEndedCompetencyCycle>();
            UserFileAccess = new HashSet<UserFileAccess>();
            UserFileNoteFollowedUpByUser = new HashSet<UserFileNote>();
            UserFileNoteUser = new HashSet<UserFileNote>();
            UserMedicalDetailArchivedByUser = new HashSet<UserMedicalDetail>();
            UserMedicalDetailCreatedByUser = new HashSet<UserMedicalDetail>();
            UserMedicalDetailFile = new HashSet<UserMedicalDetailFile>();
            UserMedicalDetailMedicalStatusUpdatedByUser = new HashSet<UserMedicalDetailMedicalStatus>();
            UserMedicalDetailMedicalStatusUser = new HashSet<UserMedicalDetailMedicalStatus>();
            UserMedicalDetailUser = new HashSet<UserMedicalDetail>();
            UserMedicalTestRequestCreatedByUser = new HashSet<UserMedicalTestRequest>();
            UserMedicalTestRequestUser = new HashSet<UserMedicalTestRequest>();
            UserMedicationInformationArchivedByUser = new HashSet<UserMedicationInformation>();
            UserMedicationInformationUser = new HashSet<UserMedicationInformation>();
            UserPasswordReset = new HashSet<UserPasswordReset>();
            UserPrivateTeamMember = new HashSet<UserPrivateTeamMember>();
            UserProfileAssessor = new HashSet<UserProfile>();
            UserProfileLineManager = new HashSet<UserProfile>();
            UserRecruitmentDetailFile = new HashSet<UserRecruitmentDetailFile>();
            UserRecruitmentDetailModifiedByUser = new HashSet<UserRecruitmentDetail>();
            UserRecruitmentDetailResultAddedByUser = new HashSet<UserRecruitmentDetail>();
            UserRecruitmentDetailUser = new HashSet<UserRecruitmentDetail>();
            UserSafetyBriefing = new HashSet<UserSafetyBriefing>();
            UserSafetyCriticalStatusUpdatedByUser = new HashSet<UserSafetyCriticalStatus>();
            UserSafetyCriticalStatusUser = new HashSet<UserSafetyCriticalStatus>();
            UserSkillModifiedByUser = new HashSet<UserSkill>();
            UserSkillSigningHistoryModifiedByUser = new HashSet<UserSkillSigningHistory>();
            UserSkillSigningHistorySignedByUser = new HashSet<UserSkillSigningHistory>();
            UserSkillUser = new HashSet<UserSkill>();
            UserSupportLevelUpdatedByUser = new HashSet<UserSupportLevel>();
            UserSupportLevelUser = new HashSet<UserSupportLevel>();
            UserTeam = new HashSet<UserTeam>();
            UserTimeWithManagerCompletedByUser = new HashSet<UserTimeWithManager>();
            UserTimeWithManagerManagerUser = new HashSet<UserTimeWithManager>();
            UserTimeWithManagerUser = new HashSet<UserTimeWithManager>();
        }

        public Guid UserId { get; set; }
        public Guid? CompanyId { get; set; }
        public Guid SystemRoleId { get; set; }
        public string Username { get; set; }
        public string LoweredUsername { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime LastActivityDate { get; set; }
        public string Password { get; set; }
        public int PasswordFormat { get; set; }
        public string PasswordSalt { get; set; }
        public bool LockedOut { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public int FailedPasswordAttemptCount { get; set; }
        public DateTime LastPasswordChangeDate { get; set; }
        public DateTime LastLockoutDate { get; set; }
        public bool? IsEnabled { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string MobileNumber { get; set; }
        public DateTime? LastLoginDateMobile { get; set; }
        public bool ShowWhatsNew { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid? RosteringDepartmentId { get; set; }
        public DateTime? DateImported { get; set; }
        public Guid? YouRoleId { get; set; }
        public string TwoFasecret { get; set; }
        public bool TwoFaenabled { get; set; }
        public string TwoFarecoveryToken { get; set; }
        public string TwoFarecoveryTokenSalt { get; set; }
        public DateTime? YouWelcomeEmailRequestDateTime { get; set; }
        public DateTime? TimeManagementEmailRequestDateTime { get; set; }
        public string SsopasswordHash { get; set; }

        public virtual Company Company { get; set; }
        public virtual Department Department { get; set; }
        public virtual Department RosteringDepartment { get; set; }
        public virtual SystemRole SystemRole { get; set; }
        public virtual UserProfile UserNavigation { get; set; }
        public virtual YouRole YouRole { get; set; }
        public virtual AppUserInformation AppUserInformation { get; set; }
        public virtual PrivateTeam PrivateTeam { get; set; }
        public virtual UserPreference UserPreference { get; set; }
        public virtual UserToken UserToken { get; set; }
        public virtual UserTrainingStatistic UserTrainingStatistic { get; set; }
        public virtual ICollection<Assessment> AssessmentArchivedByUser { get; set; }
        public virtual ICollection<Assessment> AssessmentAssessor { get; set; }
        public virtual ICollection<Assessment> AssessmentCompletedByUser { get; set; }
        public virtual ICollection<Assessment> AssessmentCreatedByUser { get; set; }
        public virtual ICollection<AssessmentCriteriaCard> AssessmentCriteriaCard { get; set; }
        public virtual ICollection<AssessmentNote> AssessmentNote { get; set; }
        public virtual ICollection<Assessment> AssessmentUserAssessing { get; set; }
        public virtual ICollection<Assessment> AssessmentVerifiedByUser { get; set; }
        public virtual ICollection<CompetencyCriteria> CompetencyCriteria { get; set; }
        public virtual ICollection<CompetencyCycle> CompetencyCycle { get; set; }
        public virtual ICollection<CompetencyElement> CompetencyElement { get; set; }
        public virtual ICollection<CompetencyUnit> CompetencyUnit { get; set; }
        public virtual ICollection<ComplementaryCertificate> ComplementaryCertificateArchivedByUser { get; set; }
        public virtual ICollection<ComplementaryCertificateDateInfo> ComplementaryCertificateDateInfo { get; set; }
        public virtual ICollection<ComplementaryCertificate> ComplementaryCertificateSubmittedByUserIdDeprecatedNavigation { get; set; }
        public virtual ICollection<DriverIrregularityAssignment> DriverIrregularityAssignment { get; set; }
        public virtual ICollection<EtdlApplication> EtdlApplicationArchivedByUser { get; set; }
        public virtual ICollection<EtdlApplication> EtdlApplicationSubmittedByUser { get; set; }
        public virtual ICollection<EtdlUserDetail> EtdlUserDetail { get; set; }
        public virtual ICollection<ForceUpdateCompetencyCycleQueue> ForceUpdateCompetencyCycleQueue { get; set; }
        public virtual ICollection<Incident> IncidentArchivedByUser { get; set; }
        public virtual ICollection<Incident> IncidentCreatedByUser { get; set; }
        public virtual ICollection<Incident> IncidentReportCompletedByUser { get; set; }
        public virtual ICollection<Incident> IncidentUser { get; set; }
        public virtual ICollection<InfrastructureAuthorisedToOperateSigningHistory> InfrastructureAuthorisedToOperateSigningHistoryModifiedByUser { get; set; }
        public virtual ICollection<InfrastructureAuthorisedToOperateSigningHistory> InfrastructureAuthorisedToOperateSigningHistorySignedByUser { get; set; }
        public virtual ICollection<LearningResource> LearningResource { get; set; }
        public virtual ICollection<LearningResourceCompanyRole> LearningResourceCompanyRole { get; set; }
        public virtual ICollection<LearningResourceFile> LearningResourceFile { get; set; }
        public virtual ICollection<Notification> Notification { get; set; }
        public virtual ICollection<NotificationQueue> NotificationQueue { get; set; }
        public virtual ICollection<NotificationUser> NotificationUser { get; set; }
        public virtual ICollection<OneTimeToken> OneTimeToken { get; set; }
        public virtual ICollection<RollingStockAuthorisedToOperateSigningHistory> RollingStockAuthorisedToOperateSigningHistoryModifiedByUser { get; set; }
        public virtual ICollection<RollingStockAuthorisedToOperateSigningHistory> RollingStockAuthorisedToOperateSigningHistorySignedByUser { get; set; }
        public virtual ICollection<Skill> Skill { get; set; }
        public virtual ICollection<SupportPlanApprovalUser> SupportPlanApprovalUser { get; set; }
        public virtual ICollection<SupportPlan> SupportPlanArchivedByUser { get; set; }
        public virtual ICollection<SupportPlan> SupportPlanCreatedByUser { get; set; }
        public virtual ICollection<SupportPlanIncident> SupportPlanIncident { get; set; }
        public virtual ICollection<SupportPlanInteraction> SupportPlanInteraction { get; set; }
        public virtual ICollection<SupportPlanManagerJustification> SupportPlanManagerJustification { get; set; }
        public virtual ICollection<SupportPlanNote> SupportPlanNote { get; set; }
        public virtual ICollection<SupportPlan> SupportPlanUser { get; set; }
        public virtual ICollection<SupportPlan> SupportPlanVerifiedByUser { get; set; }
        public virtual ICollection<TeamOwner> TeamOwner { get; set; }
        public virtual ICollection<Training> TrainingArchivedByUser { get; set; }
        public virtual ICollection<TrainingDocument> TrainingDocument { get; set; }
        public virtual ICollection<Training> TrainingModifiedByUser { get; set; }
        public virtual ICollection<TrainingTemplate> TrainingTemplateArchivedByUser { get; set; }
        public virtual ICollection<TrainingTemplateDocument> TrainingTemplateDocument { get; set; }
        public virtual ICollection<TrainingTemplate> TrainingTemplateModifiedByUser { get; set; }
        public virtual ICollection<TrainingTemplateSkill> TrainingTemplateSkill { get; set; }
        public virtual ICollection<Training> TrainingUser { get; set; }
        public virtual ICollection<UserApiSyncTime> UserApiSyncTime { get; set; }
        public virtual ICollection<UserAuthorityToWorkStatus> UserAuthorityToWorkStatusUpdatedByUser { get; set; }
        public virtual ICollection<UserAuthorityToWorkStatus> UserAuthorityToWorkStatusUser { get; set; }
        public virtual ICollection<UserCertificateFile> UserCertificateFile { get; set; }
        public virtual ICollection<UserCompanyRole> UserCompanyRole { get; set; }
        public virtual ICollection<UserCompanyRoleArchive> UserCompanyRoleArchive { get; set; }
        public virtual ICollection<UserCompanyRoleDateOfProductiveDuty> UserCompanyRoleDateOfProductiveDuty { get; set; }
        public virtual ICollection<UserCompanyRoleRecertificationDate> UserCompanyRoleRecertificationDate { get; set; }
        public virtual ICollection<UserDepartmentAccess> UserDepartmentAccess { get; set; }
        public virtual ICollection<UserEndedCompetencyCycle> UserEndedCompetencyCycleEndedByUser { get; set; }
        public virtual ICollection<UserEndedCompetencyCycle> UserEndedCompetencyCycleUser { get; set; }
        public virtual ICollection<UserFileAccess> UserFileAccess { get; set; }
        public virtual ICollection<UserFileNote> UserFileNoteFollowedUpByUser { get; set; }
        public virtual ICollection<UserFileNote> UserFileNoteUser { get; set; }
        public virtual ICollection<UserMedicalDetail> UserMedicalDetailArchivedByUser { get; set; }
        public virtual ICollection<UserMedicalDetail> UserMedicalDetailCreatedByUser { get; set; }
        public virtual ICollection<UserMedicalDetailFile> UserMedicalDetailFile { get; set; }
        public virtual ICollection<UserMedicalDetailMedicalStatus> UserMedicalDetailMedicalStatusUpdatedByUser { get; set; }
        public virtual ICollection<UserMedicalDetailMedicalStatus> UserMedicalDetailMedicalStatusUser { get; set; }
        public virtual ICollection<UserMedicalDetail> UserMedicalDetailUser { get; set; }
        public virtual ICollection<UserMedicalTestRequest> UserMedicalTestRequestCreatedByUser { get; set; }
        public virtual ICollection<UserMedicalTestRequest> UserMedicalTestRequestUser { get; set; }
        public virtual ICollection<UserMedicationInformation> UserMedicationInformationArchivedByUser { get; set; }
        public virtual ICollection<UserMedicationInformation> UserMedicationInformationUser { get; set; }
        public virtual ICollection<UserPasswordReset> UserPasswordReset { get; set; }
        public virtual ICollection<UserPrivateTeamMember> UserPrivateTeamMember { get; set; }
        public virtual ICollection<UserProfile> UserProfileAssessor { get; set; }
        public virtual ICollection<UserProfile> UserProfileLineManager { get; set; }
        public virtual ICollection<UserRecruitmentDetailFile> UserRecruitmentDetailFile { get; set; }
        public virtual ICollection<UserRecruitmentDetail> UserRecruitmentDetailModifiedByUser { get; set; }
        public virtual ICollection<UserRecruitmentDetail> UserRecruitmentDetailResultAddedByUser { get; set; }
        public virtual ICollection<UserRecruitmentDetail> UserRecruitmentDetailUser { get; set; }
        public virtual ICollection<UserSafetyBriefing> UserSafetyBriefing { get; set; }
        public virtual ICollection<UserSafetyCriticalStatus> UserSafetyCriticalStatusUpdatedByUser { get; set; }
        public virtual ICollection<UserSafetyCriticalStatus> UserSafetyCriticalStatusUser { get; set; }
        public virtual ICollection<UserSkill> UserSkillModifiedByUser { get; set; }
        public virtual ICollection<UserSkillSigningHistory> UserSkillSigningHistoryModifiedByUser { get; set; }
        public virtual ICollection<UserSkillSigningHistory> UserSkillSigningHistorySignedByUser { get; set; }
        public virtual ICollection<UserSkill> UserSkillUser { get; set; }
        public virtual ICollection<UserSupportLevel> UserSupportLevelUpdatedByUser { get; set; }
        public virtual ICollection<UserSupportLevel> UserSupportLevelUser { get; set; }
        public virtual ICollection<UserTeam> UserTeam { get; set; }
        public virtual ICollection<UserTimeWithManager> UserTimeWithManagerCompletedByUser { get; set; }
        public virtual ICollection<UserTimeWithManager> UserTimeWithManagerManagerUser { get; set; }
        public virtual ICollection<UserTimeWithManager> UserTimeWithManagerUser { get; set; }
    }
}
