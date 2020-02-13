using System;

namespace Sanitizer.Model
{
    public partial class AssessmentOtdrDetail
    {
        public Guid AssessmentOtdrDetailId { get; set; }
        public string LocationText { get; set; }
        public Guid RouteId { get; set; }
        public bool HighRisk { get; set; }
        public Guid SpeedRestrictionTypeId { get; set; }
        public int AdvertisedSpeed { get; set; }
        public int ActualSpeed { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsCompliant { get; set; }
        public Guid LocationId { get; set; }

        public virtual Assessment AssessmentOtdrDetailNavigation { get; set; }
        public virtual Location Location { get; set; }
        public virtual Route Route { get; set; }
        public virtual SpeedRestrictionType SpeedRestrictionType { get; set; }
    }
}
