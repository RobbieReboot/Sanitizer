using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class PlannedInteractionType
    {
        public PlannedInteractionType()
        {
            SupportPlanInteraction = new HashSet<SupportPlanInteraction>();
        }

        public Guid PlannedInteractionTypeId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IpadRequiresActualCompletionDate { get; set; }
        public string Colour { get; set; }

        public virtual ICollection<SupportPlanInteraction> SupportPlanInteraction { get; set; }
    }
}
