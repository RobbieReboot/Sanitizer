using System;

namespace Sanitizer.Model
{
    public partial class UserTeam
    {
        public Guid UserTeamId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public Guid TeamId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual Team Team { get; set; }
        public virtual User User { get; set; }
    }
}
