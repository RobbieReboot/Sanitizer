using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class AssessmentConditionCard
    {
        public AssessmentConditionCard()
        {
            AssessmentConditionCardRoute = new HashSet<AssessmentConditionCardRoute>();
            AssessmentCriteriaCard = new HashSet<AssessmentCriteriaCard>();
        }

        public Guid AssessmentConditionCardId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? StartRailheadConditionId { get; set; }
        public Guid? EndRailheadConditionId { get; set; }
        public Guid? StartVisibilityId { get; set; }
        public Guid? EndVisibilityId { get; set; }
        public Guid? StartUnderfootConditionId { get; set; }
        public Guid? EndUnderfootConditionId { get; set; }
        public Guid? StartWeatherForecastId { get; set; }
        public Guid? EndWeatherForecastId { get; set; }
        public Guid? StartLocationId { get; set; }
        public Guid? EndLocationId { get; set; }
        public string TrainHeadcode { get; set; }
        public Guid? TractionId { get; set; }
        public string TrainConsist { get; set; }
        public DateTime? DepartureTime { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public string UnitNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Company Company { get; set; }
        public virtual Location EndLocation { get; set; }
        public virtual RailheadCondition EndRailheadCondition { get; set; }
        public virtual UnderfootCondition EndUnderfootCondition { get; set; }
        public virtual Visibility EndVisibility { get; set; }
        public virtual WeatherForecast EndWeatherForecast { get; set; }
        public virtual Location StartLocation { get; set; }
        public virtual RailheadCondition StartRailheadCondition { get; set; }
        public virtual UnderfootCondition StartUnderfootCondition { get; set; }
        public virtual Visibility StartVisibility { get; set; }
        public virtual WeatherForecast StartWeatherForecast { get; set; }
        public virtual Traction Traction { get; set; }
        public virtual ICollection<AssessmentConditionCardRoute> AssessmentConditionCardRoute { get; set; }
        public virtual ICollection<AssessmentCriteriaCard> AssessmentCriteriaCard { get; set; }
    }
}
