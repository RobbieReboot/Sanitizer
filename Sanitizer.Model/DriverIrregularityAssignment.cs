using System;

namespace Sanitizer.Model
{
    public partial class DriverIrregularityAssignment
    {
        public Guid AssignmentId { get; set; }
        public Guid DriverIrregularityId { get; set; }
        public DateTime TimeAssigned { get; set; }
        public Guid? UserId { get; set; }

        public virtual DriverIrregularity DriverIrregularity { get; set; }
        public virtual User User { get; set; }
    }
}
