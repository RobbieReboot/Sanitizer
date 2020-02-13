using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class CompanyDocumentType
    {
        public CompanyDocumentType()
        {
            CompanyDocument = new HashSet<CompanyDocument>();
        }

        public Guid CompanyDocumentTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CompanyDocument> CompanyDocument { get; set; }
    }
}
