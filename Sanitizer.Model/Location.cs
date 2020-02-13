using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Location
    {
        public Location()
        {
            AssessmentConditionCardEndLocation = new HashSet<AssessmentConditionCard>();
            AssessmentConditionCardStartLocation = new HashSet<AssessmentConditionCard>();
            AssessmentOtdrDetail = new HashSet<AssessmentOtdrDetail>();
            Department = new HashSet<Department>();
            Team = new HashSet<Team>();
            TrainingPracticalGeneral = new HashSet<TrainingPracticalGeneral>();
            TrainingTemplatePracticalGeneral = new HashSet<TrainingTemplatePracticalGeneral>();
            UserProfile = new HashSet<UserProfile>();
            UserTimeWithManager = new HashSet<UserTimeWithManager>();
        }

        public Guid LocationId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool? UserAssignable { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<AssessmentConditionCard> AssessmentConditionCardEndLocation { get; set; }
        public virtual ICollection<AssessmentConditionCard> AssessmentConditionCardStartLocation { get; set; }
        public virtual ICollection<AssessmentOtdrDetail> AssessmentOtdrDetail { get; set; }
        public virtual ICollection<Department> Department { get; set; }
        public virtual ICollection<Team> Team { get; set; }
        public virtual ICollection<TrainingPracticalGeneral> TrainingPracticalGeneral { get; set; }
        public virtual ICollection<TrainingTemplatePracticalGeneral> TrainingTemplatePracticalGeneral { get; set; }
        public virtual ICollection<UserProfile> UserProfile { get; set; }
        public virtual ICollection<UserTimeWithManager> UserTimeWithManager { get; set; }
    }
}
