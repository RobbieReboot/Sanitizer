using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Department
    {
        public Department()
        {
            Team = new HashSet<Team>();
            UserDepartment = new HashSet<User>();
            UserDepartmentAccess = new HashSet<UserDepartmentAccess>();
            UserRosteringDepartment = new HashSet<User>();
        }

        public Guid DepartmentId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? LocationId { get; set; }
        public string Code { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Team> Team { get; set; }
        public virtual ICollection<User> UserDepartment { get; set; }
        public virtual ICollection<UserDepartmentAccess> UserDepartmentAccess { get; set; }
        public virtual ICollection<User> UserRosteringDepartment { get; set; }
    }
}
