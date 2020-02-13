using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class CompetencyCriteria
    {
        public CompetencyCriteria()
        {
            AssessmentCompetencyCriteria = new HashSet<AssessmentCompetencyCriteria>();
            AssessmentCriteriaCard = new HashSet<AssessmentCriteriaCard>();
            CompetencyCycleCriteria = new HashSet<CompetencyCycleCriteria>();
        }

        public Guid CompetencyCriteriaId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid CompetencyElementId { get; set; }
        public Guid CompetencyCriteriaRiskLevelId { get; set; }
        public string Title { get; set; }
        public int OrderIndex { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsArchived { get; set; }
        public Guid? ArchivedByUserId { get; set; }
        public DateTime? DateArchived { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual User ArchivedByUser { get; set; }
        public virtual Company Company { get; set; }
        public virtual CompetencyCriteriaRiskLevel CompetencyCriteriaRiskLevel { get; set; }
        public virtual CompetencyElement CompetencyElement { get; set; }
        public virtual ICollection<AssessmentCompetencyCriteria> AssessmentCompetencyCriteria { get; set; }
        public virtual ICollection<AssessmentCriteriaCard> AssessmentCriteriaCard { get; set; }
        public virtual ICollection<CompetencyCycleCriteria> CompetencyCycleCriteria { get; set; }
    }
}
