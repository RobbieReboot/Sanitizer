using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class VerificationStatement
    {
        public VerificationStatement()
        {
            AssessmentVerificationStatement = new HashSet<AssessmentVerificationStatement>();
            SupportPlanVerificationStatement = new HashSet<SupportPlanVerificationStatement>();
        }

        public Guid VerificationStatementId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid VerificationStatementCategoryId { get; set; }
        public string Statement { get; set; }
        public int OrderIndex { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsArchived { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual VerificationStatementCategory VerificationStatementCategory { get; set; }
        public virtual ICollection<AssessmentVerificationStatement> AssessmentVerificationStatement { get; set; }
        public virtual ICollection<SupportPlanVerificationStatement> SupportPlanVerificationStatement { get; set; }
    }
}
