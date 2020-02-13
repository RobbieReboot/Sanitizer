using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Skill
    {
        public Skill()
        {
            TrainingTemplateSkill = new HashSet<TrainingTemplateSkill>();
            UserSkill = new HashSet<UserSkill>();
        }

        public Guid SkillId { get; set; }
        public Guid CompanyId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Expires { get; set; }
        public int? Duration { get; set; }
        public Guid? DurationUnitId { get; set; }
        public bool AutoRenew { get; set; }
        public Guid ModifiedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? CompanyRoleId { get; set; }

        public virtual Company Company { get; set; }
        public virtual CompanyRole CompanyRole { get; set; }
        public virtual DurationUnit DurationUnit { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual ICollection<TrainingTemplateSkill> TrainingTemplateSkill { get; set; }
        public virtual ICollection<UserSkill> UserSkill { get; set; }
    }
}
