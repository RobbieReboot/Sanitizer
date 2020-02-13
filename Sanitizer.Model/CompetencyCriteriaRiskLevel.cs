using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class CompetencyCriteriaRiskLevel
    {
        public CompetencyCriteriaRiskLevel()
        {
            CompetencyCriteria = new HashSet<CompetencyCriteria>();
        }

        public Guid CompetencyCriteriaRiskLevelId { get; set; }
        public string Reference { get; set; }
        public int OrderIndex { get; set; }
        public string Colour { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<CompetencyCriteria> CompetencyCriteria { get; set; }
    }
}
