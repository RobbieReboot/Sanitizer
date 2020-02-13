using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Address
    {
        public Address()
        {
            CompanyNavigation = new HashSet<Company>();
            ComplementaryCertificate = new HashSet<ComplementaryCertificate>();
            ComplementaryCertificateCompanyDetail = new HashSet<ComplementaryCertificateCompanyDetail>();
            ComplementaryCertificateUserDetail = new HashSet<ComplementaryCertificateUserDetail>();
            EtdlApplicationDetail = new HashSet<EtdlApplicationDetail>();
            EtdlCompanyDetail = new HashSet<EtdlCompanyDetail>();
            EtdlUserDetailPermanentAddress = new HashSet<EtdlUserDetail>();
            EtdlUserDetailPostalAddress = new HashSet<EtdlUserDetail>();
            IssuingOrganisation = new HashSet<IssuingOrganisation>();
            MedicalPractitioner = new HashSet<MedicalPractitioner>();
            UserProfile = new HashSet<UserProfile>();
        }

        public Guid AddressId { get; set; }
        public Guid CompanyId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public Guid? CountryId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Company> CompanyNavigation { get; set; }
        public virtual ICollection<ComplementaryCertificate> ComplementaryCertificate { get; set; }
        public virtual ICollection<ComplementaryCertificateCompanyDetail> ComplementaryCertificateCompanyDetail { get; set; }
        public virtual ICollection<ComplementaryCertificateUserDetail> ComplementaryCertificateUserDetail { get; set; }
        public virtual ICollection<EtdlApplicationDetail> EtdlApplicationDetail { get; set; }
        public virtual ICollection<EtdlCompanyDetail> EtdlCompanyDetail { get; set; }
        public virtual ICollection<EtdlUserDetail> EtdlUserDetailPermanentAddress { get; set; }
        public virtual ICollection<EtdlUserDetail> EtdlUserDetailPostalAddress { get; set; }
        public virtual ICollection<IssuingOrganisation> IssuingOrganisation { get; set; }
        public virtual ICollection<MedicalPractitioner> MedicalPractitioner { get; set; }
        public virtual ICollection<UserProfile> UserProfile { get; set; }
    }
}
