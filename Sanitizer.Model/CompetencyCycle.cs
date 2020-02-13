using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class CompetencyCycle
    {
        public CompetencyCycle()
        {
            AssessmentCompetencyCycle = new HashSet<Assessment>();
            AssessmentInitialCompetencyCycle = new HashSet<Assessment>();
            CompetencyCycleAssessmentWindow = new HashSet<CompetencyCycleAssessmentWindow>();
            CompetencyCycleCriteria = new HashSet<CompetencyCycleCriteria>();
            ForceUpdateCompetencyCycleQueue = new HashSet<ForceUpdateCompetencyCycleQueue>();
            InverseBaseCompetencyCycle = new HashSet<CompetencyCycle>();
            UserCompanyRole = new HashSet<UserCompanyRole>();
            UserCompanyRoleArchive = new HashSet<UserCompanyRoleArchive>();
            UserEndedCompetencyCycle = new HashSet<UserEndedCompetencyCycle>();
        }

        public Guid CompetencyCycleId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid CompanyRoleId { get; set; }
        public string Name { get; set; }
        public int NumberOfMonths { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsArchived { get; set; }
        public Guid? ArchivedByUserId { get; set; }
        public DateTime? DateArchived { get; set; }
        public Guid BaseCompetencyCycleId { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual User ArchivedByUser { get; set; }
        public virtual CompetencyCycle BaseCompetencyCycle { get; set; }
        public virtual Company Company { get; set; }
        public virtual CompanyRole CompanyRole { get; set; }
        public virtual ICollection<Assessment> AssessmentCompetencyCycle { get; set; }
        public virtual ICollection<Assessment> AssessmentInitialCompetencyCycle { get; set; }
        public virtual ICollection<CompetencyCycleAssessmentWindow> CompetencyCycleAssessmentWindow { get; set; }
        public virtual ICollection<CompetencyCycleCriteria> CompetencyCycleCriteria { get; set; }
        public virtual ICollection<ForceUpdateCompetencyCycleQueue> ForceUpdateCompetencyCycleQueue { get; set; }
        public virtual ICollection<CompetencyCycle> InverseBaseCompetencyCycle { get; set; }
        public virtual ICollection<UserCompanyRole> UserCompanyRole { get; set; }
        public virtual ICollection<UserCompanyRoleArchive> UserCompanyRoleArchive { get; set; }
        public virtual ICollection<UserEndedCompetencyCycle> UserEndedCompetencyCycle { get; set; }
    }
}
