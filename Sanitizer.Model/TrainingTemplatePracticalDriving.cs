using System;

namespace Sanitizer.Model
{
    public partial class TrainingTemplatePracticalDriving
    {
        public Guid TrainingTemplatePracticalDrivingId { get; set; }
        public int DayDrivingMinutes { get; set; }
        public int NightDrivingMinutes { get; set; }
        public int PbcDrivingMinutes { get; set; }
        public int ThreeStepBrakeDrivingMinutes { get; set; }
        public Guid TractionId { get; set; }
        public string InstructorName { get; set; }

        public virtual Traction Traction { get; set; }
        public virtual TrainingTemplate TrainingTemplatePracticalDrivingNavigation { get; set; }
    }
}
