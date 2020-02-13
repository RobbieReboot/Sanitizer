using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Team
    {
        public Team()
        {
            TeamOwner = new HashSet<TeamOwner>();
            UserPreference = new HashSet<UserPreference>();
            UserTeam = new HashSet<UserTeam>();
        }

        public Guid TeamId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? BaseLocationId { get; set; }
        public Guid? DepartmentId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool? MakeAvailableOnIpad { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Location BaseLocation { get; set; }
        public virtual Company Company { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<TeamOwner> TeamOwner { get; set; }
        public virtual ICollection<UserPreference> UserPreference { get; set; }
        public virtual ICollection<UserTeam> UserTeam { get; set; }
    }
}
