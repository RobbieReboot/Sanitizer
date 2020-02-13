using System;

namespace Sanitizer.Model
{
    public partial class UserCompanyRoleDateOfProductiveDuty
    {
        public Guid UserCompanyRoleDateOfProductiveDutyId { get; set; }
        public Guid UserCompanyRoleId { get; set; }
        public DateTime DateOfFirstProductiveDutyOverride { get; set; }
        public Guid UpdatedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User UpdatedByUser { get; set; }
        public virtual UserCompanyRole UserCompanyRole { get; set; }
    }
}
