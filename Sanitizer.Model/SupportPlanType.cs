using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class SupportPlanType
    {
        public SupportPlanType()
        {
            Incident = new HashSet<Incident>();
            SupportPlan = new HashSet<SupportPlan>();
            SupportPlanCurrentSupportPlanType = new HashSet<SupportPlanCurrentSupportPlanType>();
        }

        public Guid SupportPlanTypeId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Colour { get; set; }
        public bool IpadReadOnly { get; set; }

        public virtual ICollection<Incident> Incident { get; set; }
        public virtual ICollection<SupportPlan> SupportPlan { get; set; }
        public virtual ICollection<SupportPlanCurrentSupportPlanType> SupportPlanCurrentSupportPlanType { get; set; }
    }
}
