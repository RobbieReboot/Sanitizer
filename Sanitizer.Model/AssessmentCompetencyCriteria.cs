using System;

namespace Sanitizer.Model
{
    public partial class AssessmentCompetencyCriteria
    {
        public Guid AssessmentCompetencyCriteriaId { get; set; }
        public Guid AssessmentId { get; set; }
        public Guid CompetencyCriteriaId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Assessment Assessment { get; set; }
        public virtual CompetencyCriteria CompetencyCriteria { get; set; }
    }
}
