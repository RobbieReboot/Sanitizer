using System;

namespace Sanitizer.Model
{
    public partial class CompetencyCycleAssessmentWindow
    {
        public Guid CompetencyCycleAssessmentWindowId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid CompetencyCycleId { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public Guid AssessmentTypeId { get; set; }
        public int StartMonth { get; set; }
        public int MonthDuration { get; set; }
        public int OrderIndex { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual AssessmentType AssessmentType { get; set; }
        public virtual Company Company { get; set; }
        public virtual CompetencyCycle CompetencyCycle { get; set; }
    }
}
