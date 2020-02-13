using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class DriverIrregularity
    {
        public DriverIrregularity()
        {
            DriverIrregularityAssignment = new HashSet<DriverIrregularityAssignment>();
        }

        public Guid DriverIrregularityId { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public Guid ModifiedByUserId { get; set; }
        public string OtdrPin { get; set; }
        public string Headcode { get; set; }
        public string TriggerName { get; set; }
        public DateTime TimeEntered { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public Guid? JourneyId { get; set; }
        public string Notes { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<DriverIrregularityAssignment> DriverIrregularityAssignment { get; set; }
    }
}
