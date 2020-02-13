using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Assessment
    {
        public Assessment()
        {
            AssessmentCompetencyCriteria = new HashSet<AssessmentCompetencyCriteria>();
            AssessmentCriteriaCard = new HashSet<AssessmentCriteriaCard>();
            AssessmentDocument = new HashSet<AssessmentDocument>();
            AssessmentNote = new HashSet<AssessmentNote>();
            AssessmentPlannedAssessmentTask = new HashSet<AssessmentPlannedAssessmentTask>();
            AssessmentSignature = new HashSet<AssessmentSignature>();
            AssessmentTaskTime = new HashSet<AssessmentTaskTime>();
            AssessmentVerificationStatement = new HashSet<AssessmentVerificationStatement>();
            InverseOrigionalAssessment = new HashSet<Assessment>();
            SupportPlanInteraction = new HashSet<SupportPlanInteraction>();
        }

        public Guid AssessmentId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserAssessingId { get; set; }
        public Guid? AssessorId { get; set; }
        public Guid CompanyRoleId { get; set; }
        public Guid? CompetencyCycleId { get; set; }
        public Guid AssessmentTypeId { get; set; }
        public Guid? VerifiedByUserId { get; set; }
        public Guid? VerificationStatusId { get; set; }
        public Guid? AssessorVerificationResponseId { get; set; }
        public string Title { get; set; }
        public DateTime WindowStartDate { get; set; }
        public DateTime WindowEndDate { get; set; }
        public bool IsClassroomAssessment { get; set; }
        public string Notes { get; set; }
        public Guid? AssessmentCompetencyId { get; set; }
        public string AssessorFeedback { get; set; }
        public bool? EmployeeConfirmedResult { get; set; }
        public DateTime? RecordedStartDate { get; set; }
        public DateTime? RecordedEndDate { get; set; }
        public DateTime? OverriddenStartDate { get; set; }
        public DateTime? OverriddenEndDate { get; set; }
        public Guid? CompletedByUserId { get; set; }
        public Guid? CompletedOnPlatformId { get; set; }
        public string VerifierFinalFeedback { get; set; }
        public string AssessorVerificationResponseNotes { get; set; }
        public Guid? CreatedByUserId { get; set; }
        public DateTime? DateCreated { get; set; }
        public Guid? ArchivedByUserId { get; set; }
        public DateTime? DateArchived { get; set; }
        public bool IsArchived { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsAdHoc { get; set; }
        public bool IsPreview { get; set; }
        public bool AssessorConfirmedResult { get; set; }
        public Guid? InitialCompetencyCycleId { get; set; }
        public Guid OrigionalAssessmentId { get; set; }
        public DateTime? DateImported { get; set; }
        public Guid CreatedOnPlatformId { get; set; }

        public virtual User ArchivedByUser { get; set; }
        public virtual AssessmentCompetency AssessmentCompetency { get; set; }
        public virtual AssessmentType AssessmentType { get; set; }
        public virtual User Assessor { get; set; }
        public virtual AssessorVerificationResponse AssessorVerificationResponse { get; set; }
        public virtual Company Company { get; set; }
        public virtual CompanyRole CompanyRole { get; set; }
        public virtual CompetencyCycle CompetencyCycle { get; set; }
        public virtual User CompletedByUser { get; set; }
        public virtual Platform CompletedOnPlatform { get; set; }
        public virtual User CreatedByUser { get; set; }
        public virtual Platform CreatedOnPlatform { get; set; }
        public virtual CompetencyCycle InitialCompetencyCycle { get; set; }
        public virtual Assessment OrigionalAssessment { get; set; }
        public virtual User UserAssessing { get; set; }
        public virtual VerificationStatus VerificationStatus { get; set; }
        public virtual User VerifiedByUser { get; set; }
        public virtual AssessmentOtdrDetail AssessmentOtdrDetail { get; set; }
        public virtual ICollection<AssessmentCompetencyCriteria> AssessmentCompetencyCriteria { get; set; }
        public virtual ICollection<AssessmentCriteriaCard> AssessmentCriteriaCard { get; set; }
        public virtual ICollection<AssessmentDocument> AssessmentDocument { get; set; }
        public virtual ICollection<AssessmentNote> AssessmentNote { get; set; }
        public virtual ICollection<AssessmentPlannedAssessmentTask> AssessmentPlannedAssessmentTask { get; set; }
        public virtual ICollection<AssessmentSignature> AssessmentSignature { get; set; }
        public virtual ICollection<AssessmentTaskTime> AssessmentTaskTime { get; set; }
        public virtual ICollection<AssessmentVerificationStatement> AssessmentVerificationStatement { get; set; }
        public virtual ICollection<Assessment> InverseOrigionalAssessment { get; set; }
        public virtual ICollection<SupportPlanInteraction> SupportPlanInteraction { get; set; }
    }
}
