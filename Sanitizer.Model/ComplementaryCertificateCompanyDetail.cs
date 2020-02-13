using System;

namespace Sanitizer.Model
{
    public partial class ComplementaryCertificateCompanyDetail
    {
        public Guid ComplementaryCertificateCompanyDetailId { get; set; }
        public Guid CompanyId { get; set; }
        public string LegalName { get; set; }
        public string WorkingPlace { get; set; }
        public string InternalReferenceNumber { get; set; }
        public Guid CertificateTypeId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual CertificateType CertificateType { get; set; }
        public virtual Company Company { get; set; }
        public virtual ComplementaryCertificate ComplementaryCertificateCompanyDetailNavigation { get; set; }
    }
}
