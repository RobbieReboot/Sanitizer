using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class SafetyBrief
    {
        public SafetyBrief()
        {
            UserSafetyBriefing = new HashSet<UserSafetyBriefing>();
        }

        public Guid SafetyBriefId { get; set; }
        public Guid CompanyId { get; set; }
        public string Title { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsArchived { get; set; }
        public DateTime? DateArchived { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<UserSafetyBriefing> UserSafetyBriefing { get; set; }
    }
}
