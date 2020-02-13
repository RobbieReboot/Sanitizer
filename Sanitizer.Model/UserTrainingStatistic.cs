using System;

namespace Sanitizer.Model
{
    public partial class UserTrainingStatistic
    {
        public Guid UserId { get; set; }
        public int? ClassroomDurationMinutesForYear { get; set; }
        public int? PracticalDurationMinutesForYear { get; set; }
        public int? PracticalDrivingMinutesForYear { get; set; }
        public int? PracticalDayDrivingMinutesForWeek { get; set; }
        public int? PracticalNightDrivingMinutesForWeek { get; set; }

        public virtual User User { get; set; }
    }
}
