using System;

namespace Sanitizer.Model
{
    public partial class UserPrivateTeamMember
    {
        public Guid UserPrivateTeamMemberId { get; set; }
        public Guid PrivateTeamId { get; set; }
        public Guid UserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual PrivateTeam PrivateTeam { get; set; }
        public virtual User User { get; set; }
    }
}
