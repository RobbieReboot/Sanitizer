using System;

namespace Sanitizer.Model
{
    public partial class AssessmentDeadline
    {
        public Guid AssessmentDeadlineId { get; set; }
        public string Reference { get; set; }
        public string Colour { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
