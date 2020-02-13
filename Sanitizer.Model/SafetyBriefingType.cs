using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class SafetyBriefingType
    {
        public SafetyBriefingType()
        {
            UserSafetyBriefing = new HashSet<UserSafetyBriefing>();
        }

        public Guid SafetyBriefingTypeId { get; set; }
        public string Reference { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<UserSafetyBriefing> UserSafetyBriefing { get; set; }
    }
}
