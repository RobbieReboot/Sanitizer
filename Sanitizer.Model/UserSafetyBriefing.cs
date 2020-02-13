using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class UserSafetyBriefing
    {
        public UserSafetyBriefing()
        {
            UserSafetyBriefingDocument = new HashSet<UserSafetyBriefingDocument>();
        }

        public Guid UserSafetyBriefingId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public Guid SafetyBriefingTypeId { get; set; }
        public string Title { get; set; }
        public DateTime DateAttended { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? SafetyBriefId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual SafetyBrief SafetyBrief { get; set; }
        public virtual SafetyBriefingType SafetyBriefingType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<UserSafetyBriefingDocument> UserSafetyBriefingDocument { get; set; }
    }
}
