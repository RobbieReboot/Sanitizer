using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class SystemRole
    {
        public SystemRole()
        {
            User = new HashSet<User>();
        }

        public Guid SystemRoleId { get; set; }
        public string Reference { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
