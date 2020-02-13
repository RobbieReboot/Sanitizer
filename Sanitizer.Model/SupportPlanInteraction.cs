using System;

namespace Sanitizer.Model
{
    public partial class SupportPlanInteraction
    {
        public Guid SupportPlanInteractionId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid SupportPlanId { get; set; }
        public Guid? PlannedInteractionTypeId { get; set; }
        public string OtherPlannedInteractionType { get; set; }
        public Guid? AssessmentId { get; set; }
        public string Description { get; set; }
        public DateTime? ExpectedCompletionDate { get; set; }
        public DateTime? ActualCompletionDate { get; set; }
        public int OrderIndex { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? ArchivedByUserId { get; set; }
        public DateTime? DateArchived { get; set; }
        public bool IsArchived { get; set; }

        public virtual User ArchivedByUser { get; set; }
        public virtual Assessment Assessment { get; set; }
        public virtual Company Company { get; set; }
        public virtual PlannedInteractionType PlannedInteractionType { get; set; }
        public virtual SupportPlan SupportPlan { get; set; }
    }
}
