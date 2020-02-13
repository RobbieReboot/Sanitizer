using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class SupportPlanManagerRecommendation
    {
        public SupportPlanManagerRecommendation()
        {
            SupportPlanManagerJustification = new HashSet<SupportPlanManagerJustification>();
        }

        public Guid SupportPlanManagerRecommendationId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<SupportPlanManagerJustification> SupportPlanManagerJustification { get; set; }
    }
}
