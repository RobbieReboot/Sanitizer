using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class SupportPlan
    {
        public SupportPlan()
        {
            SupportPlanAimObjective = new HashSet<SupportPlanAimObjective>();
            SupportPlanApprovalUser = new HashSet<SupportPlanApprovalUser>();
            SupportPlanCurrentSupportPlanType = new HashSet<SupportPlanCurrentSupportPlanType>();
            SupportPlanDocument = new HashSet<SupportPlanDocument>();
            SupportPlanIncident = new HashSet<SupportPlanIncident>();
            SupportPlanInteraction = new HashSet<SupportPlanInteraction>();
            SupportPlanNote = new HashSet<SupportPlanNote>();
            SupportPlanSignature = new HashSet<SupportPlanSignature>();
            SupportPlanVerificationStatement = new HashSet<SupportPlanVerificationStatement>();
        }

        public Guid SupportPlanId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public Guid SupportPlanTypeId { get; set; }
        public Guid SupportLevelId { get; set; }
        public Guid? IncidentTypeId { get; set; }
        public Guid? VerifiedByUserId { get; set; }
        public Guid? VerificationStatusId { get; set; }
        public Guid? AssessorVerificationResponseId { get; set; }
        public string OtherReasonForSupportPlan { get; set; }
        public string ReasonForSupportPlanNotes { get; set; }
        public string EmployeePersonalCommitmentAction { get; set; }
        public string EmployeePersonalCommitmentJustification { get; set; }
        public Guid? SupportPlanOperationalIncidentTypeId { get; set; }
        public DateTime? PeriodStartDate { get; set; }
        public DateTime? PeriodActualCompletionDate { get; set; }
        public DateTime? PeriodExpectedCompletionDate { get; set; }
        public string FinalFeedback { get; set; }
        public string VerifierFinalFeedback { get; set; }
        public string AssessorVerificationResponseNotes { get; set; }
        public bool IsArchived { get; set; }
        public bool IsActive { get; set; }
        public Guid? CreatedByUserId { get; set; }
        public DateTime? DateCreated { get; set; }
        public Guid? ArchivedByUserId { get; set; }
        public DateTime? DateArchived { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool? EmployeeConfirmedResult { get; set; }
        public Guid? DepotAreaManagerJustificationId { get; set; }
        public Guid? OperationalStandardsManagerJustificationId { get; set; }
        public bool RequiresApprovalForCreation { get; set; }
        public bool? RequiresEmployeeSignatureToComplete { get; set; }
        public bool RequiresEmployeeSignatureToStart { get; set; }
        public DateTime? StartedDateTime { get; set; }
        public bool RequiresApprovalForCompletion { get; set; }
        public Guid? UserCompanyRoleId { get; set; }

        public virtual User ArchivedByUser { get; set; }
        public virtual AssessorVerificationResponse AssessorVerificationResponse { get; set; }
        public virtual Company Company { get; set; }
        public virtual User CreatedByUser { get; set; }
        public virtual SupportPlanManagerJustification DepotAreaManagerJustification { get; set; }
        public virtual IncidentType IncidentType { get; set; }
        public virtual SupportPlanManagerJustification OperationalStandardsManagerJustification { get; set; }
        public virtual SupportLevel SupportLevel { get; set; }
        public virtual SupportPlanOperationalIncidentType SupportPlanOperationalIncidentType { get; set; }
        public virtual SupportPlanType SupportPlanType { get; set; }
        public virtual User User { get; set; }
        public virtual UserCompanyRole UserCompanyRole { get; set; }
        public virtual VerificationStatus VerificationStatus { get; set; }
        public virtual User VerifiedByUser { get; set; }
        public virtual ICollection<SupportPlanAimObjective> SupportPlanAimObjective { get; set; }
        public virtual ICollection<SupportPlanApprovalUser> SupportPlanApprovalUser { get; set; }
        public virtual ICollection<SupportPlanCurrentSupportPlanType> SupportPlanCurrentSupportPlanType { get; set; }
        public virtual ICollection<SupportPlanDocument> SupportPlanDocument { get; set; }
        public virtual ICollection<SupportPlanIncident> SupportPlanIncident { get; set; }
        public virtual ICollection<SupportPlanInteraction> SupportPlanInteraction { get; set; }
        public virtual ICollection<SupportPlanNote> SupportPlanNote { get; set; }
        public virtual ICollection<SupportPlanSignature> SupportPlanSignature { get; set; }
        public virtual ICollection<SupportPlanVerificationStatement> SupportPlanVerificationStatement { get; set; }
    }
}
