using System;

namespace Sanitizer.Model
{
    public partial class SupportPlanNote
    {
        public Guid SupportPlanNoteId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid SupportPlanId { get; set; }
        public string Notes { get; set; }
        public Guid AddedByUserId { get; set; }
        public int OrderIndex { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User AddedByUser { get; set; }
        public virtual Company Company { get; set; }
        public virtual SupportPlan SupportPlan { get; set; }
    }
}
