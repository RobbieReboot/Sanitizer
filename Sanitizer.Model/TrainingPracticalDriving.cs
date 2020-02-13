using System;

namespace Sanitizer.Model
{
    public partial class TrainingPracticalDriving
    {
        public Guid TrainingPracticalDrivingId { get; set; }
        public int DayDrivingMinutes { get; set; }
        public int NightDrivingMinutes { get; set; }
        public int PbcDrivingMinutes { get; set; }
        public int ThreeStepBrakeTrainingMinutes { get; set; }
        public Guid TractionId { get; set; }
        public string InstructorName { get; set; }

        public virtual Traction Traction { get; set; }
        public virtual Training TrainingPracticalDrivingNavigation { get; set; }
    }
}
