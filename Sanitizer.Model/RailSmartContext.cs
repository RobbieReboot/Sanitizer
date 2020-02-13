using Microsoft.EntityFrameworkCore;

namespace Sanitizer.Model
{
    public partial class RailSmartContext : DbContext
    {
        public RailSmartContext()
        {
        }

        public RailSmartContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<ApiKey> ApiKey { get; set; }
        public virtual DbSet<AppUserInformation> AppUserInformation { get; set; }
        public virtual DbSet<ApplicationSetting> ApplicationSetting { get; set; }
        public virtual DbSet<AspstateTempApplications> AspstateTempApplications { get; set; }
        public virtual DbSet<AspstateTempSessions> AspstateTempSessions { get; set; }
        public virtual DbSet<Assessment> Assessment { get; set; }
        public virtual DbSet<AssessmentCompetency> AssessmentCompetency { get; set; }
        public virtual DbSet<AssessmentCompetencyCriteria> AssessmentCompetencyCriteria { get; set; }
        public virtual DbSet<AssessmentConditionCard> AssessmentConditionCard { get; set; }
        public virtual DbSet<AssessmentConditionCardRoute> AssessmentConditionCardRoute { get; set; }
        public virtual DbSet<AssessmentCriteriaCard> AssessmentCriteriaCard { get; set; }
        public virtual DbSet<AssessmentCriteriaCardAttachment> AssessmentCriteriaCardAttachment { get; set; }
        public virtual DbSet<AssessmentCriteriaCardAttachmentType> AssessmentCriteriaCardAttachmentType { get; set; }
        public virtual DbSet<AssessmentCriteriaCardEvidence> AssessmentCriteriaCardEvidence { get; set; }
        public virtual DbSet<AssessmentCriteriaCardRating> AssessmentCriteriaCardRating { get; set; }
        public virtual DbSet<AssessmentDeadline> AssessmentDeadline { get; set; }
        public virtual DbSet<AssessmentDocument> AssessmentDocument { get; set; }
        public virtual DbSet<AssessmentNote> AssessmentNote { get; set; }
        public virtual DbSet<AssessmentOtdrDetail> AssessmentOtdrDetail { get; set; }
        public virtual DbSet<AssessmentPlannedAssessmentTask> AssessmentPlannedAssessmentTask { get; set; }
        public virtual DbSet<AssessmentSignature> AssessmentSignature { get; set; }
        public virtual DbSet<AssessmentTask> AssessmentTask { get; set; }
        public virtual DbSet<AssessmentTaskCompanyRole> AssessmentTaskCompanyRole { get; set; }
        public virtual DbSet<AssessmentTaskReference> AssessmentTaskReference { get; set; }
        public virtual DbSet<AssessmentTaskTime> AssessmentTaskTime { get; set; }
        public virtual DbSet<AssessmentType> AssessmentType { get; set; }
        public virtual DbSet<AssessmentVerificationStatement> AssessmentVerificationStatement { get; set; }
        public virtual DbSet<AssessorVerificationResponse> AssessorVerificationResponse { get; set; }
        public virtual DbSet<CertificateApplicationStatus> CertificateApplicationStatus { get; set; }
        public virtual DbSet<CertificateLost> CertificateLost { get; set; }
        public virtual DbSet<CertificateStolen> CertificateStolen { get; set; }
        public virtual DbSet<CertificateType> CertificateType { get; set; }
        public virtual DbSet<CertificateWithdrawn> CertificateWithdrawn { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyDocument> CompanyDocument { get; set; }
        public virtual DbSet<CompanyDocumentType> CompanyDocumentType { get; set; }
        public virtual DbSet<CompanyFeature> CompanyFeature { get; set; }
        public virtual DbSet<CompanyRole> CompanyRole { get; set; }
        public virtual DbSet<CompetencyCriteria> CompetencyCriteria { get; set; }
        public virtual DbSet<CompetencyCriteriaRiskLevel> CompetencyCriteriaRiskLevel { get; set; }
        public virtual DbSet<CompetencyCriteriaRiskLevelReference> CompetencyCriteriaRiskLevelReference { get; set; }
        public virtual DbSet<CompetencyCycle> CompetencyCycle { get; set; }
        public virtual DbSet<CompetencyCycleAssessmentWindow> CompetencyCycleAssessmentWindow { get; set; }
        public virtual DbSet<CompetencyCycleCriteria> CompetencyCycleCriteria { get; set; }
        public virtual DbSet<CompetencyElement> CompetencyElement { get; set; }
        public virtual DbSet<CompetencyElementLearningResource> CompetencyElementLearningResource { get; set; }
        public virtual DbSet<CompetencyUnit> CompetencyUnit { get; set; }
        public virtual DbSet<ComplementaryCertificate> ComplementaryCertificate { get; set; }
        public virtual DbSet<ComplementaryCertificateCompanyDetail> ComplementaryCertificateCompanyDetail { get; set; }
        public virtual DbSet<ComplementaryCertificateDateInfo> ComplementaryCertificateDateInfo { get; set; }
        public virtual DbSet<ComplementaryCertificateFile> ComplementaryCertificateFile { get; set; }
        public virtual DbSet<ComplementaryCertificateFileType> ComplementaryCertificateFileType { get; set; }
        public virtual DbSet<ComplementaryCertificateUserDetail> ComplementaryCertificateUserDetail { get; set; }
        public virtual DbSet<ComplementaryCertificateUserDetailDrivingCategory> ComplementaryCertificateUserDetailDrivingCategory { get; set; }
        public virtual DbSet<ComplementaryCertificateUserDetailLanguageSkill> ComplementaryCertificateUserDetailLanguageSkill { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<DatabaseMigration> DatabaseMigration { get; set; }
        public virtual DbSet<DatabaseVersion> DatabaseVersion { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DriverIrregularity> DriverIrregularity { get; set; }
        public virtual DbSet<DriverIrregularityAssignment> DriverIrregularityAssignment { get; set; }
        public virtual DbSet<DrivingCategory> DrivingCategory { get; set; }
        public virtual DbSet<DrugsAlcoholAndDiabetesAssessment> DrugsAlcoholAndDiabetesAssessment { get; set; }
        public virtual DbSet<DurationUnit> DurationUnit { get; set; }
        public virtual DbSet<DurationUnitDayMonthWeekReference> DurationUnitDayMonthWeekReference { get; set; }
        public virtual DbSet<EmployeeAuthorityToWorkStatus> EmployeeAuthorityToWorkStatus { get; set; }
        public virtual DbSet<EmployeeSafetyCriticalStatus> EmployeeSafetyCriticalStatus { get; set; }
        public virtual DbSet<EtdlApplication> EtdlApplication { get; set; }
        public virtual DbSet<EtdlApplicationDetail> EtdlApplicationDetail { get; set; }
        public virtual DbSet<EtdlApplicationFile> EtdlApplicationFile { get; set; }
        public virtual DbSet<EtdlApplicationFileType> EtdlApplicationFileType { get; set; }
        public virtual DbSet<EtdlApplicationGeneralCompetencyTrainingPassed> EtdlApplicationGeneralCompetencyTrainingPassed { get; set; }
        public virtual DbSet<EtdlApplicationMedicalExaminationPassed> EtdlApplicationMedicalExaminationPassed { get; set; }
        public virtual DbSet<EtdlApplicationPsychologicalAssessmentPassed> EtdlApplicationPsychologicalAssessmentPassed { get; set; }
        public virtual DbSet<EtdlApplicationStatus> EtdlApplicationStatus { get; set; }
        public virtual DbSet<EtdlApplicationType> EtdlApplicationType { get; set; }
        public virtual DbSet<EtdlCertificatePostalAddress> EtdlCertificatePostalAddress { get; set; }
        public virtual DbSet<EtdlCompanyDetail> EtdlCompanyDetail { get; set; }
        public virtual DbSet<EtdlUpdate> EtdlUpdate { get; set; }
        public virtual DbSet<EtdlUpdateType> EtdlUpdateType { get; set; }
        public virtual DbSet<EtdlUserDetail> EtdlUserDetail { get; set; }
        public virtual DbSet<EtdlUserMedicalDetail> EtdlUserMedicalDetail { get; set; }
        public virtual DbSet<FileUploadQueueItem> FileUploadQueueItem { get; set; }
        public virtual DbSet<ForceUpdateCompetencyCycleQueue> ForceUpdateCompetencyCycleQueue { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<HearingAssessment> HearingAssessment { get; set; }
        public virtual DbSet<Incident> Incident { get; set; }
        public virtual DbSet<IncidentEvent> IncidentEvent { get; set; }
        public virtual DbSet<IncidentReport> IncidentReport { get; set; }
        public virtual DbSet<IncidentResponsibilityLevel> IncidentResponsibilityLevel { get; set; }
        public virtual DbSet<IncidentType> IncidentType { get; set; }
        public virtual DbSet<InfrastructureAuthorisedToOperate> InfrastructureAuthorisedToOperate { get; set; }
        public virtual DbSet<InfrastructureAuthorisedToOperateSigningHistory> InfrastructureAuthorisedToOperateSigningHistory { get; set; }
        public virtual DbSet<IssuingOrganisation> IssuingOrganisation { get; set; }
        public virtual DbSet<LearningResource> LearningResource { get; set; }
        public virtual DbSet<LearningResourceCompanyRole> LearningResourceCompanyRole { get; set; }
        public virtual DbSet<LearningResourceFile> LearningResourceFile { get; set; }
        public virtual DbSet<LearningResourceMediaType> LearningResourceMediaType { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<MedicalAssessmentDetail> MedicalAssessmentDetail { get; set; }
        public virtual DbSet<MedicalAssessmentResult> MedicalAssessmentResult { get; set; }
        public virtual DbSet<MedicalAssessmentType> MedicalAssessmentType { get; set; }
        public virtual DbSet<MedicalIndicator> MedicalIndicator { get; set; }
        public virtual DbSet<MedicalPractitioner> MedicalPractitioner { get; set; }
        public virtual DbSet<MedicalStatus> MedicalStatus { get; set; }
        public virtual DbSet<MedicalTimeframe> MedicalTimeframe { get; set; }
        public virtual DbSet<MedicationInformationCategory> MedicationInformationCategory { get; set; }
        public virtual DbSet<Messages0> Messages0 { get; set; }
        public virtual DbSet<Messages0Id> Messages0Id { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<NotificationCategory> NotificationCategory { get; set; }
        public virtual DbSet<NotificationCategoryReference> NotificationCategoryReference { get; set; }
        public virtual DbSet<NotificationGroup> NotificationGroup { get; set; }
        public virtual DbSet<NotificationGroupReference> NotificationGroupReference { get; set; }
        public virtual DbSet<NotificationQueue> NotificationQueue { get; set; }
        public virtual DbSet<NotificationSubCategory> NotificationSubCategory { get; set; }
        public virtual DbSet<NotificationSubCategoryReference> NotificationSubCategoryReference { get; set; }
        public virtual DbSet<NotificationType> NotificationType { get; set; }
        public virtual DbSet<NotificationUser> NotificationUser { get; set; }
        public virtual DbSet<OneTimeToken> OneTimeToken { get; set; }
        public virtual DbSet<OrrDoctorInformation> OrrDoctorInformation { get; set; }
        public virtual DbSet<PlannedInteractionType> PlannedInteractionType { get; set; }
        public virtual DbSet<Platform> Platform { get; set; }
        public virtual DbSet<PrivateTeam> PrivateTeam { get; set; }
        public virtual DbSet<RailheadCondition> RailheadCondition { get; set; }
        public virtual DbSet<RollingStockAuthorisedToOperate> RollingStockAuthorisedToOperate { get; set; }
        public virtual DbSet<RollingStockAuthorisedToOperateSigningHistory> RollingStockAuthorisedToOperateSigningHistory { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<SafetyBrief> SafetyBrief { get; set; }
        public virtual DbSet<SafetyBriefingType> SafetyBriefingType { get; set; }
        public virtual DbSet<SafetyOrganisation> SafetyOrganisation { get; set; }
        public virtual DbSet<Schema> Schema { get; set; }
        public virtual DbSet<SchemaVersions> SchemaVersions { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<SpeedRestrictionType> SpeedRestrictionType { get; set; }
        public virtual DbSet<SupportLevel> SupportLevel { get; set; }
        public virtual DbSet<SupportPlan> SupportPlan { get; set; }
        public virtual DbSet<SupportPlanAimObjective> SupportPlanAimObjective { get; set; }
        public virtual DbSet<SupportPlanApproval> SupportPlanApproval { get; set; }
        public virtual DbSet<SupportPlanApprovalType> SupportPlanApprovalType { get; set; }
        public virtual DbSet<SupportPlanApprovalUser> SupportPlanApprovalUser { get; set; }
        public virtual DbSet<SupportPlanCurrentSupportPlanType> SupportPlanCurrentSupportPlanType { get; set; }
        public virtual DbSet<SupportPlanDocument> SupportPlanDocument { get; set; }
        public virtual DbSet<SupportPlanIncident> SupportPlanIncident { get; set; }
        public virtual DbSet<SupportPlanInteraction> SupportPlanInteraction { get; set; }
        public virtual DbSet<SupportPlanManagerJustification> SupportPlanManagerJustification { get; set; }
        public virtual DbSet<SupportPlanManagerRecommendation> SupportPlanManagerRecommendation { get; set; }
        public virtual DbSet<SupportPlanNote> SupportPlanNote { get; set; }
        public virtual DbSet<SupportPlanOperationalIncidentType> SupportPlanOperationalIncidentType { get; set; }
        public virtual DbSet<SupportPlanSignature> SupportPlanSignature { get; set; }
        public virtual DbSet<SupportPlanType> SupportPlanType { get; set; }
        public virtual DbSet<SupportPlanVerificationStatement> SupportPlanVerificationStatement { get; set; }
        public virtual DbSet<SystemRole> SystemRole { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskStatus> TaskStatus { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<TeamOwner> TeamOwner { get; set; }
        public virtual DbSet<Traction> Traction { get; set; }
        public virtual DbSet<Training> Training { get; set; }
        public virtual DbSet<TrainingClassroom> TrainingClassroom { get; set; }
        public virtual DbSet<TrainingDocument> TrainingDocument { get; set; }
        public virtual DbSet<TrainingPracticalDriving> TrainingPracticalDriving { get; set; }
        public virtual DbSet<TrainingPracticalGeneral> TrainingPracticalGeneral { get; set; }
        public virtual DbSet<TrainingTemplate> TrainingTemplate { get; set; }
        public virtual DbSet<TrainingTemplateClassroom> TrainingTemplateClassroom { get; set; }
        public virtual DbSet<TrainingTemplateDocument> TrainingTemplateDocument { get; set; }
        public virtual DbSet<TrainingTemplatePracticalDriving> TrainingTemplatePracticalDriving { get; set; }
        public virtual DbSet<TrainingTemplatePracticalGeneral> TrainingTemplatePracticalGeneral { get; set; }
        public virtual DbSet<TrainingTemplateSkill> TrainingTemplateSkill { get; set; }
        public virtual DbSet<UnderfootCondition> UnderfootCondition { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserApiSyncTime> UserApiSyncTime { get; set; }
        public virtual DbSet<UserAuthorityToWorkStatus> UserAuthorityToWorkStatus { get; set; }
        public virtual DbSet<UserCertificateFile> UserCertificateFile { get; set; }
        public virtual DbSet<UserCompanyRole> UserCompanyRole { get; set; }
        public virtual DbSet<UserCompanyRoleArchive> UserCompanyRoleArchive { get; set; }
        public virtual DbSet<UserCompanyRoleDateOfProductiveDuty> UserCompanyRoleDateOfProductiveDuty { get; set; }
        public virtual DbSet<UserCompanyRoleRecertificationDate> UserCompanyRoleRecertificationDate { get; set; }
        public virtual DbSet<UserDepartmentAccess> UserDepartmentAccess { get; set; }
        public virtual DbSet<UserEndedCompetencyCycle> UserEndedCompetencyCycle { get; set; }
        public virtual DbSet<UserFileAccess> UserFileAccess { get; set; }
        public virtual DbSet<UserFileNote> UserFileNote { get; set; }
        public virtual DbSet<UserFileNoteDocument> UserFileNoteDocument { get; set; }
        public virtual DbSet<UserMedicalDetail> UserMedicalDetail { get; set; }
        public virtual DbSet<UserMedicalDetailFile> UserMedicalDetailFile { get; set; }
        public virtual DbSet<UserMedicalDetailMedicalStatus> UserMedicalDetailMedicalStatus { get; set; }
        public virtual DbSet<UserMedicalTestRequest> UserMedicalTestRequest { get; set; }
        public virtual DbSet<UserMedicalTestRequestType> UserMedicalTestRequestType { get; set; }
        public virtual DbSet<UserMedicationInformation> UserMedicationInformation { get; set; }
        public virtual DbSet<UserPasswordReset> UserPasswordReset { get; set; }
        public virtual DbSet<UserPreference> UserPreference { get; set; }
        public virtual DbSet<UserPrivateTeamMember> UserPrivateTeamMember { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<UserProfileFile> UserProfileFile { get; set; }
        public virtual DbSet<UserProfileFileType> UserProfileFileType { get; set; }
        public virtual DbSet<UserRecruitmentDetail> UserRecruitmentDetail { get; set; }
        public virtual DbSet<UserRecruitmentDetailFile> UserRecruitmentDetailFile { get; set; }
        public virtual DbSet<UserReference> UserReference { get; set; }
        public virtual DbSet<UserSafetyBriefing> UserSafetyBriefing { get; set; }
        public virtual DbSet<UserSafetyBriefingDocument> UserSafetyBriefingDocument { get; set; }
        public virtual DbSet<UserSafetyCriticalStatus> UserSafetyCriticalStatus { get; set; }
        public virtual DbSet<UserSkill> UserSkill { get; set; }
        public virtual DbSet<UserSkillSigningHistory> UserSkillSigningHistory { get; set; }
        public virtual DbSet<UserSupportLevel> UserSupportLevel { get; set; }
        public virtual DbSet<UserTeam> UserTeam { get; set; }
        public virtual DbSet<UserTimeWithManager> UserTimeWithManager { get; set; }
        public virtual DbSet<UserTimeWithManagerDocument> UserTimeWithManagerDocument { get; set; }
        public virtual DbSet<UserToken> UserToken { get; set; }
        public virtual DbSet<UserTrainingStatistic> UserTrainingStatistic { get; set; }
        public virtual DbSet<VerificationStatement> VerificationStatement { get; set; }
        public virtual DbSet<VerificationStatementCategory> VerificationStatementCategory { get; set; }
        public virtual DbSet<VerificationStatementRating> VerificationStatementRating { get; set; }
        public virtual DbSet<VerificationStatus> VerificationStatus { get; set; }
        public virtual DbSet<VersionInfo> VersionInfo { get; set; }
        public virtual DbSet<Visibility> Visibility { get; set; }
        public virtual DbSet<VisionAssessment> VisionAssessment { get; set; }
        public virtual DbSet<WeatherForecast> WeatherForecast { get; set; }
        public virtual DbSet<YesNo> YesNo { get; set; }
        public virtual DbSet<YesNoIntReference> YesNoIntReference { get; set; }
        public virtual DbSet<YesNoReference> YesNoReference { get; set; }
        public virtual DbSet<YouRole> YouRole { get; set; }
        public virtual DbSet<YouRoleReference> YouRoleReference { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\;Database=RailSmart-DEV-Local-EMT;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.AddressId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Company");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Address_Country");
            });

            modelBuilder.Entity<ApiKey>(entity =>
            {
                entity.Property(e => e.ApiKeyId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CallbackApiKey).HasMaxLength(255);

                entity.Property(e => e.CallbackApiUrl).HasMaxLength(255);

                entity.Property(e => e.CallbackApiVersion).HasMaxLength(255);

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Key).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<AppUserInformation>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PreviousSynchronisedTimestamp).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AppUserInformation)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppUserInformation_Company");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AppUserInformation)
                    .HasForeignKey<AppUserInformation>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppUserInformation_User");
            });

            modelBuilder.Entity<ApplicationSetting>(entity =>
            {
                entity.Property(e => e.ApplicationSettingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Key).IsRequired();

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<AspstateTempApplications>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("PK__ASPState__8E2CF7F92BAA4F42");

                entity.ToTable("ASPStateTempApplications");

                entity.HasIndex(e => e.AppName)
                    .HasName("Index_AppName");

                entity.Property(e => e.AppId).ValueGeneratedNever();

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasMaxLength(280)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AspstateTempSessions>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK__ASPState__C9F4929025F175EC");

                entity.ToTable("ASPStateTempSessions");

                entity.HasIndex(e => e.Expires)
                    .HasName("Index_Expires");

                entity.Property(e => e.SessionId).HasMaxLength(88);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Expires).HasColumnType("datetime");

                entity.Property(e => e.LockDate).HasColumnType("datetime");

                entity.Property(e => e.LockDateLocal).HasColumnType("datetime");

                entity.Property(e => e.SessionItemLong).HasColumnType("image");

                entity.Property(e => e.SessionItemShort).HasMaxLength(7000);
            });

            modelBuilder.Entity<Assessment>(entity =>
            {
                entity.HasIndex(e => new { e.AssessmentId, e.DateArchived, e.IsArchived, e.ModifiedDate, e.IsDeleted, e.IsPreview, e.UserAssessingId, e.AssessmentCompetencyId, e.RecordedEndDate, e.WindowEndDate, e.DateCreated })
                    .HasName("IX_Assessment_UserAssessingId_AssessmentCompetencyId_RecordedEndDate_WindowEndDate_DateCreated");

                entity.HasIndex(e => new { e.AssessorId, e.CompanyRoleId, e.CompetencyCycleId, e.AssessmentTypeId, e.VerifiedByUserId, e.VerificationStatusId, e.AssessorVerificationResponseId, e.Title, e.WindowStartDate, e.WindowEndDate, e.IsClassroomAssessment, e.Notes, e.AssessmentCompetencyId, e.AssessorFeedback, e.EmployeeConfirmedResult, e.RecordedStartDate, e.RecordedEndDate, e.OverriddenStartDate, e.OverriddenEndDate, e.CompletedByUserId, e.CompletedOnPlatformId, e.VerifierFinalFeedback, e.AssessorVerificationResponseNotes, e.CreatedByUserId, e.DateCreated, e.ArchivedByUserId, e.DateArchived, e.IsArchived, e.ModifiedDate, e.IsDeleted, e.IsAdHoc, e.CompanyId, e.UserAssessingId })
                    .HasName("IX_Assessment_CompanyId_UserAssessingId");

                entity.HasIndex(e => new { e.AssessmentId, e.CompanyId, e.UserAssessingId, e.AssessorId, e.CompanyRoleId, e.AssessmentTypeId, e.VerifiedByUserId, e.VerificationStatusId, e.AssessorVerificationResponseId, e.Title, e.WindowStartDate, e.WindowEndDate, e.IsClassroomAssessment, e.Notes, e.AssessmentCompetencyId, e.AssessorFeedback, e.EmployeeConfirmedResult, e.RecordedStartDate, e.RecordedEndDate, e.OverriddenStartDate, e.OverriddenEndDate, e.CompletedByUserId, e.CompletedOnPlatformId, e.VerifierFinalFeedback, e.AssessorVerificationResponseNotes, e.CreatedByUserId, e.DateCreated, e.ArchivedByUserId, e.DateArchived, e.IsArchived, e.ModifiedDate, e.IsAdHoc, e.AssessorConfirmedResult, e.CompetencyCycleId, e.IsDeleted, e.IsPreview })
                    .HasName("IX_Assessment_CompetencyCycleId_IsDeleted_IsPreview");

                entity.HasIndex(e => new { e.AssessmentId, e.CompanyId, e.UserAssessingId, e.AssessorId, e.CompanyRoleId, e.CompetencyCycleId, e.AssessmentTypeId, e.VerifiedByUserId, e.VerificationStatusId, e.AssessorVerificationResponseId, e.Title, e.WindowStartDate, e.WindowEndDate, e.IsClassroomAssessment, e.Notes, e.AssessorFeedback, e.EmployeeConfirmedResult, e.RecordedStartDate, e.OverriddenStartDate, e.OverriddenEndDate, e.CompletedByUserId, e.CompletedOnPlatformId, e.VerifierFinalFeedback, e.AssessorVerificationResponseNotes, e.CreatedByUserId, e.ArchivedByUserId, e.DateArchived, e.IsArchived, e.ModifiedDate, e.IsDeleted, e.IsAdHoc, e.AssessorConfirmedResult, e.AssessmentCompetencyId, e.RecordedEndDate, e.DateCreated, e.IsPreview })
                    .HasName("IX_Assessment_AssessmentCompetencyId_RecordedEndDate_DateCreated_IsPreview");

                entity.Property(e => e.AssessmentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AssessorFeedback).HasColumnType("nvarchar(max)");

                entity.Property(e => e.AssessorVerificationResponseNotes).HasColumnType("nvarchar(max)");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OverriddenEndDate).HasColumnType("datetime");

                entity.Property(e => e.OverriddenStartDate).HasColumnType("datetime");

                entity.Property(e => e.RecordedEndDate).HasColumnType("datetime");

                entity.Property(e => e.RecordedStartDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.VerifierFinalFeedback).HasColumnType("nvarchar(max)");

                entity.Property(e => e.WindowEndDate).HasColumnType("datetime");

                entity.Property(e => e.WindowStartDate).HasColumnType("datetime");

                entity.HasOne(d => d.ArchivedByUser)
                    .WithMany(p => p.AssessmentArchivedByUser)
                    .HasForeignKey(d => d.ArchivedByUserId)
                    .HasConstraintName("FK_Assessment_AssessmentArchivedByUser");

                entity.HasOne(d => d.AssessmentCompetency)
                    .WithMany(p => p.Assessment)
                    .HasForeignKey(d => d.AssessmentCompetencyId)
                    .HasConstraintName("FK_Assessment_AssessmentCompetency");

                entity.HasOne(d => d.AssessmentType)
                    .WithMany(p => p.Assessment)
                    .HasForeignKey(d => d.AssessmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assessment_AssessmentType");

                entity.HasOne(d => d.Assessor)
                    .WithMany(p => p.AssessmentAssessor)
                    .HasForeignKey(d => d.AssessorId)
                    .HasConstraintName("FK_Assessment_AssessmentAssessor");

                entity.HasOne(d => d.AssessorVerificationResponse)
                    .WithMany(p => p.Assessment)
                    .HasForeignKey(d => d.AssessorVerificationResponseId)
                    .HasConstraintName("FK_Assessment_AssessorVerificationResponse");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Assessment)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assessment_Company");

                entity.HasOne(d => d.CompanyRole)
                    .WithMany(p => p.Assessment)
                    .HasForeignKey(d => d.CompanyRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assessment_CompanyRole");

                entity.HasOne(d => d.CompetencyCycle)
                    .WithMany(p => p.AssessmentCompetencyCycle)
                    .HasForeignKey(d => d.CompetencyCycleId)
                    .HasConstraintName("FK_Assessment_CompetencyCycleAssessments");

                entity.HasOne(d => d.CompletedByUser)
                    .WithMany(p => p.AssessmentCompletedByUser)
                    .HasForeignKey(d => d.CompletedByUserId)
                    .HasConstraintName("FK_Assessment_CompletedByUser");

                entity.HasOne(d => d.CompletedOnPlatform)
                    .WithMany(p => p.AssessmentCompletedOnPlatform)
                    .HasForeignKey(d => d.CompletedOnPlatformId)
                    .HasConstraintName("FK_Assessment_Platform_CompletedOnPlatform");

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany(p => p.AssessmentCreatedByUser)
                    .HasForeignKey(d => d.CreatedByUserId)
                    .HasConstraintName("FK_Assessment_AssessmentCreatedByUser");

                entity.HasOne(d => d.CreatedOnPlatform)
                    .WithMany(p => p.AssessmentCreatedOnPlatform)
                    .HasForeignKey(d => d.CreatedOnPlatformId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assessment_Platform_CreatedOnPlatform");

                entity.HasOne(d => d.InitialCompetencyCycle)
                    .WithMany(p => p.AssessmentInitialCompetencyCycle)
                    .HasForeignKey(d => d.InitialCompetencyCycleId)
                    .HasConstraintName("FK_Assessment_InitialCompetencyCycleAssessments");

                entity.HasOne(d => d.OrigionalAssessment)
                    .WithMany(p => p.InverseOrigionalAssessment)
                    .HasForeignKey(d => d.OrigionalAssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assessment_OrigionalAssessment");

                entity.HasOne(d => d.UserAssessing)
                    .WithMany(p => p.AssessmentUserAssessing)
                    .HasForeignKey(d => d.UserAssessingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assessment_UserAssessing");

                entity.HasOne(d => d.VerificationStatus)
                    .WithMany(p => p.Assessment)
                    .HasForeignKey(d => d.VerificationStatusId)
                    .HasConstraintName("FK_Assessment_VerificationStatus");

                entity.HasOne(d => d.VerifiedByUser)
                    .WithMany(p => p.AssessmentVerifiedByUser)
                    .HasForeignKey(d => d.VerifiedByUserId)
                    .HasConstraintName("FK_Assessment_AssessmentVerifier");
            });

            modelBuilder.Entity<AssessmentCompetency>(entity =>
            {
                entity.Property(e => e.AssessmentCompetencyId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<AssessmentCompetencyCriteria>(entity =>
            {
                entity.HasIndex(e => new { e.CompetencyCriteriaId, e.AssessmentId })
                    .HasName("IX_AssessmentCompetencyCriteria_AssessmentId");

                entity.Property(e => e.AssessmentCompetencyCriteriaId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.AssessmentCompetencyCriteria)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCompetencyCriteria_Assessment");

                entity.HasOne(d => d.CompetencyCriteria)
                    .WithMany(p => p.AssessmentCompetencyCriteria)
                    .HasForeignKey(d => d.CompetencyCriteriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCompetencyCriteria_CompetencyCriteria");
            });

            modelBuilder.Entity<AssessmentConditionCard>(entity =>
            {
                entity.Property(e => e.AssessmentConditionCardId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ArrivalTime).HasColumnType("datetime");

                entity.Property(e => e.DepartureTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AssessmentConditionCard)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentConditionCard_Company");

                entity.HasOne(d => d.EndLocation)
                    .WithMany(p => p.AssessmentConditionCardEndLocation)
                    .HasForeignKey(d => d.EndLocationId)
                    .HasConstraintName("FK_AssessmentConditionCard_EndLocation");

                entity.HasOne(d => d.EndRailheadCondition)
                    .WithMany(p => p.AssessmentConditionCardEndRailheadCondition)
                    .HasForeignKey(d => d.EndRailheadConditionId)
                    .HasConstraintName("FK_AssessmentConditionCard_EndRailheadCondition");

                entity.HasOne(d => d.EndUnderfootCondition)
                    .WithMany(p => p.AssessmentConditionCardEndUnderfootCondition)
                    .HasForeignKey(d => d.EndUnderfootConditionId)
                    .HasConstraintName("FK_AssessmentConditionCard_EndUnderfootCondition");

                entity.HasOne(d => d.EndVisibility)
                    .WithMany(p => p.AssessmentConditionCardEndVisibility)
                    .HasForeignKey(d => d.EndVisibilityId)
                    .HasConstraintName("FK_AssessmentConditionCard_EndVisibility");

                entity.HasOne(d => d.EndWeatherForecast)
                    .WithMany(p => p.AssessmentConditionCardEndWeatherForecast)
                    .HasForeignKey(d => d.EndWeatherForecastId)
                    .HasConstraintName("FK_AssessmentConditionCard_EndWeatherForecast");

                entity.HasOne(d => d.StartLocation)
                    .WithMany(p => p.AssessmentConditionCardStartLocation)
                    .HasForeignKey(d => d.StartLocationId)
                    .HasConstraintName("FK_AssessmentConditionCard_StartLocation");

                entity.HasOne(d => d.StartRailheadCondition)
                    .WithMany(p => p.AssessmentConditionCardStartRailheadCondition)
                    .HasForeignKey(d => d.StartRailheadConditionId)
                    .HasConstraintName("FK_AssessmentConditionCard_StartRailheadCondition");

                entity.HasOne(d => d.StartUnderfootCondition)
                    .WithMany(p => p.AssessmentConditionCardStartUnderfootCondition)
                    .HasForeignKey(d => d.StartUnderfootConditionId)
                    .HasConstraintName("FK_AssessmentConditionCard_StartUnderfootCondition");

                entity.HasOne(d => d.StartVisibility)
                    .WithMany(p => p.AssessmentConditionCardStartVisibility)
                    .HasForeignKey(d => d.StartVisibilityId)
                    .HasConstraintName("FK_AssessmentConditionCard_StartVisibility");

                entity.HasOne(d => d.StartWeatherForecast)
                    .WithMany(p => p.AssessmentConditionCardStartWeatherForecast)
                    .HasForeignKey(d => d.StartWeatherForecastId)
                    .HasConstraintName("FK_AssessmentConditionCard_StartWeatherForecast");

                entity.HasOne(d => d.Traction)
                    .WithMany(p => p.AssessmentConditionCard)
                    .HasForeignKey(d => d.TractionId)
                    .HasConstraintName("FK_AssessmentConditionCard_Traction");
            });

            modelBuilder.Entity<AssessmentConditionCardRoute>(entity =>
            {
                entity.Property(e => e.AssessmentConditionCardRouteId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.AssessmentConditionCard)
                    .WithMany(p => p.AssessmentConditionCardRoute)
                    .HasForeignKey(d => d.AssessmentConditionCardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentConditionCardRoute_AssessmentConditionCard");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AssessmentConditionCardRoute)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentConditionCardRoute_Company");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.AssessmentConditionCardRoute)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentConditionCardRoute_Route");
            });

            modelBuilder.Entity<AssessmentCriteriaCard>(entity =>
            {
                entity.HasIndex(e => new { e.AssessmentCriteriaCardRatingId, e.AssessmentId })
                    .HasName("IX_AssessmentCriteriaCard_AssessmentId");

                entity.HasIndex(e => new { e.AssessmentId, e.AssessmentCriteriaCardRatingId })
                    .HasName("IX_AssessmentCriteriaCard_AssessmentCriteriaCardRatingId");

                entity.HasIndex(e => new { e.AssessmentCriteriaCardId, e.CompanyId, e.AssessmentId, e.AssessmentCriteriaCardRatingId, e.AssessmentCriteriaCardEvidenceId, e.AssessmentConditionCardId, e.ReasonForRating, e.ItemForReview, e.ItemHasBeenReviewed, e.DateCompleted, e.DateArchived, e.IsArchived, e.ArchivedByUserId, e.ModifiedDate, e.CompetencyCriteriaId, e.IsDeleted })
                    .HasName("IX_AssessmentCriteriaCard_CompetencyCriteriaId_IsDeleted");

                entity.Property(e => e.AssessmentCriteriaCardId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ReasonForRating)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.ArchivedByUser)
                    .WithMany(p => p.AssessmentCriteriaCard)
                    .HasForeignKey(d => d.ArchivedByUserId)
                    .HasConstraintName("FK_AssessmentCriteriaCard_ArchivedByUser");

                entity.HasOne(d => d.AssessmentConditionCard)
                    .WithMany(p => p.AssessmentCriteriaCard)
                    .HasForeignKey(d => d.AssessmentConditionCardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCriteriaCard_AssessmentConditionCard");

                entity.HasOne(d => d.AssessmentCriteriaCardEvidence)
                    .WithMany(p => p.AssessmentCriteriaCard)
                    .HasForeignKey(d => d.AssessmentCriteriaCardEvidenceId)
                    .HasConstraintName("FK_AssessmentCriteriaCard_AssessmentCriteriaCardEvidence");

                entity.HasOne(d => d.AssessmentCriteriaCardRating)
                    .WithMany(p => p.AssessmentCriteriaCard)
                    .HasForeignKey(d => d.AssessmentCriteriaCardRatingId)
                    .HasConstraintName("FK_AssessmentCriteriaCard_AssessmentCriteriaCardRating");

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.AssessmentCriteriaCard)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCriteriaCard_Assessment");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AssessmentCriteriaCard)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCriteriaCard_Company");

                entity.HasOne(d => d.CompetencyCriteria)
                    .WithMany(p => p.AssessmentCriteriaCard)
                    .HasForeignKey(d => d.CompetencyCriteriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCriteriaCard_CompetencyCriteria");

                entity.HasOne(d => d.CreatedOnPlatform)
                    .WithMany(p => p.AssessmentCriteriaCard)
                    .HasForeignKey(d => d.CreatedOnPlatformId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCriteriaCard_Platform_CreatedOnPlatform");
            });

            modelBuilder.Entity<AssessmentCriteriaCardAttachment>(entity =>
            {
                entity.Property(e => e.AssessmentCriteriaCardAttachmentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateUploaded).HasColumnType("datetime");

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.AssessmentCriteriaCardAttachmentType)
                    .WithMany(p => p.AssessmentCriteriaCardAttachment)
                    .HasForeignKey(d => d.AssessmentCriteriaCardAttachmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCriteriaCardAttachment_AssessmentCriteriaCardAttachmentType");

                entity.HasOne(d => d.AssessmentCriteriaCard)
                    .WithMany(p => p.AssessmentCriteriaCardAttachment)
                    .HasForeignKey(d => d.AssessmentCriteriaCardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCriteriaCardAttachment_AssessmentCriteriaCard");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AssessmentCriteriaCardAttachment)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentCriteriaCardAttachment_Company");
            });

            modelBuilder.Entity<AssessmentCriteriaCardAttachmentType>(entity =>
            {
                entity.Property(e => e.AssessmentCriteriaCardAttachmentTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<AssessmentCriteriaCardEvidence>(entity =>
            {
                entity.Property(e => e.AssessmentCriteriaCardEvidenceId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<AssessmentCriteriaCardRating>(entity =>
            {
                entity.Property(e => e.AssessmentCriteriaCardRatingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<AssessmentDeadline>(entity =>
            {
                entity.Property(e => e.AssessmentDeadlineId).ValueGeneratedNever();

                entity.Property(e => e.Colour).IsRequired();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<AssessmentDocument>(entity =>
            {
                entity.Property(e => e.AssessmentDocumentId).ValueGeneratedNever();

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.AssessmentDocument)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentDocument_Assessment");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AssessmentDocument)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentDocument_Company");
            });

            modelBuilder.Entity<AssessmentNote>(entity =>
            {
                entity.HasIndex(e => new { e.AssessmentId, e.IsDeleted });

                entity.Property(e => e.AssessmentNoteId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note).IsRequired();

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.AssessmentNote)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentNote_Assessment");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AssessmentNote)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentNote_Company");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.AssessmentNote)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentNote_ModifiedByUser");
            });

            modelBuilder.Entity<AssessmentOtdrDetail>(entity =>
            {
                entity.Property(e => e.AssessmentOtdrDetailId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.LocationText)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.AssessmentOtdrDetailNavigation)
                    .WithOne(p => p.AssessmentOtdrDetail)
                    .HasForeignKey<AssessmentOtdrDetail>(d => d.AssessmentOtdrDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentOtdrDetail_Assessment");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.AssessmentOtdrDetail)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentOtdrDetail_Location");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.AssessmentOtdrDetail)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentOtdrDetail_Route");

                entity.HasOne(d => d.SpeedRestrictionType)
                    .WithMany(p => p.AssessmentOtdrDetail)
                    .HasForeignKey(d => d.SpeedRestrictionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentOtdrDetail_SpeedRestrictionType");
            });

            modelBuilder.Entity<AssessmentPlannedAssessmentTask>(entity =>
            {
                entity.Property(e => e.AssessmentPlannedAssessmentTaskId).ValueGeneratedNever();

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.AssessmentPlannedAssessmentTask)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assessment_AssessmentPlannedAssessmentTask");

                entity.HasOne(d => d.AssessmentTask)
                    .WithMany(p => p.AssessmentPlannedAssessmentTask)
                    .HasForeignKey(d => d.AssessmentTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentTask_AssessmentPlannedAssessmentTask");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AssessmentPlannedAssessmentTask)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_AssessmentPlannedAssessmentTask");
            });

            modelBuilder.Entity<AssessmentSignature>(entity =>
            {
                entity.Property(e => e.AssessmentSignatureId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.AssessmentSignature)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentSignature_Assessment");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AssessmentSignature)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentSignature_Company");
            });

            modelBuilder.Entity<AssessmentTask>(entity =>
            {
                entity.HasIndex(e => new { e.AssessmentTaskId, e.Name, e.ModifiedDate, e.CompanyId, e.IsDeleted })
                    .HasName("IX_AssessmentTask_CompanyId_IsDeleted");

                entity.Property(e => e.AssessmentTaskId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AssessmentTask)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentTask_Company");
            });

            modelBuilder.Entity<AssessmentTaskCompanyRole>(entity =>
            {
                entity.Property(e => e.AssessmentTaskCompanyRoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.AssessmentTask)
                    .WithMany(p => p.AssessmentTaskCompanyRole)
                    .HasForeignKey(d => d.AssessmentTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentTaskCompanyRole_AssessmentTask");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AssessmentTaskCompanyRole)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentTaskCompanyRole_Company");

                entity.HasOne(d => d.CompanyRole)
                    .WithMany(p => p.AssessmentTaskCompanyRole)
                    .HasForeignKey(d => d.CompanyRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentTaskCompanyRole_CompanyRole");
            });

            modelBuilder.Entity<AssessmentTaskReference>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AssessmentTaskReference");

                entity.Property(e => e.AssessmentTaskId).HasMaxLength(36);

                entity.Property(e => e.CompanyId).HasMaxLength(36);

                entity.Property(e => e.OrderByField).IsRequired();

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<AssessmentTaskTime>(entity =>
            {
                entity.Property(e => e.AssessmentTaskTimeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.AssessmentTaskTime)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentTaskTime_Assessment");

                entity.HasOne(d => d.AssessmentTask)
                    .WithMany(p => p.AssessmentTaskTime)
                    .HasForeignKey(d => d.AssessmentTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentTaskTime_AssessmentTask");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AssessmentTaskTime)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentTaskTime_Company");
            });

            modelBuilder.Entity<AssessmentType>(entity =>
            {
                entity.Property(e => e.AssessmentTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<AssessmentVerificationStatement>(entity =>
            {
                entity.Property(e => e.AssessmentVerificationStatementId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.AssessmentVerificationStatement)
                    .HasForeignKey(d => d.AssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentVerificationStatement_Assessment");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AssessmentVerificationStatement)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentVerificationStatement_Company");

                entity.HasOne(d => d.VerificationStatement)
                    .WithMany(p => p.AssessmentVerificationStatement)
                    .HasForeignKey(d => d.VerificationStatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentVerificationStatement_VerificationStatement");

                entity.HasOne(d => d.VerificationStatementRating)
                    .WithMany(p => p.AssessmentVerificationStatement)
                    .HasForeignKey(d => d.VerificationStatementRatingId)
                    .HasConstraintName("FK_AssessmentVerificationStatement_VerificationStatementRating");
            });

            modelBuilder.Entity<AssessorVerificationResponse>(entity =>
            {
                entity.Property(e => e.AssessorVerificationResponseId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<CertificateApplicationStatus>(entity =>
            {
                entity.Property(e => e.CertificateApplicationStatusId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<CertificateLost>(entity =>
            {
                entity.Property(e => e.CertificateLostId).ValueGeneratedNever();

                entity.Property(e => e.DateDuplicateIssued).HasColumnType("datetime");

                entity.Property(e => e.DateReported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CertificateLost)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateLost_CompanyId");

                entity.HasOne(d => d.EtdlApplication)
                    .WithMany(p => p.CertificateLost)
                    .HasForeignKey(d => d.EtdlApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateLost_EtdlApplication");
            });

            modelBuilder.Entity<CertificateStolen>(entity =>
            {
                entity.Property(e => e.CertificateStolenId).ValueGeneratedNever();

                entity.Property(e => e.DateDuplicateIssued).HasColumnType("datetime");

                entity.Property(e => e.DateReported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CertificateStolen)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateStolen_CompanyId");

                entity.HasOne(d => d.EtdlApplication)
                    .WithMany(p => p.CertificateStolen)
                    .HasForeignKey(d => d.EtdlApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateStolen_EtdlApplication");
            });

            modelBuilder.Entity<CertificateType>(entity =>
            {
                entity.Property(e => e.CertificateTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<CertificateWithdrawn>(entity =>
            {
                entity.Property(e => e.CertificateWithdrawnId).ValueGeneratedNever();

                entity.Property(e => e.DateReported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CertificateWithdrawn)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateWithdrawn_CompanyId");

                entity.HasOne(d => d.EtdlApplication)
                    .WithMany(p => p.CertificateWithdrawn)
                    .HasForeignKey(d => d.EtdlApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateWithdrawn_EtdlApplication");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BaseLocationLatitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.BaseLocationLongitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.ReportingWeekEndDay).HasDefaultValueSql("((5))");

                entity.Property(e => e.ReportingWeekEndTime).HasDefaultValueSql("('23:59:59.0000000')");

                entity.Property(e => e.StorageFileBytesLimit).HasDefaultValueSql("((53687091200.))");

                entity.Property(e => e.Telephone).IsRequired();

                entity.Property(e => e.UserLicencesLimit).HasDefaultValueSql("((500))");

                entity.HasOne(d => d.AddressNavigation)
                    .WithMany(p => p.CompanyNavigation)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_Company_CompanyAddress");

                entity.HasOne(d => d.IssuingOrganisation)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.IssuingOrganisationId)
                    .HasConstraintName("FK_Company_IssuingOrganisation");

                entity.HasOne(d => d.SafetyOrganisation)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.SafetyOrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_SafetyOrganisation");
            });

            modelBuilder.Entity<CompanyDocument>(entity =>
            {
                entity.Property(e => e.CompanyDocumentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.CompanyDocumentType)
                    .WithMany(p => p.CompanyDocument)
                    .HasForeignKey(d => d.CompanyDocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyDocument_CompanyDocumentType");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyDocument)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyDocument_Company");
            });

            modelBuilder.Entity<CompanyDocumentType>(entity =>
            {
                entity.Property(e => e.CompanyDocumentTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<CompanyFeature>(entity =>
            {
                entity.Property(e => e.CompanyFeatureId).ValueGeneratedNever();

                entity.Property(e => e.TwoFaenabled).HasColumnName("TwoFAEnabled");

                entity.Property(e => e.TwoFauserAdministrationEnabled).HasColumnName("TwoFAUserAdministrationEnabled");

                entity.HasOne(d => d.CompanyFeatureNavigation)
                    .WithOne(p => p.CompanyFeature)
                    .HasForeignKey<CompanyFeature>(d => d.CompanyFeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyFeature_Company");
            });

            modelBuilder.Entity<CompanyRole>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyRoleId, e.Name, e.ModifiedDate, e.CompanyId, e.IsDeleted })
                    .HasName("IX_CompanyRoles_CompanyId_IsDeleted");

                entity.Property(e => e.CompanyRoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyRole)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyRole_Company");
            });

            modelBuilder.Entity<CompetencyCriteria>(entity =>
            {
                entity.HasIndex(e => new { e.CompetencyElementId, e.IsDeleted });

                entity.HasIndex(e => new { e.CompetencyCriteriaId, e.CompanyId, e.IsDeleted })
                    .HasName("IX_CompetencyCriteria_CompanyId_IsDeleted");

                entity.Property(e => e.CompetencyCriteriaId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.ArchivedByUser)
                    .WithMany(p => p.CompetencyCriteria)
                    .HasForeignKey(d => d.ArchivedByUserId)
                    .HasConstraintName("FK_CompetencyCriteria_User");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompetencyCriteria)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyCriteria_Company");

                entity.HasOne(d => d.CompetencyCriteriaRiskLevel)
                    .WithMany(p => p.CompetencyCriteria)
                    .HasForeignKey(d => d.CompetencyCriteriaRiskLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyCriteria_CompetencyCriteriaRiskLevel");

                entity.HasOne(d => d.CompetencyElement)
                    .WithMany(p => p.CompetencyCriteria)
                    .HasForeignKey(d => d.CompetencyElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyCriteria_CompetencyElement");
            });

            modelBuilder.Entity<CompetencyCriteriaRiskLevel>(entity =>
            {
                entity.Property(e => e.CompetencyCriteriaRiskLevelId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<CompetencyCriteriaRiskLevelReference>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CompetencyCriteriaRiskLevelReference");

                entity.Property(e => e.CompetencyCriteriaRiskLevelId).HasMaxLength(50);

                entity.Property(e => e.OrderIndex).HasMaxLength(5);

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<CompetencyCycle>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyRoleId, e.IsDeleted });

                entity.HasIndex(e => new { e.IsDeleted, e.BaseCompetencyCycleId });

                entity.HasIndex(e => new { e.CompanyRoleId, e.CompanyId, e.IsDeleted, e.IsArchived })
                    .HasName("IX_CompetencyCycle_CompanyId_IsDeleted_IsArchived");

                entity.HasIndex(e => new { e.Name, e.NumberOfMonths, e.ModifiedDate, e.CompanyId, e.CompanyRoleId, e.IsDeleted })
                    .HasName("IX_CompetencyCycle_CompanyId_CompanyRoleId_IsDeleted");

                entity.Property(e => e.CompetencyCycleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.ArchivedByUser)
                    .WithMany(p => p.CompetencyCycle)
                    .HasForeignKey(d => d.ArchivedByUserId)
                    .HasConstraintName("FK_CompetencyCycle_User");

                entity.HasOne(d => d.BaseCompetencyCycle)
                    .WithMany(p => p.InverseBaseCompetencyCycle)
                    .HasForeignKey(d => d.BaseCompetencyCycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyCycle_BaseCompetencyCycle");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompetencyCycle)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyCycle_Company");

                entity.HasOne(d => d.CompanyRole)
                    .WithMany(p => p.CompetencyCycle)
                    .HasForeignKey(d => d.CompanyRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyCycle_CompanyRole");
            });

            modelBuilder.Entity<CompetencyCycleAssessmentWindow>(entity =>
            {
                entity.Property(e => e.CompetencyCycleAssessmentWindowId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Notes).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.AssessmentType)
                    .WithMany(p => p.CompetencyCycleAssessmentWindow)
                    .HasForeignKey(d => d.AssessmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyCycleAssessmentWindow_AssessmentType");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompetencyCycleAssessmentWindow)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyCycleAssessmentWindow_Company");

                entity.HasOne(d => d.CompetencyCycle)
                    .WithMany(p => p.CompetencyCycleAssessmentWindow)
                    .HasForeignKey(d => d.CompetencyCycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyCycleAssessmentWindow_CompetencyCycle");
            });

            modelBuilder.Entity<CompetencyCycleCriteria>(entity =>
            {
                entity.HasIndex(e => new { e.CompetencyCycleCriteriaId, e.CompanyId, e.CompetencyCriteriaId, e.ModifiedDate, e.IsDeleted, e.CompetencyCycleId })
                    .HasName("IX_CompetencyCycleCriteria_CompetencyCycleId");

                entity.HasIndex(e => new { e.CompetencyCycleCriteriaId, e.CompanyId, e.CompetencyCycleId, e.ModifiedDate, e.CompetencyCriteriaId, e.IsDeleted })
                    .HasName("IX_CompetencyCycleCriteria_CompetencyCriteriaId_IsDeleted");

                entity.Property(e => e.CompetencyCycleCriteriaId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompetencyCycleCriteria)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyCycleCriteria_Company");

                entity.HasOne(d => d.CompetencyCriteria)
                    .WithMany(p => p.CompetencyCycleCriteria)
                    .HasForeignKey(d => d.CompetencyCriteriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyCycleCriteria_CompetencyCriteria");

                entity.HasOne(d => d.CompetencyCycle)
                    .WithMany(p => p.CompetencyCycleCriteria)
                    .HasForeignKey(d => d.CompetencyCycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyCycleCriteria_CompetencyCycle");
            });

            modelBuilder.Entity<CompetencyElement>(entity =>
            {
                entity.Property(e => e.CompetencyElementId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.ArchivedByUser)
                    .WithMany(p => p.CompetencyElement)
                    .HasForeignKey(d => d.ArchivedByUserId)
                    .HasConstraintName("FK_CompetencyElement_User");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompetencyElement)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyElement_Company");

                entity.HasOne(d => d.CompetencyUnit)
                    .WithMany(p => p.CompetencyElement)
                    .HasForeignKey(d => d.CompetencyUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyElement_CompetencyUnit");
            });

            modelBuilder.Entity<CompetencyElementLearningResource>(entity =>
            {
                entity.Property(e => e.CompetencyElementLearningResourceId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompetencyElementLearningResource)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyElementLearningResource_Company");

                entity.HasOne(d => d.CompetencyElement)
                    .WithMany(p => p.CompetencyElementLearningResource)
                    .HasForeignKey(d => d.CompetencyElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyElementLearningResource_CompetencyElement");
            });

            modelBuilder.Entity<CompetencyUnit>(entity =>
            {
                entity.Property(e => e.CompetencyUnitId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.ArchivedByUser)
                    .WithMany(p => p.CompetencyUnit)
                    .HasForeignKey(d => d.ArchivedByUserId)
                    .HasConstraintName("FK_CompetencyUnit_User");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompetencyUnit)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyUnit_Company");
            });

            modelBuilder.Entity<ComplementaryCertificate>(entity =>
            {
                entity.Property(e => e.ComplementaryCertificateId).ValueGeneratedNever();

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.EmployeeReference).IsRequired();

                entity.Property(e => e.ExpiryDateDeprecated)
                    .HasColumnName("ExpiryDate_Deprecated")
                    .HasColumnType("date");

                entity.Property(e => e.InternalReferenceNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IssuingDateDeprecated)
                    .HasColumnName("IssuingDate_Deprecated")
                    .HasColumnType("date");

                entity.Property(e => e.IssuingOrganisation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LicenceEuropeanIdentificationNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.SubmittedByUserIdDeprecated).HasColumnName("SubmittedByUserId_Deprecated");

                entity.Property(e => e.SubmittedDateDeprecated)
                    .HasColumnName("SubmittedDate_Deprecated")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.ComplementaryCertificate)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_ComplementaryCertificate_Address");

                entity.HasOne(d => d.ArchivedByUser)
                    .WithMany(p => p.ComplementaryCertificateArchivedByUser)
                    .HasForeignKey(d => d.ArchivedByUserId)
                    .HasConstraintName("FK_ComplementaryCertificate_ComplementaryCertificateArchivedByUser");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ComplementaryCertificate)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplementaryCertificate_Company");

                entity.HasOne(d => d.EtdlApplication)
                    .WithMany(p => p.ComplementaryCertificate)
                    .HasForeignKey(d => d.EtdlApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplementaryCertificate_EtdlApplication");

                entity.HasOne(d => d.SubmittedByUserIdDeprecatedNavigation)
                    .WithMany(p => p.ComplementaryCertificateSubmittedByUserIdDeprecatedNavigation)
                    .HasForeignKey(d => d.SubmittedByUserIdDeprecated)
                    .HasConstraintName("FK_ComplementaryCertificate_ComplementaryCertificateSubmittedByUser");
            });

            modelBuilder.Entity<ComplementaryCertificateCompanyDetail>(entity =>
            {
                entity.Property(e => e.ComplementaryCertificateCompanyDetailId).ValueGeneratedNever();

                entity.Property(e => e.LegalName).IsRequired();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.ComplementaryCertificateCompanyDetail)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_ComplementaryCertificateCompanyDetail_Address");

                entity.HasOne(d => d.CertificateType)
                    .WithMany(p => p.ComplementaryCertificateCompanyDetail)
                    .HasForeignKey(d => d.CertificateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplementaryCertificateCompanyDetail_CertificateType");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ComplementaryCertificateCompanyDetail)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplementaryCertificateCompanyDetail_Company");

                entity.HasOne(d => d.ComplementaryCertificateCompanyDetailNavigation)
                    .WithOne(p => p.ComplementaryCertificateCompanyDetail)
                    .HasForeignKey<ComplementaryCertificateCompanyDetail>(d => d.ComplementaryCertificateCompanyDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplementaryCertificateCompanyDetail_ComplementaryCertificate");
            });

            modelBuilder.Entity<ComplementaryCertificateDateInfo>(entity =>
            {
                entity.Property(e => e.ComplementaryCertificateDateInfoId).ValueGeneratedNever();

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.IssuingDate).HasColumnType("date");

                entity.Property(e => e.RecertificationDate).HasColumnType("date");

                entity.Property(e => e.SubmittedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ComplementaryCertificate)
                    .WithMany(p => p.ComplementaryCertificateDateInfo)
                    .HasForeignKey(d => d.ComplementaryCertificateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplementaryCertificateDateInfo_ComplementaryCertificate");

                entity.HasOne(d => d.SubmittedByUser)
                    .WithMany(p => p.ComplementaryCertificateDateInfo)
                    .HasForeignKey(d => d.SubmittedByUserId)
                    .HasConstraintName("FK_ComplementaryCertificateDateInfo_User");
            });

            modelBuilder.Entity<ComplementaryCertificateFile>(entity =>
            {
                entity.HasIndex(e => new { e.ComplementaryCertificateFileTypeId, e.ComplementaryCertificateId, e.IsDeleted })
                    .HasName("IX_ComplementaryCertificateFile")
                    .IsUnique()
                    .HasFilter("([IsDeleted]=(0))");

                entity.Property(e => e.ComplementaryCertificateFileId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.ComplementaryCertificateFileType)
                    .WithMany(p => p.ComplementaryCertificateFile)
                    .HasForeignKey(d => d.ComplementaryCertificateFileTypeId)
                    .HasConstraintName("FK_ComplementaryCertificateFile_ComplementaryCertificateFileType");

                entity.HasOne(d => d.ComplementaryCertificate)
                    .WithMany(p => p.ComplementaryCertificateFile)
                    .HasForeignKey(d => d.ComplementaryCertificateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplementaryCertificateFile_ComplementaryCertificate");
            });

            modelBuilder.Entity<ComplementaryCertificateFileType>(entity =>
            {
                entity.Property(e => e.ComplementaryCertificateFileTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<ComplementaryCertificateUserDetail>(entity =>
            {
                entity.Property(e => e.ComplementaryCertificateUserDetailId).ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.ComplementaryCertificateUserDetail)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_ComplementaryCertificateUserDetail_Address");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ComplementaryCertificateUserDetail)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplementaryCertificateUserDetail_Company");

                entity.HasOne(d => d.ComplementaryCertificateUserDetailNavigation)
                    .WithOne(p => p.ComplementaryCertificateUserDetail)
                    .HasForeignKey<ComplementaryCertificateUserDetail>(d => d.ComplementaryCertificateUserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplementaryCertificateUserDetail_ComplementaryCertificate");
            });

            modelBuilder.Entity<ComplementaryCertificateUserDetailDrivingCategory>(entity =>
            {
                entity.HasIndex(e => new { e.DrivingCategoryId, e.ModifiedDate, e.IsDeleted, e.CompanyId, e.ComplementaryCertificateUserDetailId })
                    .HasName("IX_ComplementaryCertificateUserDetailDrivingCategory_CompanyId_ComplementaryCertificateUserDetailId");

                entity.Property(e => e.ComplementaryCertificateUserDetailDrivingCategoryId).ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ComplementaryCertificateUserDetailDrivingCategory)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplementaryCertificateUserDetailDrivingCategory_Company");

                entity.HasOne(d => d.ComplementaryCertificateUserDetail)
                    .WithMany(p => p.ComplementaryCertificateUserDetailDrivingCategory)
                    .HasForeignKey(d => d.ComplementaryCertificateUserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplementaryCertificateUserDetailDrivingCategory_ComplementaryCertificateUserDetail");

                entity.HasOne(d => d.DrivingCategory)
                    .WithMany(p => p.ComplementaryCertificateUserDetailDrivingCategory)
                    .HasForeignKey(d => d.DrivingCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplementaryCertificateUserDetailDrivingCategory_DrivingCategory");
            });

            modelBuilder.Entity<ComplementaryCertificateUserDetailLanguageSkill>(entity =>
            {
                entity.Property(e => e.ComplementaryCertificateUserDetailLanguageSkillId).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ComplementaryCertificateUserDetailLanguageSkill)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplementaryCertificateUserDetailLanguageSkill_Company");

                entity.HasOne(d => d.ComplementaryCertificateUserDetail)
                    .WithMany(p => p.ComplementaryCertificateUserDetailLanguageSkill)
                    .HasForeignKey(d => d.ComplementaryCertificateUserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComplementaryCertificateUserDetailLanguageSkill_ComplementaryCertificateUserDetail");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<DatabaseMigration>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DatabaseMigrationId).ValueGeneratedOnAdd();

                entity.Property(e => e.DateApplied)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DatabaseVersion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyId, e.Code, e.Name })
                    .IsUnique()
                    .HasFilter("([CODE] IS NOT NULL AND [IsDeleted]=(0))");

                entity.Property(e => e.DepartmentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(255);

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Department_Company");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_Department_Location");
            });

            modelBuilder.Entity<DriverIrregularity>(entity =>
            {
                entity.Property(e => e.DriverIrregularityId).ValueGeneratedNever();

                entity.Property(e => e.Headcode).HasMaxLength(255);

                entity.Property(e => e.Latitude).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OtdrPin).HasMaxLength(255);

                entity.Property(e => e.TimeEntered).HasColumnType("datetime");

                entity.Property(e => e.TriggerName).HasMaxLength(255);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DriverIrregularity)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DriverIrregularity_Company");
            });

            modelBuilder.Entity<DriverIrregularityAssignment>(entity =>
            {
                entity.HasKey(e => e.AssignmentId)
                    .HasName("PK_Assignment");

                entity.HasIndex(e => e.DriverIrregularityId);

                entity.Property(e => e.AssignmentId).ValueGeneratedNever();

                entity.Property(e => e.TimeAssigned).HasColumnType("datetime");

                entity.HasOne(d => d.DriverIrregularity)
                    .WithMany(p => p.DriverIrregularityAssignment)
                    .HasForeignKey(d => d.DriverIrregularityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DriverIrregularityAssignment_DriverIrregularity");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DriverIrregularityAssignment)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AssignmentUserId_DriverIrregularity");
            });

            modelBuilder.Entity<DrivingCategory>(entity =>
            {
                entity.Property(e => e.DrivingCategoryId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<DrugsAlcoholAndDiabetesAssessment>(entity =>
            {
                entity.Property(e => e.DrugsAlcoholAndDiabetesAssessmentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AlcoholTestResultDate).HasColumnType("datetime");

                entity.Property(e => e.DrugsTestResultDate).HasColumnType("datetime");

                entity.HasOne(d => d.AlcoholTestResult)
                    .WithMany(p => p.DrugsAlcoholAndDiabetesAssessmentAlcoholTestResult)
                    .HasForeignKey(d => d.AlcoholTestResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DrugsAlcoholAndDiabetesAssessment_AlcoholTestResult");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DrugsAlcoholAndDiabetesAssessment)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DrugsAlcoholAndDiabetesAssessment_Company");

                entity.HasOne(d => d.DiabetesTestResult)
                    .WithMany(p => p.DrugsAlcoholAndDiabetesAssessmentDiabetesTestResult)
                    .HasForeignKey(d => d.DiabetesTestResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DrugsAlcoholAndDiabetesAssessment_DiabetesTestResult");

                entity.HasOne(d => d.DrugsTestResult)
                    .WithMany(p => p.DrugsAlcoholAndDiabetesAssessmentDrugsTestResult)
                    .HasForeignKey(d => d.DrugsTestResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DrugsAlcoholAndDiabetesAssessment_DrugsTestResult");

                entity.HasOne(d => d.ForCauseScreeningResult)
                    .WithMany(p => p.DrugsAlcoholAndDiabetesAssessmentForCauseScreeningResult)
                    .HasForeignKey(d => d.ForCauseScreeningResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DrugsAlcoholAndDiabetesAssessment_ForCauseScreeningResult");

                entity.HasOne(d => d.GeneralHealthResult)
                    .WithMany(p => p.DrugsAlcoholAndDiabetesAssessmentGeneralHealthResult)
                    .HasForeignKey(d => d.GeneralHealthResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DrugsAlcoholAndDiabetesAssessment_GeneralHealthResult");
            });

            modelBuilder.Entity<DurationUnit>(entity =>
            {
                entity.Property(e => e.DurationUnitId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<DurationUnitDayMonthWeekReference>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DurationUnitDayMonthWeekReference");

                entity.Property(e => e.DurationUnitId).HasMaxLength(50);

                entity.Property(e => e.OrderByField).HasMaxLength(1);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<EmployeeAuthorityToWorkStatus>(entity =>
            {
                entity.Property(e => e.EmployeeAuthorityToWorkStatusId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<EmployeeSafetyCriticalStatus>(entity =>
            {
                entity.Property(e => e.EmployeeSafetyCriticalStatusId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<EtdlApplication>(entity =>
            {
                entity.Property(e => e.EtdlApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.DateCompleted)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ArchivedByUser)
                    .WithMany(p => p.EtdlApplicationArchivedByUser)
                    .HasForeignKey(d => d.ArchivedByUserId)
                    .HasConstraintName("FK_EtdlApplication_EtdlApplicationArchivedByUser");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.EtdlApplication)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlApplication_Company");

                entity.HasOne(d => d.EtdlApplicationStatus)
                    .WithMany(p => p.EtdlApplication)
                    .HasForeignKey(d => d.EtdlApplicationStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlApplication_EtdlApplicationStatus");

                entity.HasOne(d => d.SubmittedByUser)
                    .WithMany(p => p.EtdlApplicationSubmittedByUser)
                    .HasForeignKey(d => d.SubmittedByUserId)
                    .HasConstraintName("FK_EtdlApplication_EtdlApplicationSubmittedByUser");
            });

            modelBuilder.Entity<EtdlApplicationDetail>(entity =>
            {
                entity.Property(e => e.EtdlApplicationDetailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateOfFirstIssue).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.SafetyOrganisationAppliedTo).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.EtdlApplicationDetail)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlApplicationDetail_Company");

                entity.HasOne(d => d.EtdlApplicationDetailNavigation)
                    .WithOne(p => p.EtdlApplicationDetail)
                    .HasForeignKey<EtdlApplicationDetail>(d => d.EtdlApplicationDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlApplicationDetail_EtdlApplication");

                entity.HasOne(d => d.EtdlApplicationType)
                    .WithMany(p => p.EtdlApplicationDetail)
                    .HasForeignKey(d => d.EtdlApplicationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlApplicationDetail_EtdlApplicationType");

                entity.HasOne(d => d.SafetyOrganisationAppliedToAddress)
                    .WithMany(p => p.EtdlApplicationDetail)
                    .HasForeignKey(d => d.SafetyOrganisationAppliedToAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlApplicationDetail_SafetyOrganisationAppliedToAddress");
            });

            modelBuilder.Entity<EtdlApplicationFile>(entity =>
            {
                entity.HasIndex(e => new { e.EtdlApplicationFileTypeId, e.EtdlApplicationId, e.IsDeleted })
                    .HasName("IX_EtdlApplicationFile")
                    .IsUnique()
                    .HasFilter("([IsDeleted]=(0))");

                entity.Property(e => e.EtdlApplicationFileId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.EtdlApplicationFileType)
                    .WithMany(p => p.EtdlApplicationFile)
                    .HasForeignKey(d => d.EtdlApplicationFileTypeId)
                    .HasConstraintName("FK_EtdlApplicationFile_EtdlApplicationFileType");

                entity.HasOne(d => d.EtdlApplication)
                    .WithMany(p => p.EtdlApplicationFile)
                    .HasForeignKey(d => d.EtdlApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlApplicationFile_EtdlApplication");
            });

            modelBuilder.Entity<EtdlApplicationFileType>(entity =>
            {
                entity.Property(e => e.EtdlApplicationFileTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<EtdlApplicationGeneralCompetencyTrainingPassed>(entity =>
            {
                entity.Property(e => e.EtdlApplicationGeneralCompetencyTrainingPassedId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<EtdlApplicationMedicalExaminationPassed>(entity =>
            {
                entity.Property(e => e.EtdlApplicationMedicalExaminationPassedId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<EtdlApplicationPsychologicalAssessmentPassed>(entity =>
            {
                entity.Property(e => e.EtdlApplicationPsychologicalAssessmentPassedId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<EtdlApplicationStatus>(entity =>
            {
                entity.Property(e => e.EtdlApplicationStatusId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<EtdlApplicationType>(entity =>
            {
                entity.Property(e => e.EtdlApplicationTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<EtdlCertificatePostalAddress>(entity =>
            {
                entity.Property(e => e.EtdlCertificatePostalAddressId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.EtdlCertificatePostalAddress)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_EtdlCertificatePostalAddress_Country");
            });

            modelBuilder.Entity<EtdlCompanyDetail>(entity =>
            {
                entity.Property(e => e.EtdlCompanyDetailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Status).IsRequired();

                entity.Property(e => e.Telephone).IsRequired();

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.EtdlCompanyDetail)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlCompanyDetail_Address");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.EtdlCompanyDetail)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlCompanyDetail_Company");

                entity.HasOne(d => d.EtdlCompanyDetailNavigation)
                    .WithOne(p => p.EtdlCompanyDetail)
                    .HasForeignKey<EtdlCompanyDetail>(d => d.EtdlCompanyDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlCompanyDetail_EtdlApplication");
            });

            modelBuilder.Entity<EtdlUpdate>(entity =>
            {
                entity.Property(e => e.EtdlUpdateId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Notes).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.EtdlUpdate)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlUpdate_Company");

                entity.HasOne(d => d.EtdlApplication)
                    .WithMany(p => p.EtdlUpdate)
                    .HasForeignKey(d => d.EtdlApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlUpdate_EtdlApplication");

                entity.HasOne(d => d.EtdlUpdateType)
                    .WithMany(p => p.EtdlUpdate)
                    .HasForeignKey(d => d.EtdlUpdateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlUpdate_EtdlUpdateType");
            });

            modelBuilder.Entity<EtdlUpdateType>(entity =>
            {
                entity.Property(e => e.EtdlUpdateTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<EtdlUserDetail>(entity =>
            {
                entity.Property(e => e.EtdlUserDetailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.EtdlUserDetail)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlUserDetail_Company");

                entity.HasOne(d => d.CompanyRole)
                    .WithMany(p => p.EtdlUserDetail)
                    .HasForeignKey(d => d.CompanyRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlUserDetail_CompanyRole");

                entity.HasOne(d => d.EtdlUserDetailNavigation)
                    .WithOne(p => p.EtdlUserDetail)
                    .HasForeignKey<EtdlUserDetail>(d => d.EtdlUserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlUserDetail_EtdlApplication");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.EtdlUserDetail)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlUserDetail_Gender");

                entity.HasOne(d => d.PermanentAddress)
                    .WithMany(p => p.EtdlUserDetailPermanentAddress)
                    .HasForeignKey(d => d.PermanentAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlUserDetail_PermanentAddress");

                entity.HasOne(d => d.PostalAddress)
                    .WithMany(p => p.EtdlUserDetailPostalAddress)
                    .HasForeignKey(d => d.PostalAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlUserDetail_PostalAddress");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EtdlUserDetail)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlUserDetail_User");
            });

            modelBuilder.Entity<EtdlUserMedicalDetail>(entity =>
            {
                entity.Property(e => e.EtdlUserMedicalDetailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.MedicalExaminationDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.PsychologicalAssessmentDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.EtdlUserMedicalDetail)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlUserMedicalDetail_Company");

                entity.HasOne(d => d.EtdlApplicationGeneralCompetencyTrainingPassed)
                    .WithMany(p => p.EtdlUserMedicalDetail)
                    .HasForeignKey(d => d.EtdlApplicationGeneralCompetencyTrainingPassedId)
                    .HasConstraintName("FK_EtdlUserMedicalDetail_EtdlApplicationGeneralCompetencyTrainingPassed");

                entity.HasOne(d => d.EtdlApplicationMedicalExaminationPassed)
                    .WithMany(p => p.EtdlUserMedicalDetail)
                    .HasForeignKey(d => d.EtdlApplicationMedicalExaminationPassedId)
                    .HasConstraintName("FK_EtdlUserMedicalDetail_EtdlApplicationMedicalExaminationPassed");

                entity.HasOne(d => d.EtdlApplicationPsychologicalAssessmentPassed)
                    .WithMany(p => p.EtdlUserMedicalDetail)
                    .HasForeignKey(d => d.EtdlApplicationPsychologicalAssessmentPassedId)
                    .HasConstraintName("FK_EtdlUserMedicalDetail_EtdlApplicationPsychologicalAssessmentPassed");

                entity.HasOne(d => d.EtdlUserDetail)
                    .WithMany(p => p.EtdlUserMedicalDetail)
                    .HasForeignKey(d => d.EtdlUserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EtdlUserMedicalDetail_EtdlUserDetail");

                entity.HasOne(d => d.OrrDoctor)
                    .WithMany(p => p.EtdlUserMedicalDetailOrrDoctor)
                    .HasForeignKey(d => d.OrrDoctorId)
                    .HasConstraintName("FK_EtdlUserMedicalDetail_OrrDoctor");

                entity.HasOne(d => d.OrrPsychologist)
                    .WithMany(p => p.EtdlUserMedicalDetailOrrPsychologist)
                    .HasForeignKey(d => d.OrrPsychologistId)
                    .HasConstraintName("FK_EtdlUserMedicalDetail_OrrPsychologist");
            });

            modelBuilder.Entity<FileUploadQueueItem>(entity =>
            {
                entity.Property(e => e.FileUploadQueueItemId).ValueGeneratedNever();

                entity.Property(e => e.ContainerName).IsRequired();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateLastAttemptUploaded).HasColumnType("datetime");

                entity.Property(e => e.FileData).IsRequired();

                entity.Property(e => e.Filename).IsRequired();

                entity.Property(e => e.MimeType).IsRequired();
            });

            modelBuilder.Entity<ForceUpdateCompetencyCycleQueue>(entity =>
            {
                entity.Property(e => e.ForceUpdateCompetencyCycleQueueId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastProcessedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany(p => p.ForceUpdateCompetencyCycleQueue)
                    .HasForeignKey(d => d.CreatedByUserId)
                    .HasConstraintName("FK_ForceUpdateCompetencyCycleQueue_CreatedByUser");

                entity.HasOne(d => d.NewCompetencyCycle)
                    .WithMany(p => p.ForceUpdateCompetencyCycleQueue)
                    .HasForeignKey(d => d.NewCompetencyCycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ForceUpdateCompetencyCycleQueue_CompetencyCycle");

                entity.HasOne(d => d.TaskStatus)
                    .WithMany(p => p.ForceUpdateCompetencyCycleQueue)
                    .HasForeignKey(d => d.TaskStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ForceUpdateCompetencyCycleQueue_TaskStatus");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.Property(e => e.GenderId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<HearingAssessment>(entity =>
            {
                entity.Property(e => e.HearingAssessmentId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.HearingAssessment)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HearingAssessment_Company");

                entity.HasOne(d => d.HearingAidRequiredResult)
                    .WithMany(p => p.HearingAssessmentHearingAidRequiredResult)
                    .HasForeignKey(d => d.HearingAidRequiredResultId)
                    .HasConstraintName("FK_HearingAssessment_HearingAidRequiredResult");

                entity.HasOne(d => d.HearingAidedResult)
                    .WithMany(p => p.HearingAssessmentHearingAidedResult)
                    .HasForeignKey(d => d.HearingAidedResultId)
                    .HasConstraintName("FK_HearingAssessment_HearingAidedResult");

                entity.HasOne(d => d.HearingUnaidedResult)
                    .WithMany(p => p.HearingAssessmentHearingUnaidedResult)
                    .HasForeignKey(d => d.HearingUnaidedResultId)
                    .HasConstraintName("FK_HearingAssessment_HearingUnaidedResult");
            });

            modelBuilder.Entity<Incident>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyId, e.UserId, e.IsDeleted, e.IsArchived });

                entity.HasIndex(e => new { e.DateOfIncident, e.ModifiedDate, e.IsDeleted, e.UserId, e.IncidentTypeId, e.DateCreated })
                    .HasName("IX_Incident_UserId_IncidentTypeId_DateCreated");

                entity.HasIndex(e => new { e.UserId, e.DateOfIncident, e.ModifiedDate, e.IsDeleted, e.IncidentTypeId, e.DateCreated })
                    .HasName("IX_Incident_IncidentTypeId_DateCreated");

                entity.Property(e => e.IncidentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.DateOfIncident).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.ArchivedByUser)
                    .WithMany(p => p.IncidentArchivedByUser)
                    .HasForeignKey(d => d.ArchivedByUserId)
                    .HasConstraintName("FK_Incident_IncidentArchivedByUser");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Incident)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Incident_Company");

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany(p => p.IncidentCreatedByUser)
                    .HasForeignKey(d => d.CreatedByUserId)
                    .HasConstraintName("FK_Incident_IncidentCreatedByUser");

                entity.HasOne(d => d.IncidentResponsibilityLevel)
                    .WithMany(p => p.Incident)
                    .HasForeignKey(d => d.IncidentResponsibilityLevelId)
                    .HasConstraintName("FK_Incident_IncidentResponsibilityLevel");

                entity.HasOne(d => d.IncidentType)
                    .WithMany(p => p.Incident)
                    .HasForeignKey(d => d.IncidentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Incident_IncidentType");

                entity.HasOne(d => d.ReportCompletedByUser)
                    .WithMany(p => p.IncidentReportCompletedByUser)
                    .HasForeignKey(d => d.ReportCompletedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Incident_ReportCompletedByUser");

                entity.HasOne(d => d.SupportPlanType)
                    .WithMany(p => p.Incident)
                    .HasForeignKey(d => d.SupportPlanTypeId)
                    .HasConstraintName("FK_Incident_SupportPlanType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.IncidentUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Incident_IncidentUser");
            });

            modelBuilder.Entity<IncidentEvent>(entity =>
            {
                entity.HasIndex(e => new { e.IncidentId, e.IsDeleted });

                entity.HasIndex(e => new { e.CompanyId, e.IncidentId, e.IsDeleted });

                entity.Property(e => e.IncidentEventId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.IncidentEvent)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncidentEvent_Company");

                entity.HasOne(d => d.Incident)
                    .WithMany(p => p.IncidentEvent)
                    .HasForeignKey(d => d.IncidentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncidentEvent_Incident");
            });

            modelBuilder.Entity<IncidentReport>(entity =>
            {
                entity.Property(e => e.IncidentReportId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.IncidentReport)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncidentReport_Company");

                entity.HasOne(d => d.Incident)
                    .WithMany(p => p.IncidentReport)
                    .HasForeignKey(d => d.IncidentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncidentReport_Incident");
            });

            modelBuilder.Entity<IncidentResponsibilityLevel>(entity =>
            {
                entity.Property(e => e.IncidentResponsibilityLevelId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<IncidentType>(entity =>
            {
                entity.Property(e => e.IncidentTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<InfrastructureAuthorisedToOperate>(entity =>
            {
                entity.HasIndex(e => new { e.UserCompanyRoleId, e.IsDeleted });

                entity.Property(e => e.InfrastructureAuthorisedToOperateId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.InfrastructureAuthorisedToOperate)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InfrastructureAuthorisedToOperate_Company");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.InfrastructureAuthorisedToOperate)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InfrastructureAuthorisedToOperate_Route");

                entity.HasOne(d => d.UserCompanyRole)
                    .WithMany(p => p.InfrastructureAuthorisedToOperate)
                    .HasForeignKey(d => d.UserCompanyRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InfrastructureAuthorisedToOperate_UserCompanyRole");
            });

            modelBuilder.Entity<InfrastructureAuthorisedToOperateSigningHistory>(entity =>
            {
                entity.Property(e => e.InfrastructureAuthorisedToOperateSigningHistoryId).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RenewedDateTime).HasColumnType("datetime");

                entity.Property(e => e.SignedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.InfrastructureAuthorisedToOperate)
                    .WithMany(p => p.InfrastructureAuthorisedToOperateSigningHistory)
                    .HasForeignKey(d => d.InfrastructureAuthorisedToOperateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InfrastructureAuthorisedToOperateSigningHistory_InfrastructureAuthorisedToOperate");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.InfrastructureAuthorisedToOperateSigningHistoryModifiedByUser)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InfrastructureAuthorisedToOperateSigningHistory_InfrastructureSigningModifiedByUser");

                entity.HasOne(d => d.SignedByUser)
                    .WithMany(p => p.InfrastructureAuthorisedToOperateSigningHistorySignedByUser)
                    .HasForeignKey(d => d.SignedByUserId)
                    .HasConstraintName("FK_InfrastructureAuthorisedToOperateSigningHistory_InfrastructureSigningSignedByUser");
            });

            modelBuilder.Entity<IssuingOrganisation>(entity =>
            {
                entity.Property(e => e.IssuingOrganisationId).ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.IssuingOrganisation)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IssuingOrganisation_AddressId");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.IssuingOrganisationNavigation)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IssuingOrganisation_Company");
            });

            modelBuilder.Entity<LearningResource>(entity =>
            {
                entity.Property(e => e.LearningResourceId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.LearningResource)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LearningResource_Company");

                entity.HasOne(d => d.LearningResourceMediaType)
                    .WithMany(p => p.LearningResource)
                    .HasForeignKey(d => d.LearningResourceMediaTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LearningResource_LearningResourceMediaType");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.LearningResource)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LearningResource_ModifiedByUser");
            });

            modelBuilder.Entity<LearningResourceCompanyRole>(entity =>
            {
                entity.Property(e => e.LearningResourceCompanyRoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CompanyRole)
                    .WithMany(p => p.LearningResourceCompanyRole)
                    .HasForeignKey(d => d.CompanyRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LearningResourceCompanyRole_CompanyRole");

                entity.HasOne(d => d.LearningResource)
                    .WithMany(p => p.LearningResourceCompanyRole)
                    .HasForeignKey(d => d.LearningResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LearningResourceCompanyRole_LearningResource");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.LearningResourceCompanyRole)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LearningResourceCompanyRole_ModifiedByUser");
            });

            modelBuilder.Entity<LearningResourceFile>(entity =>
            {
                entity.Property(e => e.LearningResourceFileId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.LearningResourceFile)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LearningResourceFile_Company");

                entity.HasOne(d => d.LearningResource)
                    .WithMany(p => p.LearningResourceFile)
                    .HasForeignKey(d => d.LearningResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LearningResourceFile_LearningResource");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.LearningResourceFile)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LearningResourceFile_ModifiedByUser");
            });

            modelBuilder.Entity<LearningResourceMediaType>(entity =>
            {
                entity.Property(e => e.LearningResourceMediaTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.LocationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.UserAssignable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Location_Company");
            });

            modelBuilder.Entity<MedicalAssessmentDetail>(entity =>
            {
                entity.Property(e => e.MedicalAssessmentDetailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AssessmentCompletedBy).IsRequired();

                entity.Property(e => e.DateOfMedicalAssessment).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MedicalAssessmentDetail)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalAssessmentDetail_Company");

                entity.HasOne(d => d.MedicalIndicator)
                    .WithMany(p => p.MedicalAssessmentDetail)
                    .HasForeignKey(d => d.MedicalIndicatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentDetails_MedicalIndicator");

                entity.HasOne(d => d.MedicalTimeframe)
                    .WithMany(p => p.MedicalAssessmentDetail)
                    .HasForeignKey(d => d.MedicalTimeframeId)
                    .HasConstraintName("FK_MedicalAssessmentDetail_MedicalTimeframe");
            });

            modelBuilder.Entity<MedicalAssessmentResult>(entity =>
            {
                entity.Property(e => e.MedicalAssessmentResultId).ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<MedicalAssessmentType>(entity =>
            {
                entity.Property(e => e.MedicalAssessmentTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<MedicalIndicator>(entity =>
            {
                entity.Property(e => e.MedicalIndicatorId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<MedicalPractitioner>(entity =>
            {
                entity.Property(e => e.MedicalPractitionerId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.MedicalPractitioner)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalPractitioner_Address");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MedicalPractitioner)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalPractitioner_Company");
            });

            modelBuilder.Entity<MedicalStatus>(entity =>
            {
                entity.Property(e => e.MedicalStatusId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<MedicalTimeframe>(entity =>
            {
                entity.Property(e => e.MedicalTimeframeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<MedicationInformationCategory>(entity =>
            {
                entity.Property(e => e.MedicationInformationCategoryId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<Messages0>(entity =>
            {
                entity.HasKey(e => e.PayloadId)
                    .HasName("PK__Messages__A18B4A8F478773E1");

                entity.ToTable("Messages_0", "SignalR");

                entity.Property(e => e.PayloadId).ValueGeneratedNever();

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.Payload).IsRequired();
            });

            modelBuilder.Entity<Messages0Id>(entity =>
            {
                entity.HasKey(e => e.PayloadId)
                    .HasName("PK__Messages__A18B4A8F4B5804C5");

                entity.ToTable("Messages_0_Id", "SignalR");

                entity.Property(e => e.PayloadId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.NotificationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProcessedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.NotificationType)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.NotificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notification_NotificationType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notification_User");
            });

            modelBuilder.Entity<NotificationCategory>(entity =>
            {
                entity.Property(e => e.NotificationCategoryId).ValueGeneratedNever();

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NotificationCategoryReference>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NotificationCategoryReference");

                entity.Property(e => e.NotificationCategoryId).HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NotificationGroup>(entity =>
            {
                entity.Property(e => e.NotificationGroupId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<NotificationGroupReference>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NotificationGroupReference");

                entity.Property(e => e.NotificationGroupId).HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<NotificationQueue>(entity =>
            {
                entity.Property(e => e.NotificationQueueId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.LastProcessedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.NotificationType)
                    .WithMany(p => p.NotificationQueue)
                    .HasForeignKey(d => d.NotificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationQueue_NotificationType");

                entity.HasOne(d => d.TaskStatus)
                    .WithMany(p => p.NotificationQueue)
                    .HasForeignKey(d => d.TaskStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationQueue_TaskStatus");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NotificationQueue)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationQueue_User");
            });

            modelBuilder.Entity<NotificationSubCategory>(entity =>
            {
                entity.Property(e => e.NotificationSubCategoryId).ValueGeneratedNever();

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.NotificationCategory)
                    .WithMany(p => p.NotificationSubCategory)
                    .HasForeignKey(d => d.NotificationCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationSubCategory_NotificationCategory");
            });

            modelBuilder.Entity<NotificationSubCategoryReference>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NotificationSubCategoryReference");

                entity.Property(e => e.NotificationSubCategoryId).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NotificationType>(entity =>
            {
                entity.Property(e => e.NotificationTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.NotificationGroup)
                    .WithMany(p => p.NotificationType)
                    .HasForeignKey(d => d.NotificationGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationType_NotificationGroup");

                entity.HasOne(d => d.NotificationSubCategory)
                    .WithMany(p => p.NotificationType)
                    .HasForeignKey(d => d.NotificationSubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationType_NotificationSubCategory");
            });

            modelBuilder.Entity<NotificationUser>(entity =>
            {
                entity.HasIndex(e => new { e.NotificationUserId, e.NotificationId, e.Read, e.UserId, e.IsDeleted })
                    .HasName("IX_NotificationUser_UserId_IsDeleted");

                entity.Property(e => e.NotificationUserId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.NotificationUser)
                    .HasForeignKey(d => d.NotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationUser_Notification");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NotificationUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationUser_User");
            });

            //modelBuilder.Entity<OneTimeToken>(entity =>
            //{
            //    EntityTypeBuilder.Ignore

            //    entity.HasNoKey();

            //    entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

            //    entity.Property(e => e.TokenType)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.HasOne(d => d.CreatedByUser)
            //        .WithMany(p => p.OneTimeToken)
            //        .HasForeignKey(d => d.CreatedByUserId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_OneTimeToken_User");
            //});

            modelBuilder.Entity<OrrDoctorInformation>(entity =>
            {
                entity.Property(e => e.OrrDoctorInformationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.NumberAndStreet).IsRequired();

                entity.Property(e => e.PostCode).IsRequired();

                entity.Property(e => e.RegisterNumber).IsRequired();
            });

            modelBuilder.Entity<PlannedInteractionType>(entity =>
            {
                entity.Property(e => e.PlannedInteractionTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.IpadRequiresActualCompletionDate)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<Platform>(entity =>
            {
                entity.Property(e => e.PlatformId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<PrivateTeam>(entity =>
            {
                entity.Property(e => e.PrivateTeamId).ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.PrivateTeamNavigation)
                    .WithOne(p => p.PrivateTeam)
                    .HasForeignKey<PrivateTeam>(d => d.PrivateTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrivateTeam_User");
            });

            modelBuilder.Entity<RailheadCondition>(entity =>
            {
                entity.Property(e => e.RailheadConditionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<RollingStockAuthorisedToOperate>(entity =>
            {
                entity.HasIndex(e => new { e.UserCompanyRoleId, e.IsDeleted });

                entity.Property(e => e.RollingStockAuthorisedToOperateId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.RollingStockAuthorisedToOperate)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RollingStockAuthorisedToOperate_Company");

                entity.HasOne(d => d.Traction)
                    .WithMany(p => p.RollingStockAuthorisedToOperate)
                    .HasForeignKey(d => d.TractionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RollingStockAuthorisedToOperate_Traction");

                entity.HasOne(d => d.UserCompanyRole)
                    .WithMany(p => p.RollingStockAuthorisedToOperate)
                    .HasForeignKey(d => d.UserCompanyRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RollingStockAuthorisedToOperate_UserCompanyRole");
            });

            modelBuilder.Entity<RollingStockAuthorisedToOperateSigningHistory>(entity =>
            {
                entity.Property(e => e.RollingStockAuthorisedToOperateSigningHistoryId).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RenewedDateTime).HasColumnType("datetime");

                entity.Property(e => e.SignedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.RollingStockAuthorisedToOperateSigningHistoryModifiedByUser)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RollingStockAuthorisedToOperateSigningHistory_RollingStockSigningModifiedByUser");

                entity.HasOne(d => d.RollingStockAuthorisedToOperate)
                    .WithMany(p => p.RollingStockAuthorisedToOperateSigningHistory)
                    .HasForeignKey(d => d.RollingStockAuthorisedToOperateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RollingStockAuthorisedToOperateSigningHistory_RollingStockAuthorisedToOperate");

                entity.HasOne(d => d.SignedByUser)
                    .WithMany(p => p.RollingStockAuthorisedToOperateSigningHistorySignedByUser)
                    .HasForeignKey(d => d.SignedByUserId)
                    .HasConstraintName("FK_RollingStockAuthorisedToOperateSigningHistory_RollingStockSigningSignedByUser");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.Property(e => e.RouteId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Route)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Route_Company");

                entity.HasOne(d => d.DurationUnit)
                    .WithMany(p => p.Route)
                    .HasForeignKey(d => d.DurationUnitId)
                    .HasConstraintName("FK_DurationUnit_Route");
            });

            modelBuilder.Entity<SafetyBrief>(entity =>
            {
                entity.Property(e => e.SafetyBriefId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SafetyBrief)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SafetyBrief_Company");
            });

            modelBuilder.Entity<SafetyBriefingType>(entity =>
            {
                entity.Property(e => e.SafetyBriefingTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<SafetyOrganisation>(entity =>
            {
                entity.Property(e => e.SafetyOrganisationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.SafetyOrganisation)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_SafetyOrganisation_Country");
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.SchemaVersion)
                    .HasName("PK__Schema__04D490DB43B6E2FD");

                entity.ToTable("Schema", "SignalR");

                entity.Property(e => e.SchemaVersion).ValueGeneratedNever();
            });

            modelBuilder.Entity<SchemaVersions>(entity =>
            {
                entity.Property(e => e.Applied).HasColumnType("datetime");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.SkillId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Skill)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skill_Company");

                entity.HasOne(d => d.CompanyRole)
                    .WithMany(p => p.Skill)
                    .HasForeignKey(d => d.CompanyRoleId)
                    .HasConstraintName("FK_Skill_CompanyRole");

                entity.HasOne(d => d.DurationUnit)
                    .WithMany(p => p.Skill)
                    .HasForeignKey(d => d.DurationUnitId)
                    .HasConstraintName("FK_Skill_DurationUnit");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.Skill)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skill_ModifiedByUser");
            });

            modelBuilder.Entity<SpeedRestrictionType>(entity =>
            {
                entity.Property(e => e.SpeedRestrictionTypeId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<SupportLevel>(entity =>
            {
                entity.Property(e => e.SupportLevelId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupportLevel)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportLevel_Company");
            });

            modelBuilder.Entity<SupportPlan>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.IsDeleted });

                entity.HasIndex(e => new { e.CompanyId, e.UserId, e.IsDeleted, e.DateCreated });

                entity.HasIndex(e => new { e.UserId, e.SupportPlanTypeId, e.ModifiedDate, e.IsDeleted, e.DateCreated })
                    .HasName("IX_SupportPlan_DateCreated");

                entity.Property(e => e.SupportPlanId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.PeriodActualCompletionDate).HasColumnType("datetime");

                entity.Property(e => e.PeriodExpectedCompletionDate).HasColumnType("datetime");

                entity.Property(e => e.PeriodStartDate).HasColumnType("datetime");

                entity.Property(e => e.RequiresEmployeeSignatureToComplete)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StartedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ArchivedByUser)
                    .WithMany(p => p.SupportPlanArchivedByUser)
                    .HasForeignKey(d => d.ArchivedByUserId)
                    .HasConstraintName("FK_SupportPlan_SupportPlanArchivedByUser");

                entity.HasOne(d => d.AssessorVerificationResponse)
                    .WithMany(p => p.SupportPlan)
                    .HasForeignKey(d => d.AssessorVerificationResponseId)
                    .HasConstraintName("FK_SupportPlan_AssessorVerificationResponse");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupportPlan)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlan_Company");

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany(p => p.SupportPlanCreatedByUser)
                    .HasForeignKey(d => d.CreatedByUserId)
                    .HasConstraintName("FK_SupportPlan_SupportPlanCreatedByUser");

                entity.HasOne(d => d.DepotAreaManagerJustification)
                    .WithMany(p => p.SupportPlanDepotAreaManagerJustification)
                    .HasForeignKey(d => d.DepotAreaManagerJustificationId)
                    .HasConstraintName("FK_SupportPlan_DepotAreaManagerJustification");

                entity.HasOne(d => d.IncidentType)
                    .WithMany(p => p.SupportPlan)
                    .HasForeignKey(d => d.IncidentTypeId)
                    .HasConstraintName("FK_SupportPlan_IncidentType");

                entity.HasOne(d => d.OperationalStandardsManagerJustification)
                    .WithMany(p => p.SupportPlanOperationalStandardsManagerJustification)
                    .HasForeignKey(d => d.OperationalStandardsManagerJustificationId)
                    .HasConstraintName("FK_SupportPlan_OperationalStandardsManagerJustification");

                entity.HasOne(d => d.SupportLevel)
                    .WithMany(p => p.SupportPlan)
                    .HasForeignKey(d => d.SupportLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlan_SupportPlanSupportLevel");

                entity.HasOne(d => d.SupportPlanOperationalIncidentType)
                    .WithMany(p => p.SupportPlan)
                    .HasForeignKey(d => d.SupportPlanOperationalIncidentTypeId)
                    .HasConstraintName("FK_SupportPlan_SupportPlanOperationalIncidentType");

                entity.HasOne(d => d.SupportPlanType)
                    .WithMany(p => p.SupportPlan)
                    .HasForeignKey(d => d.SupportPlanTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlan_SupportPlanType");

                entity.HasOne(d => d.UserCompanyRole)
                    .WithMany(p => p.SupportPlan)
                    .HasForeignKey(d => d.UserCompanyRoleId)
                    .HasConstraintName("FK_SupportPlan_UserCompanyRole");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SupportPlanUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlan_SupportPlanUser");

                entity.HasOne(d => d.VerificationStatus)
                    .WithMany(p => p.SupportPlan)
                    .HasForeignKey(d => d.VerificationStatusId)
                    .HasConstraintName("FK_SupportPlan_VerificationStatus");

                entity.HasOne(d => d.VerifiedByUser)
                    .WithMany(p => p.SupportPlanVerifiedByUser)
                    .HasForeignKey(d => d.VerifiedByUserId)
                    .HasConstraintName("FK_SupportPlan_SupportPlanVerifier");
            });

            modelBuilder.Entity<SupportPlanAimObjective>(entity =>
            {
                entity.Property(e => e.SupportPlanAimObjectiveId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupportPlanAimObjective)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanAimObjective_Company");

                entity.HasOne(d => d.SupportPlan)
                    .WithMany(p => p.SupportPlanAimObjective)
                    .HasForeignKey(d => d.SupportPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanAimObjective_SupportPlan");
            });

            modelBuilder.Entity<SupportPlanApproval>(entity =>
            {
                entity.HasIndex(e => new { e.SupportPlanApprovalUserId, e.SupportPlanApprovalTypeId, e.IsDeleted })
                    .HasName("IX_SupportPlanApproval")
                    .IsUnique()
                    .HasFilter("([IsDeleted]=(0))");

                entity.Property(e => e.SupportPlanApprovalId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.HasOne(d => d.SupportPlanApprovalType)
                    .WithMany(p => p.SupportPlanApproval)
                    .HasForeignKey(d => d.SupportPlanApprovalTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanApproval_SupportPlanApprovalType");

                entity.HasOne(d => d.SupportPlanApprovalUser)
                    .WithMany(p => p.SupportPlanApproval)
                    .HasForeignKey(d => d.SupportPlanApprovalUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanApproval_SupportPlanApprovalUser");
            });

            modelBuilder.Entity<SupportPlanApprovalType>(entity =>
            {
                entity.Property(e => e.SupportPlanApprovalTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<SupportPlanApprovalUser>(entity =>
            {
                entity.HasIndex(e => new { e.SupportPlanId, e.UserId, e.IsDeleted })
                    .HasName("IX_SupportPlanApprovalUser")
                    .IsUnique()
                    .HasFilter("([IsDeleted]=(0))");

                entity.Property(e => e.SupportPlanApprovalUserId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.SupportPlan)
                    .WithMany(p => p.SupportPlanApprovalUser)
                    .HasForeignKey(d => d.SupportPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlan_User");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SupportPlanApprovalUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanApprovalUser_User");
            });

            modelBuilder.Entity<SupportPlanCurrentSupportPlanType>(entity =>
            {
                entity.Property(e => e.SupportPlanCurrentSupportPlanTypeId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupportPlanCurrentSupportPlanType)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanCurrentSupportPlanType_Company");

                entity.HasOne(d => d.SupportPlan)
                    .WithMany(p => p.SupportPlanCurrentSupportPlanType)
                    .HasForeignKey(d => d.SupportPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanCurrentSupportPlanType_SupportPlan");

                entity.HasOne(d => d.SupportPlanType)
                    .WithMany(p => p.SupportPlanCurrentSupportPlanType)
                    .HasForeignKey(d => d.SupportPlanTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanCurrentSupportPlanType_SupportPlanType");
            });

            modelBuilder.Entity<SupportPlanDocument>(entity =>
            {
                entity.Property(e => e.SupportPlanDocumentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupportPlanDocument)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanDocument_Company");

                entity.HasOne(d => d.SupportPlan)
                    .WithMany(p => p.SupportPlanDocument)
                    .HasForeignKey(d => d.SupportPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanDocument_SupportPlan");
            });

            modelBuilder.Entity<SupportPlanIncident>(entity =>
            {
                entity.HasIndex(e => new { e.SupportPlanId, e.IncidentId })
                    .HasName("IX_SupportPlanIncident")
                    .IsUnique()
                    .HasFilter("([IsDeleted]=(0))");

                entity.Property(e => e.SupportPlanIncidentId).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany(p => p.SupportPlanIncident)
                    .HasForeignKey(d => d.CreatedByUserId)
                    .HasConstraintName("FK_SupportPlanIncident_CreatedByUser");

                entity.HasOne(d => d.Incident)
                    .WithMany(p => p.SupportPlanIncident)
                    .HasForeignKey(d => d.IncidentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanIncident_Incident");

                entity.HasOne(d => d.SupportPlan)
                    .WithMany(p => p.SupportPlanIncident)
                    .HasForeignKey(d => d.SupportPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanIncident_SupportPlan");
            });

            modelBuilder.Entity<SupportPlanInteraction>(entity =>
            {
                entity.Property(e => e.SupportPlanInteractionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActualCompletionDate).HasColumnType("datetime");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.ExpectedCompletionDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.ArchivedByUser)
                    .WithMany(p => p.SupportPlanInteraction)
                    .HasForeignKey(d => d.ArchivedByUserId)
                    .HasConstraintName("FK_SupportPlanInteraction_ArchivedByUser");

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.SupportPlanInteraction)
                    .HasForeignKey(d => d.AssessmentId)
                    .HasConstraintName("FK_SupportPlanInteraction_Assessment");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupportPlanInteraction)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanInteraction_Company");

                entity.HasOne(d => d.PlannedInteractionType)
                    .WithMany(p => p.SupportPlanInteraction)
                    .HasForeignKey(d => d.PlannedInteractionTypeId)
                    .HasConstraintName("FK_SupportPlanInteraction_PlannedInteractionType");

                entity.HasOne(d => d.SupportPlan)
                    .WithMany(p => p.SupportPlanInteraction)
                    .HasForeignKey(d => d.SupportPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanInteraction_SupportPlan");
            });

            modelBuilder.Entity<SupportPlanManagerJustification>(entity =>
            {
                entity.Property(e => e.SupportPlanManagerJustificationId).ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupportPlanManagerJustification)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanManagerJustification_Company");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.SupportPlanManagerJustification)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_SupportPlanManagerJustification_Manager");

                entity.HasOne(d => d.SupportPlanManagerRecommendation)
                    .WithMany(p => p.SupportPlanManagerJustification)
                    .HasForeignKey(d => d.SupportPlanManagerRecommendationId)
                    .HasConstraintName("FK_SupportPlanManagerJustification_SupportPlanManagerRecommendation");
            });

            modelBuilder.Entity<SupportPlanManagerRecommendation>(entity =>
            {
                entity.Property(e => e.SupportPlanManagerRecommendationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<SupportPlanNote>(entity =>
            {
                entity.Property(e => e.SupportPlanNoteId).ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.AddedByUser)
                    .WithMany(p => p.SupportPlanNote)
                    .HasForeignKey(d => d.AddedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanNote_User");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupportPlanNote)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanNote_Company");

                entity.HasOne(d => d.SupportPlan)
                    .WithMany(p => p.SupportPlanNote)
                    .HasForeignKey(d => d.SupportPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanNote_SupportPlan");
            });

            modelBuilder.Entity<SupportPlanOperationalIncidentType>(entity =>
            {
                entity.Property(e => e.SupportPlanOperationalIncidentTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<SupportPlanSignature>(entity =>
            {
                entity.HasIndex(e => new { e.SupportPlanId, e.SupportPlanApprovalTypeId })
                    .HasName("IX_SupportPlanSignatureType")
                    .IsUnique();

                entity.Property(e => e.SupportPlanSignatureId).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupportPlanSignature)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanSignature_Company");

                entity.HasOne(d => d.SupportPlanApprovalType)
                    .WithMany(p => p.SupportPlanSignature)
                    .HasForeignKey(d => d.SupportPlanApprovalTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanSignature_SupportPlanApprovalType");

                entity.HasOne(d => d.SupportPlan)
                    .WithMany(p => p.SupportPlanSignature)
                    .HasForeignKey(d => d.SupportPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanSignature_SupportPlan");
            });

            modelBuilder.Entity<SupportPlanType>(entity =>
            {
                entity.Property(e => e.SupportPlanTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<SupportPlanVerificationStatement>(entity =>
            {
                entity.Property(e => e.SupportPlanVerificationStatementId).ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupportPlanVerificationStatement)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanVerificationStatement_Company");

                entity.HasOne(d => d.SupportPlan)
                    .WithMany(p => p.SupportPlanVerificationStatement)
                    .HasForeignKey(d => d.SupportPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanVerificationStatement_SupportPlan");

                entity.HasOne(d => d.VerificationStatement)
                    .WithMany(p => p.SupportPlanVerificationStatement)
                    .HasForeignKey(d => d.VerificationStatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportPlanVerificationStatement_VerificationStatement");

                entity.HasOne(d => d.VerificationStatementRating)
                    .WithMany(p => p.SupportPlanVerificationStatement)
                    .HasForeignKey(d => d.VerificationStatementRatingId)
                    .HasConstraintName("FK_SupportPlanVerificationStatement_VerificationStatementRating");
            });

            modelBuilder.Entity<SystemRole>(entity =>
            {
                entity.Property(e => e.SystemRoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.TaskId).ValueGeneratedNever();

                entity.Property(e => e.NextProcessDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TaskStatus>(entity =>
            {
                entity.Property(e => e.TaskStatusId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.TeamId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.MakeAvailableOnIpad)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();

                entity.HasOne(d => d.BaseLocation)
                    .WithMany(p => p.Team)
                    .HasForeignKey(d => d.BaseLocationId)
                    .HasConstraintName("FK_Team_Location");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Team)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Team_Company");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Team)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Team_Department");
            });

            modelBuilder.Entity<TeamOwner>(entity =>
            {
                entity.Property(e => e.TeamOwnerId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TeamOwner)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamOwner_Company");

                entity.HasOne(d => d.OwnerUser)
                    .WithMany(p => p.TeamOwner)
                    .HasForeignKey(d => d.OwnerUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamOwner_User");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamOwner)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamOwner_Team");
            });

            modelBuilder.Entity<Traction>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyId, e.Code })
                    .IsUnique()
                    .HasFilter("([Code] IS NOT NULL AND [IsDeleted]=(0))");

                entity.HasIndex(e => new { e.Name, e.ModifiedDate, e.CompanyId, e.IsDeleted })
                    .HasName("IX_Traction_CompanyId_IsDeleted");

                entity.Property(e => e.TractionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(255);

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Traction)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Traction_Company");

                entity.HasOne(d => d.DurationUnit)
                    .WithMany(p => p.Traction)
                    .HasForeignKey(d => d.DurationUnitId)
                    .HasConstraintName("FK_DurationUnit_Traction");
            });

            modelBuilder.Entity<Training>(entity =>
            {
                entity.Property(e => e.TrainingId).ValueGeneratedNever();

                entity.Property(e => e.CourseNo)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.ValidFromDateTime).HasColumnType("datetime");

                entity.Property(e => e.ValidToDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ArchivedByUser)
                    .WithMany(p => p.TrainingArchivedByUser)
                    .HasForeignKey(d => d.ArchivedByUserId)
                    .HasConstraintName("FK_User_Training_ArchivedByUser");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Training)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_Training");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.TrainingModifiedByUser)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Training_TrainingModifiedByUser");

                entity.HasOne(d => d.TrainingTemplate)
                    .WithMany(p => p.Training)
                    .HasForeignKey(d => d.TrainingTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Training_TrainingTemplate");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TrainingUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Training_TrainingUser");
            });

            modelBuilder.Entity<TrainingClassroom>(entity =>
            {
                entity.Property(e => e.TrainingClassroomId).ValueGeneratedNever();

                entity.HasOne(d => d.TrainingClassroomNavigation)
                    .WithOne(p => p.TrainingClassroom)
                    .HasForeignKey<TrainingClassroom>(d => d.TrainingClassroomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingClassroom_Training");
            });

            modelBuilder.Entity<TrainingDocument>(entity =>
            {
                entity.Property(e => e.TrainingDocumentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TrainingDocument)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingDocument_Company");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.TrainingDocument)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingDocument_ModifiedByUser");

                entity.HasOne(d => d.Training)
                    .WithMany(p => p.TrainingDocument)
                    .HasForeignKey(d => d.TrainingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingDocument_Training");
            });

            modelBuilder.Entity<TrainingPracticalDriving>(entity =>
            {
                entity.Property(e => e.TrainingPracticalDrivingId).ValueGeneratedNever();

                entity.Property(e => e.InstructorName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Traction)
                    .WithMany(p => p.TrainingPracticalDriving)
                    .HasForeignKey(d => d.TractionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingPracticalDriving_Traction");

                entity.HasOne(d => d.TrainingPracticalDrivingNavigation)
                    .WithOne(p => p.TrainingPracticalDriving)
                    .HasForeignKey<TrainingPracticalDriving>(d => d.TrainingPracticalDrivingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingPracticalDriving_Training");
            });

            modelBuilder.Entity<TrainingPracticalGeneral>(entity =>
            {
                entity.Property(e => e.TrainingPracticalGeneralId).ValueGeneratedNever();

                entity.Property(e => e.InstructorName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.TrainingPracticalGeneral)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingPracticalGeneral_Location");

                entity.HasOne(d => d.TrainingPracticalGeneralNavigation)
                    .WithOne(p => p.TrainingPracticalGeneral)
                    .HasForeignKey<TrainingPracticalGeneral>(d => d.TrainingPracticalGeneralId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingPracticalGeneral_Training");
            });

            modelBuilder.Entity<TrainingTemplate>(entity =>
            {
                entity.HasIndex(e => new { e.BaseTrainingTemplateId, e.IsArchived })
                    .HasName("IX_TrainingTemplate")
                    .IsUnique()
                    .HasFilter("([IsArchived]=(0))");

                entity.Property(e => e.TrainingTemplateId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CourseNo)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.ArchivedByUser)
                    .WithMany(p => p.TrainingTemplateArchivedByUser)
                    .HasForeignKey(d => d.ArchivedByUserId)
                    .HasConstraintName("FK_TrainingTemplate_TrainingTemplatesArchived");

                entity.HasOne(d => d.BaseTrainingTemplate)
                    .WithMany(p => p.InverseBaseTrainingTemplate)
                    .HasForeignKey(d => d.BaseTrainingTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingTemplate_BaseTrainingTemplate");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TrainingTemplate)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingTemplate_Company");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.TrainingTemplateModifiedByUser)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingTemplate_TrainingTemplatesModified");

                entity.HasOne(d => d.ValidForUnit)
                    .WithMany(p => p.TrainingTemplate)
                    .HasForeignKey(d => d.ValidForUnitId)
                    .HasConstraintName("FK_TrainingTemplate_ValidForDurationUnit");
            });

            modelBuilder.Entity<TrainingTemplateClassroom>(entity =>
            {
                entity.Property(e => e.TrainingTemplateClassroomId).ValueGeneratedNever();

                entity.HasOne(d => d.TrainingTemplateClassroomNavigation)
                    .WithOne(p => p.TrainingTemplateClassroom)
                    .HasForeignKey<TrainingTemplateClassroom>(d => d.TrainingTemplateClassroomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingTemplateClassroom_TrainingTemplate");
            });

            modelBuilder.Entity<TrainingTemplateDocument>(entity =>
            {
                entity.Property(e => e.TrainingTemplateDocumentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TrainingTemplateDocument)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingTemplateDocument_Company");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.TrainingTemplateDocument)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingTemplateDocument_ModifiedByUser");

                entity.HasOne(d => d.TrainingTemplate)
                    .WithMany(p => p.TrainingTemplateDocument)
                    .HasForeignKey(d => d.TrainingTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingTemplateDocument_TrainingTemplate");
            });

            modelBuilder.Entity<TrainingTemplatePracticalDriving>(entity =>
            {
                entity.Property(e => e.TrainingTemplatePracticalDrivingId).ValueGeneratedNever();

                entity.Property(e => e.InstructorName).HasMaxLength(200);

                entity.HasOne(d => d.Traction)
                    .WithMany(p => p.TrainingTemplatePracticalDriving)
                    .HasForeignKey(d => d.TractionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingTemplatePracticalDriving_Traction");

                entity.HasOne(d => d.TrainingTemplatePracticalDrivingNavigation)
                    .WithOne(p => p.TrainingTemplatePracticalDriving)
                    .HasForeignKey<TrainingTemplatePracticalDriving>(d => d.TrainingTemplatePracticalDrivingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingTemplatePracticalDriving_TrainingTemplate");
            });

            modelBuilder.Entity<TrainingTemplatePracticalGeneral>(entity =>
            {
                entity.Property(e => e.TrainingTemplatePracticalGeneralId).ValueGeneratedNever();

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.TrainingTemplatePracticalGeneral)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingTemplatePracticalGeneral_Location");

                entity.HasOne(d => d.TrainingTemplatePracticalGeneralNavigation)
                    .WithOne(p => p.TrainingTemplatePracticalGeneral)
                    .HasForeignKey<TrainingTemplatePracticalGeneral>(d => d.TrainingTemplatePracticalGeneralId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingTemplatePracticalGeneral_TrainingTemplate");
            });

            modelBuilder.Entity<TrainingTemplateSkill>(entity =>
            {
                entity.Property(e => e.TrainingTemplateSkillId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TrainingTemplateSkill)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingTemplateSkill_Company");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.TrainingTemplateSkill)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingTemplateSkill_ModifiedByUser");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.TrainingTemplateSkill)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingTemplateSkill_Skill");

                entity.HasOne(d => d.TrainingTemplate)
                    .WithMany(p => p.TrainingTemplateSkill)
                    .HasForeignKey(d => d.TrainingTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingTemplateSkill_TrainingTemplate");
            });

            modelBuilder.Entity<UnderfootCondition>(entity =>
            {
                entity.Property(e => e.UnderfootConditionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.DepartmentId);

                entity.HasIndex(e => e.LoweredUsername)
                    .HasName("IX_LoweredUsername")
                    .IsUnique()
                    .HasFilter("([IsDeleted]=(0))");

                entity.HasIndex(e => e.Username)
                    .HasName("IX_Username")
                    .IsUnique()
                    .HasFilter("([IsDeleted]=(0))");

                entity.HasIndex(e => new { e.CompanyId, e.SystemRoleId, e.DepartmentId })
                    .HasName("IX_User_CompanyId_FullName");

                entity.HasIndex(e => new { e.UserId, e.CompanyId, e.IsDeleted })
                    .HasName("IX_User_IsDeleted");

                entity.HasIndex(e => new { e.UserId, e.CompanyId, e.ModifiedDate, e.IsDeleted, e.CreatedDate })
                    .HasName("IX_User_CreatedDate");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.Forename).IsRequired();

                entity.Property(e => e.FullName).IsRequired();

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDateMobile).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangeDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUsername).IsRequired();

                entity.Property(e => e.MobileNumber).HasMaxLength(20);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.SsopasswordHash)
                    .IsRequired()
                    .HasColumnName("SSOPasswordHash")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Surname).IsRequired();

                entity.Property(e => e.TimeManagementEmailRequestDateTime).HasColumnType("datetime");

                entity.Property(e => e.TwoFaenabled).HasColumnName("TwoFAEnabled");

                entity.Property(e => e.TwoFarecoveryToken)
                    .HasColumnName("TwoFARecoveryToken")
                    .HasMaxLength(255);

                entity.Property(e => e.TwoFarecoveryTokenSalt)
                    .HasColumnName("TwoFARecoveryTokenSalt")
                    .HasMaxLength(255);

                entity.Property(e => e.TwoFasecret)
                    .HasColumnName("TwoFASecret")
                    .HasMaxLength(255);

                entity.Property(e => e.Username).IsRequired();

                entity.Property(e => e.YouWelcomeEmailRequestDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_User_Company");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.UserDepartment)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_MainDepartment");

                entity.HasOne(d => d.RosteringDepartment)
                    .WithMany(p => p.UserRosteringDepartment)
                    .HasForeignKey(d => d.RosteringDepartmentId)
                    .HasConstraintName("FK_User_Department_RosteringDepartment");

                entity.HasOne(d => d.SystemRole)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.SystemRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_SystemRole");

                entity.HasOne(d => d.UserNavigation)
                    .WithOne(p => p.User)
                    .HasForeignKey<User>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProfile_User");

                entity.HasOne(d => d.YouRole)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.YouRoleId)
                    .HasConstraintName("FK_User_YouRole");
            });

            modelBuilder.Entity<UserApiSyncTime>(entity =>
            {
                entity.Property(e => e.UserApiSyncTimeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ParseEndDate).HasColumnType("datetime");

                entity.Property(e => e.ParseStartDate).HasColumnType("datetime");

                entity.Property(e => e.SyncEndDate).HasColumnType("datetime");

                entity.Property(e => e.SyncStartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserApiSyncTime)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserApiSyncTime_Company");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserApiSyncTime)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserApiSyncTime_User");
            });

            modelBuilder.Entity<UserAuthorityToWorkStatus>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.ModifiedDate });

                entity.Property(e => e.UserAuthorityToWorkStatusId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserAuthorityToWorkStatus)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAuthorityToWorkStatus_Company");

                entity.HasOne(d => d.EmployeeAuthorityToWorkStatus)
                    .WithMany(p => p.UserAuthorityToWorkStatus)
                    .HasForeignKey(d => d.EmployeeAuthorityToWorkStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAuthorityToWorkStatus_EmployeeAuthorityToWorkStatus");

                entity.HasOne(d => d.UpdatedByUser)
                    .WithMany(p => p.UserAuthorityToWorkStatusUpdatedByUser)
                    .HasForeignKey(d => d.UpdatedByUserId)
                    .HasConstraintName("FK_UserAuthorityToWorkStatusesUpdated_UpdatedByUser");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAuthorityToWorkStatusUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAuthorityToWorkStatus_UserAuthorityToWorkStatusUser");
            });

            modelBuilder.Entity<UserCertificateFile>(entity =>
            {
                entity.Property(e => e.UserCertificateFileId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.DisplayName).IsRequired();

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserCertificateFile)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCertificateFile_Company");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCertificateFile)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCertificateFile_User");
            });

            modelBuilder.Entity<UserCompanyRole>(entity =>
            {
                entity.HasIndex(e => new { e.CompetencyCycleId, e.IsDeleted });

                entity.HasIndex(e => new { e.UserId, e.CompetencyCycleId })
                    .HasName("UserCompanyRole_CompetencyCycle")
                    .IsUnique()
                    .HasFilter("([IsDeleted]=(0))");

                entity.HasIndex(e => new { e.UserCompanyRoleId, e.CompanyId, e.CompanyRoleId, e.CompetencyCycleId, e.CompetencyCycleStartDate, e.CompetencyCycleEndDate, e.ModifiedDate, e.IsDeleted, e.DateCreated, e.UserId })
                    .HasName("IX_UserCompanyRole_UserId");

                entity.Property(e => e.UserCompanyRoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompetencyCycleEndDate).HasColumnType("datetime");

                entity.Property(e => e.CompetencyCycleStartDate).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserCompanyRole)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCompanyRole_Company");

                entity.HasOne(d => d.CompanyRole)
                    .WithMany(p => p.UserCompanyRole)
                    .HasForeignKey(d => d.CompanyRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCompanyRole_CompanyRole");

                entity.HasOne(d => d.CompetencyCycle)
                    .WithMany(p => p.UserCompanyRole)
                    .HasForeignKey(d => d.CompetencyCycleId)
                    .HasConstraintName("FK_UserCompanyRole_CompetencyCycle");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCompanyRole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCompanyRole_UserCompanyRoleUser");
            });

            modelBuilder.Entity<UserCompanyRoleArchive>(entity =>
            {
                entity.Property(e => e.UserCompanyRoleArchiveId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompetencyCycleEndDate).HasColumnType("datetime");

                entity.Property(e => e.CompetencyCycleStartDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.RecertificationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserCompanyRoleArchive)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCompanyRoleArchive_Company");

                entity.HasOne(d => d.CompanyRole)
                    .WithMany(p => p.UserCompanyRoleArchive)
                    .HasForeignKey(d => d.CompanyRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCompanyRoleArchive_CompanyRole");

                entity.HasOne(d => d.CompetencyCycle)
                    .WithMany(p => p.UserCompanyRoleArchive)
                    .HasForeignKey(d => d.CompetencyCycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCompanyRoleArchive_CompetencyCycle");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCompanyRoleArchive)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCompanyRoleArchive_User");
            });

            modelBuilder.Entity<UserCompanyRoleDateOfProductiveDuty>(entity =>
            {
                entity.HasIndex(e => new { e.UserCompanyRoleId, e.ModifiedDate });

                entity.Property(e => e.UserCompanyRoleDateOfProductiveDutyId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateOfFirstProductiveDutyOverride).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.UpdatedByUser)
                    .WithMany(p => p.UserCompanyRoleDateOfProductiveDuty)
                    .HasForeignKey(d => d.UpdatedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCompanyRoleDateOfProductiveDuty_UpdatedByUser");

                entity.HasOne(d => d.UserCompanyRole)
                    .WithMany(p => p.UserCompanyRoleDateOfProductiveDuty)
                    .HasForeignKey(d => d.UserCompanyRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCompanyRoleDateOfProductiveDuty_UserCompanyRole");
            });

            modelBuilder.Entity<UserCompanyRoleRecertificationDate>(entity =>
            {
                entity.Property(e => e.UserCompanyRoleRecertificationDateId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.RecertificationDate).HasColumnType("datetime");

                entity.HasOne(d => d.UpdatedByUser)
                    .WithMany(p => p.UserCompanyRoleRecertificationDate)
                    .HasForeignKey(d => d.UpdatedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCompanyRoleRecertificationDate_UserId");

                entity.HasOne(d => d.UserCompanyRole)
                    .WithMany(p => p.UserCompanyRoleRecertificationDate)
                    .HasForeignKey(d => d.UserCompanyRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCompanyRoleRecertificationDate_UserCompanyRole");
            });

            modelBuilder.Entity<UserDepartmentAccess>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.IsDeleted });

                entity.HasIndex(e => new { e.CompanyId, e.UserId, e.IsDeleted });

                entity.Property(e => e.UserDepartmentAccessId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserDepartmentAccess)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDepartmentAccess_Company");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.UserDepartmentAccess)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDepartmentAccess_Department");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDepartmentAccess)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDepartmentAccess_UserDepartmentAccessUser");
            });

            modelBuilder.Entity<UserEndedCompetencyCycle>(entity =>
            {
                entity.Property(e => e.UserEndedCompetencyCycleId).ValueGeneratedNever();

                entity.Property(e => e.DateEnded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserEndedCompetencyCycle)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserEndedCompetencyCycle_UserCompany");

                entity.HasOne(d => d.CompetencyCycle)
                    .WithMany(p => p.UserEndedCompetencyCycle)
                    .HasForeignKey(d => d.CompetencyCycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserEndedCompetencyCycle_CompetencyCycle");

                entity.HasOne(d => d.EndedByUser)
                    .WithMany(p => p.UserEndedCompetencyCycleEndedByUser)
                    .HasForeignKey(d => d.EndedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserEndedCompetencyCycle_EndedByUser");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserEndedCompetencyCycleUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserEndedCompetencyCycle_UserCompetencyOwner");
            });

            modelBuilder.Entity<UserFileAccess>(entity =>
            {
                entity.HasIndex(e => new { e.UserFileAccessId, e.Filename, e.ContainerName, e.BaseAccessUrl, e.SasToken, e.ExpiryDate, e.UserId })
                    .HasName("IX_UserFileAccess_UserId");

                entity.Property(e => e.UserFileAccessId).ValueGeneratedNever();

                entity.Property(e => e.BaseAccessUrl)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.ContainerName)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.SasToken).HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFileAccess)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFileAccess_User");
            });

            modelBuilder.Entity<UserFileNote>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyId, e.UserId, e.IsDeleted });

                entity.Property(e => e.UserFileNoteId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateFollowedUp).HasColumnType("datetime");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.FollowUpDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserFileNote)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFileNote_Company");

                entity.HasOne(d => d.FollowedUpByUser)
                    .WithMany(p => p.UserFileNoteFollowedUpByUser)
                    .HasForeignKey(d => d.FollowedUpByUserId)
                    .HasConstraintName("FK_UserFileNote_FollowedUpByUser");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFileNoteUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFileNote_UserFileNoteUser");
            });

            modelBuilder.Entity<UserFileNoteDocument>(entity =>
            {
                entity.HasIndex(e => new { e.UserFileNoteDocumentId, e.DisplayFileName, e.StorageFileName, e.FileMimeType, e.FileSizeBytes, e.UserFileNoteId })
                    .HasName("IX_UserFileNoteDocument_UserFileNoteId");

                entity.Property(e => e.UserFileNoteDocumentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DisplayFileName)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.FileMimeType)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.StorageFileName)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserFileNoteDocument)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFileNoteDocument_Company");

                entity.HasOne(d => d.UserFileNote)
                    .WithMany(p => p.UserFileNoteDocument)
                    .HasForeignKey(d => d.UserFileNoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFileNoteDocument_UserFileNote");
            });

            modelBuilder.Entity<UserMedicalDetail>(entity =>
            {
                entity.HasIndex(e => new { e.MedicalAssessmentDetailId, e.DateCreated });

                entity.HasIndex(e => new { e.UserId, e.IsDeleted });

                entity.HasIndex(e => new { e.CompanyId, e.UserId, e.IsDeleted, e.IsArchived });

                entity.Property(e => e.UserMedicalDetailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateOfReview).HasColumnType("datetime");

                entity.Property(e => e.GeneralHealthSummary).IsRequired();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.OrrRegistrationNumber).IsRequired();

                entity.Property(e => e.OverrideNextAssessmentDate).HasColumnType("datetime");

                entity.HasOne(d => d.ArchivedByUser)
                    .WithMany(p => p.UserMedicalDetailArchivedByUser)
                    .HasForeignKey(d => d.ArchivedByUserId)
                    .HasConstraintName("FK_UserMedicalDetail_UserMedicalDetailArchivedByUser");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserMedicalDetail)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalDetail_Company");

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany(p => p.UserMedicalDetailCreatedByUser)
                    .HasForeignKey(d => d.CreatedByUserId)
                    .HasConstraintName("FK_UserMedicalDetail_UserMedicalDetailCreatedByUser");

                entity.HasOne(d => d.DrugsAndAlcoholAssessment)
                    .WithMany(p => p.UserMedicalDetail)
                    .HasForeignKey(d => d.DrugsAndAlcoholAssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalAssessment_DrugsAndAlcoholAssessment");

                entity.HasOne(d => d.HearingAssessment)
                    .WithMany(p => p.UserMedicalDetail)
                    .HasForeignKey(d => d.HearingAssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalAssessment_HearingAssessment");

                entity.HasOne(d => d.MedicalAssessmentDetail)
                    .WithMany(p => p.UserMedicalDetail)
                    .HasForeignKey(d => d.MedicalAssessmentDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalDetail_MedicalAssessmentDetail");

                entity.HasOne(d => d.MedicalAssessmentType)
                    .WithMany(p => p.UserMedicalDetail)
                    .HasForeignKey(d => d.MedicalAssessmentTypeId)
                    .HasConstraintName("FK_UserMedicalDetail_MedicalAssessmentType");

                entity.HasOne(d => d.MedicalPractitioner)
                    .WithMany(p => p.UserMedicalDetail)
                    .HasForeignKey(d => d.MedicalPractitionerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicalAssessment_MedicalPractitioner");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserMedicalDetailUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalDetail_UserMedicalDetailUser");

                entity.HasOne(d => d.VisionAssessment)
                    .WithMany(p => p.UserMedicalDetail)
                    .HasForeignKey(d => d.VisionAssessmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalAssessment_VisionAssessment");
            });

            modelBuilder.Entity<UserMedicalDetailFile>(entity =>
            {
                entity.Property(e => e.UserMedicalDetailFileId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserMedicalDetailFile)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalDetailFile_Company");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.UserMedicalDetailFile)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalDetailFile_ModifiedByUser");

                entity.HasOne(d => d.UserMedicalDetail)
                    .WithMany(p => p.UserMedicalDetailFile)
                    .HasForeignKey(d => d.UserMedicalDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalDetailFile_UserMedicalDetail");
            });

            modelBuilder.Entity<UserMedicalDetailMedicalStatus>(entity =>
            {
                entity.HasIndex(e => new { e.IsDeleted, e.UserId });

                entity.Property(e => e.UserMedicalDetailMedicalStatusId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserMedicalDetailMedicalStatus)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalDetailMedicalStatus_Company");

                entity.HasOne(d => d.MedicalStatus)
                    .WithMany(p => p.UserMedicalDetailMedicalStatus)
                    .HasForeignKey(d => d.MedicalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalDetailMedicalStatus_MedicalStatus");

                entity.HasOne(d => d.UpdatedByUser)
                    .WithMany(p => p.UserMedicalDetailMedicalStatusUpdatedByUser)
                    .HasForeignKey(d => d.UpdatedByUserId)
                    .HasConstraintName("FK_UserMedicalDetailMedicalStatus_MedicalStatusUpdatedByUser");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserMedicalDetailMedicalStatusUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserMedicalDetailMedicalStatus_UserMedicalStatus");

                entity.HasOne(d => d.UserMedicalDetail)
                    .WithMany(p => p.UserMedicalDetailMedicalStatus)
                    .HasForeignKey(d => d.UserMedicalDetailId)
                    .HasConstraintName("FK_UserMedicalDetailMedicalStatus_UserMedicalDetail");
            });

            modelBuilder.Entity<UserMedicalTestRequest>(entity =>
            {
                entity.Property(e => e.UserMedicalTestRequestId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserMedicalTestRequest)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalTestRequest_Company");

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany(p => p.UserMedicalTestRequestCreatedByUser)
                    .HasForeignKey(d => d.CreatedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalTestRequest_CreatedByUser");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserMedicalTestRequestUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalTestRequest_UserMedicalTestRequestUser");

                entity.HasOne(d => d.UserMedicalTestRequestType)
                    .WithMany(p => p.UserMedicalTestRequest)
                    .HasForeignKey(d => d.UserMedicalTestRequestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalTestRequest_UserMedicalTestRequestType");
            });

            modelBuilder.Entity<UserMedicalTestRequestType>(entity =>
            {
                entity.Property(e => e.UserMedicalTestRequestTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<UserMedicationInformation>(entity =>
            {
                entity.Property(e => e.UserMedicationInformationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Notes).IsRequired();

                entity.Property(e => e.PrescriptionReason).IsRequired();

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.ArchivedByUser)
                    .WithMany(p => p.UserMedicationInformationArchivedByUser)
                    .HasForeignKey(d => d.ArchivedByUserId)
                    .HasConstraintName("FK_MedicationInformation_MedicationInformationArchivedByUser");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserMedicationInformation)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicationInformation_Company");

                entity.HasOne(d => d.MedicationInformationCategory)
                    .WithMany(p => p.UserMedicationInformation)
                    .HasForeignKey(d => d.MedicationInformationCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicationInformation_MedicationInformationCategory");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserMedicationInformationUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicationInformation_MedicationInformationUser");
            });

            modelBuilder.Entity<UserPasswordReset>(entity =>
            {
                entity.Property(e => e.UserPasswordResetId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPasswordReset)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPasswordReset_User");
            });

            modelBuilder.Entity<UserPreference>(entity =>
            {
                entity.Property(e => e.UserPreferenceId).ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserPreference)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPreference_Company");

                entity.HasOne(d => d.DashboardLastSelectedTeam)
                    .WithMany(p => p.UserPreference)
                    .HasForeignKey(d => d.DashboardLastSelectedTeamId)
                    .HasConstraintName("FK_UserPreference_LastSelectedTeam");

                entity.HasOne(d => d.UserPreferenceNavigation)
                    .WithOne(p => p.UserPreference)
                    .HasForeignKey<UserPreference>(d => d.UserPreferenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPreference_User");
            });

            modelBuilder.Entity<UserPrivateTeamMember>(entity =>
            {
                entity.HasIndex(e => new { e.PrivateTeamId, e.UserId })
                    .IsUnique()
                    .HasFilter("([IsDeleted]=(0))");

                entity.Property(e => e.UserPrivateTeamMemberId).ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.PrivateTeam)
                    .WithMany(p => p.UserPrivateTeamMember)
                    .HasForeignKey(d => d.PrivateTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPrivateTeamMember_PrivateTeam");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPrivateTeamMember)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPrivateTeamMember_User");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.Property(e => e.UserProfileId).ValueGeneratedNever();

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.EmployeeReference).IsRequired();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Timezone).IsRequired();

                entity.Property(e => e.TravellingTime).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Assessor)
                    .WithMany(p => p.UserProfileAssessor)
                    .HasForeignKey(d => d.AssessorId)
                    .HasConstraintName("FK_UserProfile_AssessorUserProfile");

                entity.HasOne(d => d.BaseLocation)
                    .WithMany(p => p.UserProfile)
                    .HasForeignKey(d => d.BaseLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProfile_BaseLocation");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserProfile)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProfile_Company");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.UserProfile)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProfile_Gender");

                entity.HasOne(d => d.LineManager)
                    .WithMany(p => p.UserProfileLineManager)
                    .HasForeignKey(d => d.LineManagerId)
                    .HasConstraintName("FK_UserProfile_LineManager");

                entity.HasOne(d => d.PermanentAddress)
                    .WithMany(p => p.UserProfile)
                    .HasForeignKey(d => d.PermanentAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PermanentAddress");
            });

            modelBuilder.Entity<UserProfileFile>(entity =>
            {
                entity.HasIndex(e => new { e.UserProfileId, e.IsDeleted });

                entity.HasIndex(e => new { e.UserProfileFileTypeId, e.UserProfileId, e.IsDeleted })
                    .HasName("IX_UserProfileFile")
                    .IsUnique()
                    .HasFilter("([IsDeleted]=(0))");

                entity.Property(e => e.UserProfileFileId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.UserProfileFileType)
                    .WithMany(p => p.UserProfileFile)
                    .HasForeignKey(d => d.UserProfileFileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProfileFile_UserProfileFileType");

                entity.HasOne(d => d.UserProfile)
                    .WithMany(p => p.UserProfileFile)
                    .HasForeignKey(d => d.UserProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProfileFile_UserProfile");
            });

            modelBuilder.Entity<UserProfileFileType>(entity =>
            {
                entity.Property(e => e.UserProfileFileTypeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<UserRecruitmentDetail>(entity =>
            {
                entity.Property(e => e.UserRecruitmentDetailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserRecruitmentDetail)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRecruitmentDetail_Company");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.UserRecruitmentDetailModifiedByUser)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRecruitmentDetail_ModifiedByUser");

                entity.HasOne(d => d.ResultAddedByUser)
                    .WithMany(p => p.UserRecruitmentDetailResultAddedByUser)
                    .HasForeignKey(d => d.ResultAddedByUserId)
                    .HasConstraintName("FK_UserRecruitmentDetail_ResultAddedByUser");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRecruitmentDetailUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRecruitmentDetail_UserRecruitmentDetailUser");
            });

            modelBuilder.Entity<UserRecruitmentDetailFile>(entity =>
            {
                entity.HasIndex(e => new { e.UserRecruitmentDetailId, e.IsDeleted })
                    .HasName("IX_UserRecruitmentDetailFile")
                    .IsUnique()
                    .HasFilter("([IsDeleted]=(0))");

                entity.Property(e => e.UserRecruitmentDetailFileId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserRecruitmentDetailFile)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRecruitmentDetailFile_Company");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.UserRecruitmentDetailFile)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRecruitmentDetailFile_ModifiedByUser");

                entity.HasOne(d => d.UserRecruitmentDetail)
                    .WithMany(p => p.UserRecruitmentDetailFile)
                    .HasForeignKey(d => d.UserRecruitmentDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRecruitmentDetailFile_UserRecruitmentDetail");
            });

            modelBuilder.Entity<UserReference>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UserReference");

                entity.Property(e => e.CompanyId).HasMaxLength(50);

                entity.Property(e => e.FieldOrder).IsRequired();

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<UserSafetyBriefing>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyId, e.UserId, e.IsDeleted });

                entity.Property(e => e.UserSafetyBriefingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateAttended).HasColumnType("datetime");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserSafetyBriefing)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSafetyBriefing_Company");

                entity.HasOne(d => d.SafetyBrief)
                    .WithMany(p => p.UserSafetyBriefing)
                    .HasForeignKey(d => d.SafetyBriefId)
                    .HasConstraintName("FK_UserSafetyBriefing_SafetyBrief");

                entity.HasOne(d => d.SafetyBriefingType)
                    .WithMany(p => p.UserSafetyBriefing)
                    .HasForeignKey(d => d.SafetyBriefingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSafetyBriefing_SafetyBriefingType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSafetyBriefing)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSafetyBriefing_UserSafetyBriefingUser");
            });

            modelBuilder.Entity<UserSafetyBriefingDocument>(entity =>
            {
                entity.HasIndex(e => new { e.UserSafetyBriefingDocumentId, e.DisplayFileName, e.StorageFileName, e.FileMimeType, e.FileSizeBytes, e.UserSafetyBriefingId })
                    .HasName("IX_UserSafetyBriefingDocument_UserSafetyBriefingId");

                entity.Property(e => e.UserSafetyBriefingDocumentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DisplayFileName)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.FileMimeType)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.StorageFileName)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserSafetyBriefingDocument)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSafetyBriefingDocument_Company");

                entity.HasOne(d => d.UserSafetyBriefing)
                    .WithMany(p => p.UserSafetyBriefingDocument)
                    .HasForeignKey(d => d.UserSafetyBriefingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSafetyBriefingDocument_UserSafetyBriefing");
            });

            modelBuilder.Entity<UserSafetyCriticalStatus>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.ModifiedDate });

                entity.Property(e => e.UserSafetyCriticalStatusId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserSafetyCriticalStatus)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSafetyCriticalStatus_Company");

                entity.HasOne(d => d.EmployeeSafetyCriticalStatus)
                    .WithMany(p => p.UserSafetyCriticalStatus)
                    .HasForeignKey(d => d.EmployeeSafetyCriticalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSafetyCriticalStatus_EmployeeSafetyCriticalStatus");

                entity.HasOne(d => d.UpdatedByUser)
                    .WithMany(p => p.UserSafetyCriticalStatusUpdatedByUser)
                    .HasForeignKey(d => d.UpdatedByUserId)
                    .HasConstraintName("FK_UserSafetyCriticalStatus_EmployeeSafetyCriticalStatusUpdatedByUser");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSafetyCriticalStatusUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSafetyCriticalStatus_EmployeeSafetyCriticalStatusUser");
            });

            modelBuilder.Entity<UserSkill>(entity =>
            {
                entity.Property(e => e.UserSkillId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ValidFromDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserSkill)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSkill_Company");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.UserSkillModifiedByUser)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSkill_UserSkillModifiedByUser");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.UserSkill)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSkill_Skill");

                entity.HasOne(d => d.Training)
                    .WithMany(p => p.UserSkill)
                    .HasForeignKey(d => d.TrainingId)
                    .HasConstraintName("FK_UserSkill_Training");

                entity.HasOne(d => d.UserCompanyRole)
                    .WithMany(p => p.UserSkill)
                    .HasForeignKey(d => d.UserCompanyRoleId)
                    .HasConstraintName("FK_UserSkill_UserCompanyRole");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSkillUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSkill_UserSkillUser");
            });

            modelBuilder.Entity<UserSkillSigningHistory>(entity =>
            {
                entity.Property(e => e.UserSkillSigningHistoryId).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RenewedDateTime).HasColumnType("datetime");

                entity.Property(e => e.SignedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.UserSkillSigningHistoryModifiedByUser)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSkillSigningHistory_UserSkillSigningModifiedByUser");

                entity.HasOne(d => d.SignedByUser)
                    .WithMany(p => p.UserSkillSigningHistorySignedByUser)
                    .HasForeignKey(d => d.SignedByUserId)
                    .HasConstraintName("FK_UserSkillSigningHistory_UserSkillSigningSignedByUser");

                entity.HasOne(d => d.UserSkill)
                    .WithMany(p => p.UserSkillSigningHistory)
                    .HasForeignKey(d => d.UserSkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSkillSigningHistory_UserSkill");
            });

            modelBuilder.Entity<UserSupportLevel>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.ModifiedDate });

                entity.Property(e => e.UserSupportLevelId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserSupportLevel)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSupportLevel_Company");

                entity.HasOne(d => d.SupportLevel)
                    .WithMany(p => p.UserSupportLevel)
                    .HasForeignKey(d => d.SupportLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSupportLevel_SupportLevel");

                entity.HasOne(d => d.UpdatedByUser)
                    .WithMany(p => p.UserSupportLevelUpdatedByUser)
                    .HasForeignKey(d => d.UpdatedByUserId)
                    .HasConstraintName("FK_UserSupportLevel_SupportLevelUpdatedByUser");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSupportLevelUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSupportLevel_SupportLevelUser");
            });

            modelBuilder.Entity<UserTeam>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.TeamId })
                    .HasName("IX_UserTeam_TeamId");

                entity.HasIndex(e => new { e.TeamId, e.IsDeleted, e.UserId })
                    .HasName("IX_UserTeam_UserId");

                entity.HasIndex(e => new { e.UserId, e.TeamId, e.IsDeleted })
                    .HasName("IX_UserTeam_IsDeleted");

                entity.HasIndex(e => new { e.ModifiedDate, e.CompanyId, e.TeamId, e.UserId, e.IsDeleted })
                    .HasName("IX_UserTeam_CompanyId_TeamId_IsDeleted");

                entity.Property(e => e.UserTeamId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserTeam)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTeam_Company");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.UserTeam)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTeam_Team");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTeam)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTeam_User");
            });

            modelBuilder.Entity<UserTimeWithManager>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyId, e.UserId, e.IsDeleted });

                entity.Property(e => e.UserTimeWithManagerId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2016-01-01 00:00:00.000')");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2016-01-01 00:00:00.000')");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserTimeWithManager)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTimeWithManager_Company");

                entity.HasOne(d => d.CompletedByUser)
                    .WithMany(p => p.UserTimeWithManagerCompletedByUser)
                    .HasForeignKey(d => d.CompletedByUserId)
                    .HasConstraintName("FK_UserTimeWithManager_TimeWithManagerCompletedByUser");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.UserTimeWithManager)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTimeWithManager_Location");

                entity.HasOne(d => d.ManagerUser)
                    .WithMany(p => p.UserTimeWithManagerManagerUser)
                    .HasForeignKey(d => d.ManagerUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTimeWithManager_ManagerUser");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTimeWithManagerUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTimeWithManager_UserTimeWithManagerUser");
            });

            modelBuilder.Entity<UserTimeWithManagerDocument>(entity =>
            {
                entity.Property(e => e.UserTimeWithManagerDocumentId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DisplayFileName).IsRequired();

                entity.Property(e => e.FileMimeType).IsRequired();

                entity.Property(e => e.StorageFileName).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserTimeWithManagerDocument)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTimeWithManagerDocument_Company");

                entity.HasOne(d => d.UserTimeWithManager)
                    .WithMany(p => p.UserTimeWithManagerDocument)
                    .HasForeignKey(d => d.UserTimeWithManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTimeWithManagerDocument_UserTimeWithManager");
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.Property(e => e.UserTokenId).ValueGeneratedNever();

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Token).IsRequired();

                entity.HasOne(d => d.UserTokenNavigation)
                    .WithOne(p => p.UserToken)
                    .HasForeignKey<UserToken>(d => d.UserTokenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserToken_User");
            });

            modelBuilder.Entity<UserTrainingStatistic>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserTrainingStatistic)
                    .HasForeignKey<UserTrainingStatistic>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTrainingStatisitc_UserId");
            });

            modelBuilder.Entity<VerificationStatement>(entity =>
            {
                entity.Property(e => e.VerificationStatementId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Statement).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.VerificationStatement)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VerificationStatement_Company");

                entity.HasOne(d => d.VerificationStatementCategory)
                    .WithMany(p => p.VerificationStatement)
                    .HasForeignKey(d => d.VerificationStatementCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VerificationStatement_VerificationStatementCategory");
            });

            modelBuilder.Entity<VerificationStatementCategory>(entity =>
            {
                entity.Property(e => e.VerificationStatementCategoryId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<VerificationStatementRating>(entity =>
            {
                entity.Property(e => e.VerificationStatementRatingId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<VerificationStatus>(entity =>
            {
                entity.Property(e => e.VerificationStatusId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<VersionInfo>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Version)
                    .HasName("UC_Version")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.AppliedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1024);
            });

            modelBuilder.Entity<Visibility>(entity =>
            {
                entity.Property(e => e.VisibilityId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<VisionAssessment>(entity =>
            {
                entity.Property(e => e.VisionAssessmentId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ColourVisionResult)
                    .WithMany(p => p.VisionAssessmentColourVisionResult)
                    .HasForeignKey(d => d.ColourVisionResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisionAssessment_ColourVisionResult");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.VisionAssessment)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisionAssessment_Company");

                entity.HasOne(d => d.DistanceVisionAidedResult)
                    .WithMany(p => p.VisionAssessmentDistanceVisionAidedResult)
                    .HasForeignKey(d => d.DistanceVisionAidedResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisionAssessment_DistanceVisionAidedResult");

                entity.HasOne(d => d.DistanceVisionUnaidedResult)
                    .WithMany(p => p.VisionAssessmentDistanceVisionUnaidedResult)
                    .HasForeignKey(d => d.DistanceVisionUnaidedResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisionAssessment_DistanceVisionUnaidedResult");

                entity.HasOne(d => d.GlassesRequiredResult)
                    .WithMany(p => p.VisionAssessmentGlassesRequiredResult)
                    .HasForeignKey(d => d.GlassesRequiredResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisionAssessment_GlassesRequiredResult");

                entity.HasOne(d => d.NearVisionAidedResult)
                    .WithMany(p => p.VisionAssessmentNearVisionAidedResult)
                    .HasForeignKey(d => d.NearVisionAidedResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisionAssessment_NearVisionAidedResult");

                entity.HasOne(d => d.NearVisionUnaidedResult)
                    .WithMany(p => p.VisionAssessmentNearVisionUnaidedResult)
                    .HasForeignKey(d => d.NearVisionUnaidedResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisionAssessment_NearVisionUnaidedResult");

                entity.HasOne(d => d.TintedLensesUsedResult)
                    .WithMany(p => p.VisionAssessmentTintedLensesUsedResult)
                    .HasForeignKey(d => d.TintedLensesUsedResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisionAssessment_TintedLensesUsedResult");
            });

            modelBuilder.Entity<WeatherForecast>(entity =>
            {
                entity.Property(e => e.WeatherForecastId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Reference).IsRequired();
            });

            modelBuilder.Entity<YesNo>(entity =>
            {
                entity.Property(e => e.YesNoId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<YesNoIntReference>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("YesNoIntReference");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.YesNoId).HasMaxLength(1);
            });

            modelBuilder.Entity<YesNoReference>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("YesNoReference");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.YesNoId).HasMaxLength(50);
            });

            modelBuilder.Entity<YouRole>(entity =>
            {
                entity.Property(e => e.YouRoleId).ValueGeneratedNever();

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.YouRole)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YouRole_Company");
            });

            modelBuilder.Entity<YouRoleReference>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("YouRoleReference");

                entity.Property(e => e.CompanyId).HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.YouRoleId).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
