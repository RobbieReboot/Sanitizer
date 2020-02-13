using System;

namespace Sanitizer.Model
{
    public partial class UserCompanyRoleRecertificationDate
    {
        public Guid UserCompanyRoleRecertificationDateId { get; set; }
        public Guid UserCompanyRoleId { get; set; }
        public DateTime RecertificationDate { get; set; }
        public Guid UpdatedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User UpdatedByUser { get; set; }
        public virtual UserCompanyRole UserCompanyRole { get; set; }
    }
}
