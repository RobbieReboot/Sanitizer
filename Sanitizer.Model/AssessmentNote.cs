using System;

namespace Sanitizer.Model
{
    public partial class AssessmentNote
    {
        public Guid AssessmentNoteId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid AssessmentId { get; set; }
        public string Note { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid ModifiedByUserId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Assessment Assessment { get; set; }
        public virtual Company Company { get; set; }
        public virtual User ModifiedByUser { get; set; }
    }
}
