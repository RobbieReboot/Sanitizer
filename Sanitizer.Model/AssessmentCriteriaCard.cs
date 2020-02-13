using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class AssessmentCriteriaCard
    {
        public AssessmentCriteriaCard()
        {
            AssessmentCriteriaCardAttachment = new HashSet<AssessmentCriteriaCardAttachment>();
        }

        public Guid AssessmentCriteriaCardId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid AssessmentId { get; set; }
        public Guid CompetencyCriteriaId { get; set; }
        public Guid? AssessmentCriteriaCardRatingId { get; set; }
        public Guid? AssessmentCriteriaCardEvidenceId { get; set; }
        public Guid AssessmentConditionCardId { get; set; }
        public string ReasonForRating { get; set; }
        public bool ItemForReview { get; set; }
        public bool ItemHasBeenReviewed { get; set; }
        public DateTime? DateCompleted { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateArchived { get; set; }
        public bool IsArchived { get; set; }
        public Guid? ArchivedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid CreatedOnPlatformId { get; set; }

        public virtual User ArchivedByUser { get; set; }
        public virtual Assessment Assessment { get; set; }
        public virtual AssessmentConditionCard AssessmentConditionCard { get; set; }
        public virtual AssessmentCriteriaCardEvidence AssessmentCriteriaCardEvidence { get; set; }
        public virtual AssessmentCriteriaCardRating AssessmentCriteriaCardRating { get; set; }
        public virtual Company Company { get; set; }
        public virtual CompetencyCriteria CompetencyCriteria { get; set; }
        public virtual Platform CreatedOnPlatform { get; set; }
        public virtual ICollection<AssessmentCriteriaCardAttachment> AssessmentCriteriaCardAttachment { get; set; }
    }
}
