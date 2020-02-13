using System;

namespace Sanitizer.Model
{
    public partial class AssessmentConditionCardRoute
    {
        public Guid AssessmentConditionCardRouteId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid AssessmentConditionCardId { get; set; }
        public Guid RouteId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual AssessmentConditionCard AssessmentConditionCard { get; set; }
        public virtual Company Company { get; set; }
        public virtual Route Route { get; set; }
    }
}
