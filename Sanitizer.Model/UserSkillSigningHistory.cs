using System;

namespace Sanitizer.Model
{
    public partial class UserSkillSigningHistory
    {
        public Guid UserSkillSigningHistoryId { get; set; }
        public Guid UserSkillId { get; set; }
        public DateTime SignedDateTime { get; set; }
        public DateTime? ExpiryDateTime { get; set; }
        public DateTime? RenewedDateTime { get; set; }
        public Guid? SignedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid ModifiedByUserId { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual User ModifiedByUser { get; set; }
        public virtual User SignedByUser { get; set; }
        public virtual UserSkill UserSkill { get; set; }
    }
}
