using System;

namespace Sanitizer.Model
{
    public partial class AssessmentTaskCompanyRole
    {
        public Guid AssessmentTaskCompanyRoleId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid AssessmentTaskId { get; set; }
        public Guid CompanyRoleId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual AssessmentTask AssessmentTask { get; set; }
        public virtual Company Company { get; set; }
        public virtual CompanyRole CompanyRole { get; set; }
    }
}
