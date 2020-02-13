using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Traction
    {
        public Traction()
        {
            AssessmentConditionCard = new HashSet<AssessmentConditionCard>();
            RollingStockAuthorisedToOperate = new HashSet<RollingStockAuthorisedToOperate>();
            TrainingPracticalDriving = new HashSet<TrainingPracticalDriving>();
            TrainingTemplatePracticalDriving = new HashSet<TrainingTemplatePracticalDriving>();
        }

        public Guid TractionId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool Expires { get; set; }
        public int? Duration { get; set; }
        public Guid? DurationUnitId { get; set; }
        public bool AutoRenew { get; set; }
        public string Code { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual DurationUnit DurationUnit { get; set; }
        public virtual ICollection<AssessmentConditionCard> AssessmentConditionCard { get; set; }
        public virtual ICollection<RollingStockAuthorisedToOperate> RollingStockAuthorisedToOperate { get; set; }
        public virtual ICollection<TrainingPracticalDriving> TrainingPracticalDriving { get; set; }
        public virtual ICollection<TrainingTemplatePracticalDriving> TrainingTemplatePracticalDriving { get; set; }
    }
}
