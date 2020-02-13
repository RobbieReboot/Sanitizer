using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Training
    {
        public Training()
        {
            TrainingDocument = new HashSet<TrainingDocument>();
            UserSkill = new HashSet<UserSkill>();
        }

        public Guid TrainingId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string CourseNo { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int DurationHours { get; set; }
        public string Description { get; set; }
        public Guid ModifiedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool RequiresValidation { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? ValidFromDateTime { get; set; }
        public DateTime? ValidToDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public Guid TrainingTemplateId { get; set; }
        public bool IsArchived { get; set; }
        public Guid? ArchivedByUserId { get; set; }
        public DateTime? DateArchived { get; set; }

        public virtual User ArchivedByUser { get; set; }
        public virtual Company Company { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual TrainingTemplate TrainingTemplate { get; set; }
        public virtual User User { get; set; }
        public virtual TrainingClassroom TrainingClassroom { get; set; }
        public virtual TrainingPracticalDriving TrainingPracticalDriving { get; set; }
        public virtual TrainingPracticalGeneral TrainingPracticalGeneral { get; set; }
        public virtual ICollection<TrainingDocument> TrainingDocument { get; set; }
        public virtual ICollection<UserSkill> UserSkill { get; set; }
    }
}
