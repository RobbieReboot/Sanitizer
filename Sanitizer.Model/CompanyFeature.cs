using System;

namespace Sanitizer.Model
{
    public partial class CompanyFeature
    {
        public Guid CompanyFeatureId { get; set; }
        public bool RosteringEnabled { get; set; }
        public bool TrainingAndDevelopmentEnabled { get; set; }
        public bool SkillsEnabled { get; set; }
        public bool SkillSigningEnabled { get; set; }
        public bool RouteSigningEnabled { get; set; }
        public bool TractionSigningEnabled { get; set; }
        public bool EmployeeSignToStartSupportPlanIsCheckDefault { get; set; }
        public bool OtdrDetailsEnabled { get; set; }
        public bool YouEnabled { get; set; }
        public bool TwoFaenabled { get; set; }
        public bool TwoFauserAdministrationEnabled { get; set; }
        public bool Rdd { get; set; }

        public virtual Company CompanyFeatureNavigation { get; set; }
    }
}
