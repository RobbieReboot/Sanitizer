using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class UserSkill
    {
        public UserSkill()
        {
            UserSkillSigningHistory = new HashSet<UserSkillSigningHistory>();
        }

        public Guid UserSkillId { get; set; }
        public Guid UserId { get; set; }
        public Guid SkillId { get; set; }
        public DateTime ValidFromDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public Guid ModifiedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? TrainingId { get; set; }
        public Guid? UserCompanyRoleId { get; set; }
        public Guid CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual Training Training { get; set; }
        public virtual User User { get; set; }
        public virtual UserCompanyRole UserCompanyRole { get; set; }
        public virtual ICollection<UserSkillSigningHistory> UserSkillSigningHistory { get; set; }
    }
}
