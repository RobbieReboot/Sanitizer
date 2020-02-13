using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class AssessorVerificationResponse
    {
        public AssessorVerificationResponse()
        {
            Assessment = new HashSet<Assessment>();
            SupportPlan = new HashSet<SupportPlan>();
        }

        public Guid AssessorVerificationResponseId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Assessment> Assessment { get; set; }
        public virtual ICollection<SupportPlan> SupportPlan { get; set; }
    }
}
