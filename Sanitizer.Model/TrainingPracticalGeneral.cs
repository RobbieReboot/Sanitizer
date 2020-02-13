using System;

namespace Sanitizer.Model
{
    public partial class TrainingPracticalGeneral
    {
        public Guid TrainingPracticalGeneralId { get; set; }
        public Guid LocationId { get; set; }
        public int DayTrainingMinutes { get; set; }
        public int NightTrainingMinutes { get; set; }
        public string InstructorName { get; set; }

        public virtual Location Location { get; set; }
        public virtual Training TrainingPracticalGeneralNavigation { get; set; }
    }
}
