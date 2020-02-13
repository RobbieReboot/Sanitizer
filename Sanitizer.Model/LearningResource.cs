using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class LearningResource
    {
        public LearningResource()
        {
            LearningResourceCompanyRole = new HashSet<LearningResourceCompanyRole>();
            LearningResourceFile = new HashSet<LearningResourceFile>();
        }

        public Guid LearningResourceId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid LearningResourceMediaTypeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid ModifiedByUserId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual LearningResourceMediaType LearningResourceMediaType { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual ICollection<LearningResourceCompanyRole> LearningResourceCompanyRole { get; set; }
        public virtual ICollection<LearningResourceFile> LearningResourceFile { get; set; }
    }
}
