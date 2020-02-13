using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Country
    {
        public Country()
        {
            Address = new HashSet<Address>();
            EtdlCertificatePostalAddress = new HashSet<EtdlCertificatePostalAddress>();
            SafetyOrganisation = new HashSet<SafetyOrganisation>();
        }

        public Guid CountryId { get; set; }
        public string Reference { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<EtdlCertificatePostalAddress> EtdlCertificatePostalAddress { get; set; }
        public virtual ICollection<SafetyOrganisation> SafetyOrganisation { get; set; }
    }
}
