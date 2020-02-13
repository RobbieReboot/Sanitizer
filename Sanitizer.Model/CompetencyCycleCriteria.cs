using System;

namespace Sanitizer.Model
{
    public partial class CompetencyCycleCriteria
    {
        public Guid CompetencyCycleCriteriaId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid CompetencyCycleId { get; set; }
        public Guid CompetencyCriteriaId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual CompetencyCriteria CompetencyCriteria { get; set; }
        public virtual CompetencyCycle CompetencyCycle { get; set; }
    }
}
