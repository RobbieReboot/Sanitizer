using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class UserCompanyRole
    {
        public UserCompanyRole()
        {
            InfrastructureAuthorisedToOperate = new HashSet<InfrastructureAuthorisedToOperate>();
            RollingStockAuthorisedToOperate = new HashSet<RollingStockAuthorisedToOperate>();
            SupportPlan = new HashSet<SupportPlan>();
            UserCompanyRoleDateOfProductiveDuty = new HashSet<UserCompanyRoleDateOfProductiveDuty>();
            UserCompanyRoleRecertificationDate = new HashSet<UserCompanyRoleRecertificationDate>();
            UserSkill = new HashSet<UserSkill>();
        }

        public Guid UserCompanyRoleId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public Guid CompanyRoleId { get; set; }
        public Guid? CompetencyCycleId { get; set; }
        public DateTime? CompetencyCycleStartDate { get; set; }
        public DateTime? CompetencyCycleEndDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual CompanyRole CompanyRole { get; set; }
        public virtual CompetencyCycle CompetencyCycle { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<InfrastructureAuthorisedToOperate> InfrastructureAuthorisedToOperate { get; set; }
        public virtual ICollection<RollingStockAuthorisedToOperate> RollingStockAuthorisedToOperate { get; set; }
        public virtual ICollection<SupportPlan> SupportPlan { get; set; }
        public virtual ICollection<UserCompanyRoleDateOfProductiveDuty> UserCompanyRoleDateOfProductiveDuty { get; set; }
        public virtual ICollection<UserCompanyRoleRecertificationDate> UserCompanyRoleRecertificationDate { get; set; }
        public virtual ICollection<UserSkill> UserSkill { get; set; }
    }
}
