using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class VerificationStatementCategory
    {
        public VerificationStatementCategory()
        {
            VerificationStatement = new HashSet<VerificationStatement>();
        }

        public Guid VerificationStatementCategoryId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<VerificationStatement> VerificationStatement { get; set; }
    }
}
