using System;

namespace Sanitizer.Model
{
    public partial class UserDepartmentAccess
    {
        public Guid UserDepartmentAccessId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public Guid DepartmentId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual Department Department { get; set; }
        public virtual User User { get; set; }
    }
}
