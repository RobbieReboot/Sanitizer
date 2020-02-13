using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class IssuingOrganisation
    {
        public IssuingOrganisation()
        {
            Company = new HashSet<Company>();
        }

        public Guid IssuingOrganisationId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public Guid AddressId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Address Address { get; set; }
        public virtual Company CompanyNavigation { get; set; }
        public virtual ICollection<Company> Company { get; set; }
    }
}
