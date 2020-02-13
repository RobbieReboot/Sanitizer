using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class SupportLevel
    {
        public SupportLevel()
        {
            SupportPlan = new HashSet<SupportPlan>();
            UserSupportLevel = new HashSet<UserSupportLevel>();
        }

        public Guid SupportLevelId { get; set; }
        public string Reference { get; set; }
        public string Colour { get; set; }
        public int OrderIndex { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Guid CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<SupportPlan> SupportPlan { get; set; }
        public virtual ICollection<UserSupportLevel> UserSupportLevel { get; set; }
    }
}
