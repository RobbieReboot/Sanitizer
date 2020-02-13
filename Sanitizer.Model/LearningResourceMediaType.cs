using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class LearningResourceMediaType
    {
        public LearningResourceMediaType()
        {
            LearningResource = new HashSet<LearningResource>();
        }

        public Guid LearningResourceMediaTypeId { get; set; }
        public string Reference { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LearningResource> LearningResource { get; set; }
    }
}
