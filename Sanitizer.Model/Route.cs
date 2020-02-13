using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Route
    {
        public Route()
        {
            AssessmentConditionCardRoute = new HashSet<AssessmentConditionCardRoute>();
            AssessmentOtdrDetail = new HashSet<AssessmentOtdrDetail>();
            InfrastructureAuthorisedToOperate = new HashSet<InfrastructureAuthorisedToOperate>();
        }

        public Guid RouteId { get; set; }
        public Guid CompanyId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool Expires { get; set; }
        public int? Duration { get; set; }
        public Guid? DurationUnitId { get; set; }
        public bool AutoRenew { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual DurationUnit DurationUnit { get; set; }
        public virtual ICollection<AssessmentConditionCardRoute> AssessmentConditionCardRoute { get; set; }
        public virtual ICollection<AssessmentOtdrDetail> AssessmentOtdrDetail { get; set; }
        public virtual ICollection<InfrastructureAuthorisedToOperate> InfrastructureAuthorisedToOperate { get; set; }
    }
}
