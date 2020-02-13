using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class SupportPlanManagerJustification
    {
        public SupportPlanManagerJustification()
        {
            SupportPlanDepotAreaManagerJustification = new HashSet<SupportPlan>();
            SupportPlanOperationalStandardsManagerJustification = new HashSet<SupportPlan>();
        }

        public Guid SupportPlanManagerJustificationId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? SupportPlanManagerRecommendationId { get; set; }
        public Guid? ManagerId { get; set; }
        public string Justification { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual User Manager { get; set; }
        public virtual SupportPlanManagerRecommendation SupportPlanManagerRecommendation { get; set; }
        public virtual ICollection<SupportPlan> SupportPlanDepotAreaManagerJustification { get; set; }
        public virtual ICollection<SupportPlan> SupportPlanOperationalStandardsManagerJustification { get; set; }
    }
}
