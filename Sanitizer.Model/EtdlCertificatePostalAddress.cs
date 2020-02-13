using System;

namespace Sanitizer.Model
{
    public partial class EtdlCertificatePostalAddress
    {
        public Guid EtdlCertificatePostalAddressId { get; set; }
        public string Name { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public Guid? CountryId { get; set; }
        public string PostCode { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Country Country { get; set; }
    }
}
