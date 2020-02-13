using System;

namespace Sanitizer.Model
{
    public partial class UserPreference
    {
        public Guid UserPreferenceId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? DashboardLastSelectedTeamId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Company Company { get; set; }
        public virtual Team DashboardLastSelectedTeam { get; set; }
        public virtual User UserPreferenceNavigation { get; set; }
    }
}
