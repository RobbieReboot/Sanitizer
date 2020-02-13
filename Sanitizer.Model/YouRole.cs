using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class YouRole
    {
        public YouRole()
        {
            User = new HashSet<User>();
        }

        public Guid YouRoleId { get; set; }
        public Guid CompanyId { get; set; }
        public string Reference { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDateTime { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
