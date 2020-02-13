using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class ComplementaryCertificate
    {
        public ComplementaryCertificate()
        {
            ComplementaryCertificateDateInfo = new HashSet<ComplementaryCertificateDateInfo>();
            ComplementaryCertificateFile = new HashSet<ComplementaryCertificateFile>();
        }

        public Guid ComplementaryCertificateId { get; set; }
        public Guid CompanyId { get; set; }
        public string InternalReferenceNumber { get; set; }
        public string IssuingOrganisation { get; set; }
        public string LicenceEuropeanIdentificationNumber { get; set; }
        public DateTime IssuingDateDeprecated { get; set; }
        public DateTime ExpiryDateDeprecated { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateArchived { get; set; }
        public Guid? ArchivedByUserId { get; set; }
        public string EmployeeReference { get; set; }
        public DateTime? SubmittedDateDeprecated { get; set; }
        public bool IsArchived { get; set; }
        public Guid EtdlApplicationId { get; set; }
        public Guid? AddressId { get; set; }
        public Guid? SubmittedByUserIdDeprecated { get; set; }

        public virtual Address Address { get; set; }
        public virtual User ArchivedByUser { get; set; }
        public virtual Company Company { get; set; }
        public virtual EtdlApplication EtdlApplication { get; set; }
        public virtual User SubmittedByUserIdDeprecatedNavigation { get; set; }
        public virtual ComplementaryCertificateCompanyDetail ComplementaryCertificateCompanyDetail { get; set; }
        public virtual ComplementaryCertificateUserDetail ComplementaryCertificateUserDetail { get; set; }
        public virtual ICollection<ComplementaryCertificateDateInfo> ComplementaryCertificateDateInfo { get; set; }
        public virtual ICollection<ComplementaryCertificateFile> ComplementaryCertificateFile { get; set; }
    }
}
