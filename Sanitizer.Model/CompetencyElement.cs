using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class CompetencyElement
    {
        public CompetencyElement()
        {
            CompetencyCriteria = new HashSet<CompetencyCriteria>();
            CompetencyElementLearningResource = new HashSet<CompetencyElementLearningResource>();
        }

        public Guid CompetencyElementId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid CompetencyUnitId { get; set; }
        public string Name { get; set; }
        public int OrderIndex { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsArchived { get; set; }
        public Guid? ArchivedByUserId { get; set; }
        public DateTime? DateArchived { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual User ArchivedByUser { get; set; }
        public virtual Company Company { get; set; }
        public virtual CompetencyUnit CompetencyUnit { get; set; }
        public virtual ICollection<CompetencyCriteria> CompetencyCriteria { get; set; }
        public virtual ICollection<CompetencyElementLearningResource> CompetencyElementLearningResource { get; set; }
    }
}
