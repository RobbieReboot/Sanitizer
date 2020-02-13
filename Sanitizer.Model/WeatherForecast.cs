using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class WeatherForecast
    {
        public WeatherForecast()
        {
            AssessmentConditionCardEndWeatherForecast = new HashSet<AssessmentConditionCard>();
            AssessmentConditionCardStartWeatherForecast = new HashSet<AssessmentConditionCard>();
        }

        public Guid WeatherForecastId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<AssessmentConditionCard> AssessmentConditionCardEndWeatherForecast { get; set; }
        public virtual ICollection<AssessmentConditionCard> AssessmentConditionCardStartWeatherForecast { get; set; }
    }
}
