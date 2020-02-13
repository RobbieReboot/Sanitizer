using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class PrivateTeam
    {
        public PrivateTeam()
        {
            UserPrivateTeamMember = new HashSet<UserPrivateTeamMember>();
        }

        public Guid PrivateTeamId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User PrivateTeamNavigation { get; set; }
        public virtual ICollection<UserPrivateTeamMember> UserPrivateTeamMember { get; set; }
    }
}
