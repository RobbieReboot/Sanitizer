using System;

namespace Sanitizer.Model
{
    public partial class Task
    {
        public Guid TaskId { get; set; }
        public string Reference { get; set; }
        public DateTime NextProcessDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public int IntervalMinutes { get; set; }
    }
}
