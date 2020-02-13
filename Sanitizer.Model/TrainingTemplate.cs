using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class TrainingTemplate
    {
        public TrainingTemplate()
        {
            InverseBaseTrainingTemplate = new HashSet<TrainingTemplate>();
            Training = new HashSet<Training>();
            TrainingTemplateDocument = new HashSet<TrainingTemplateDocument>();
            TrainingTemplateSkill = new HashSet<TrainingTemplateSkill>();
        }

        public Guid TrainingTemplateId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string CourseNo { get; set; }
        public int DurationHours { get; set; }
        public string Description { get; set; }
        public bool RequiresValidation { get; set; }
        public Guid ModifiedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool Expires { get; set; }
        public int? ValidForValue { get; set; }
        public Guid? ValidForUnitId { get; set; }
        public bool IsArchived { get; set; }
        public Guid? ArchivedByUserId { get; set; }
        public DateTime? DateArchived { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid BaseTrainingTemplateId { get; set; }

        public virtual User ArchivedByUser { get; set; }
        public virtual TrainingTemplate BaseTrainingTemplate { get; set; }
        public virtual Company Company { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual DurationUnit ValidForUnit { get; set; }
        public virtual TrainingTemplateClassroom TrainingTemplateClassroom { get; set; }
        public virtual TrainingTemplatePracticalDriving TrainingTemplatePracticalDriving { get; set; }
        public virtual TrainingTemplatePracticalGeneral TrainingTemplatePracticalGeneral { get; set; }
        public virtual ICollection<TrainingTemplate> InverseBaseTrainingTemplate { get; set; }
        public virtual ICollection<Training> Training { get; set; }
        public virtual ICollection<TrainingTemplateDocument> TrainingTemplateDocument { get; set; }
        public virtual ICollection<TrainingTemplateSkill> TrainingTemplateSkill { get; set; }
    }
}
