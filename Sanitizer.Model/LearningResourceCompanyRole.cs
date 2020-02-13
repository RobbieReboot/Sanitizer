using System;

namespace Sanitizer.Model
{
    public partial class LearningResourceCompanyRole
    {
        public Guid LearningResourceCompanyRoleId { get; set; }
        public Guid LearningResourceId { get; set; }
        public Guid CompanyRoleId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid ModifiedByUserId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual CompanyRole CompanyRole { get; set; }
        public virtual LearningResource LearningResource { get; set; }
        public virtual User ModifiedByUser { get; set; }
    }
}
