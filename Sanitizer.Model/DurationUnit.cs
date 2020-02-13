using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class DurationUnit
    {
        public DurationUnit()
        {
            Route = new HashSet<Route>();
            Skill = new HashSet<Skill>();
            Traction = new HashSet<Traction>();
            TrainingTemplate = new HashSet<TrainingTemplate>();
        }

        public Guid DurationUnitId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int OrderIndex { get; set; }

        public virtual ICollection<Route> Route { get; set; }
        public virtual ICollection<Skill> Skill { get; set; }
        public virtual ICollection<Traction> Traction { get; set; }
        public virtual ICollection<TrainingTemplate> TrainingTemplate { get; set; }
    }
}
