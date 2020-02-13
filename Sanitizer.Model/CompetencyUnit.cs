using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class CompetencyUnit
    {
        public CompetencyUnit()
        {
            CompetencyElement = new HashSet<CompetencyElement>();
        }

        public Guid CompetencyUnitId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public int? TimeframeMonths { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsArchived { get; set; }
        public Guid? ArchivedByUserId { get; set; }
        public DateTime? DateArchived { get; set; }
        public int OrderIndex { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual User ArchivedByUser { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<CompetencyElement> CompetencyElement { get; set; }
    }
}
