using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class CompanyRole
    {
        public CompanyRole()
        {
            Assessment = new HashSet<Assessment>();
            AssessmentTaskCompanyRole = new HashSet<AssessmentTaskCompanyRole>();
            CompetencyCycle = new HashSet<CompetencyCycle>();
            EtdlUserDetail = new HashSet<EtdlUserDetail>();
            LearningResourceCompanyRole = new HashSet<LearningResourceCompanyRole>();
            Skill = new HashSet<Skill>();
            UserCompanyRole = new HashSet<UserCompanyRole>();
            UserCompanyRoleArchive = new HashSet<UserCompanyRoleArchive>();
        }

        public Guid CompanyRoleId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Assessment> Assessment { get; set; }
        public virtual ICollection<AssessmentTaskCompanyRole> AssessmentTaskCompanyRole { get; set; }
        public virtual ICollection<CompetencyCycle> CompetencyCycle { get; set; }
        public virtual ICollection<EtdlUserDetail> EtdlUserDetail { get; set; }
        public virtual ICollection<LearningResourceCompanyRole> LearningResourceCompanyRole { get; set; }
        public virtual ICollection<Skill> Skill { get; set; }
        public virtual ICollection<UserCompanyRole> UserCompanyRole { get; set; }
        public virtual ICollection<UserCompanyRoleArchive> UserCompanyRoleArchive { get; set; }
    }
}
