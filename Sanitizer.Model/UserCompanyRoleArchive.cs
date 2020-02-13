using System;

namespace Sanitizer.Model
{
    public partial class UserCompanyRoleArchive
    {
        public Guid UserCompanyRoleArchiveId { get; set; }
        public Guid UserId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid CompanyRoleId { get; set; }
        public Guid CompetencyCycleId { get; set; }
        public DateTime CompetencyCycleStartDate { get; set; }
        public DateTime CompetencyCycleEndDate { get; set; }
        public DateTime? RecertificationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual CompanyRole CompanyRole { get; set; }
        public virtual CompetencyCycle CompetencyCycle { get; set; }
        public virtual User User { get; set; }
    }
}
