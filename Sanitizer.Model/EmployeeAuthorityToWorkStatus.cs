using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class EmployeeAuthorityToWorkStatus
    {
        public EmployeeAuthorityToWorkStatus()
        {
            UserAuthorityToWorkStatus = new HashSet<UserAuthorityToWorkStatus>();
        }

        public Guid EmployeeAuthorityToWorkStatusId { get; set; }
        public string Reference { get; set; }
        public string Colour { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<UserAuthorityToWorkStatus> UserAuthorityToWorkStatus { get; set; }
    }
}
