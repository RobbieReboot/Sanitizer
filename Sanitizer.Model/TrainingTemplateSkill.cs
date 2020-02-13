using System;

namespace Sanitizer.Model
{
    public partial class TrainingTemplateSkill
    {
        public Guid TrainingTemplateSkillId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid TrainingTemplateId { get; set; }
        public Guid SkillId { get; set; }
        public Guid ModifiedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual TrainingTemplate TrainingTemplate { get; set; }
    }
}
