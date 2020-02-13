using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class EtdlApplication
    {
        public EtdlApplication()
        {
            CertificateLost = new HashSet<CertificateLost>();
            CertificateStolen = new HashSet<CertificateStolen>();
            CertificateWithdrawn = new HashSet<CertificateWithdrawn>();
            ComplementaryCertificate = new HashSet<ComplementaryCertificate>();
            EtdlApplicationFile = new HashSet<EtdlApplicationFile>();
            EtdlUpdate = new HashSet<EtdlUpdate>();
        }

        public Guid EtdlApplicationId { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public Guid EtdlApplicationStatusId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool DeclareInformationIsCorrect { get; set; }
        public bool DataProtectionConfirmed { get; set; }
        public DateTime? DateCompleted { get; set; }
        public bool IsArchived { get; set; }
        public DateTime? DateArchived { get; set; }
        public Guid? ArchivedByUserId { get; set; }
        public Guid? SubmittedByUserId { get; set; }

        public virtual User ArchivedByUser { get; set; }
        public virtual Company Company { get; set; }
        public virtual EtdlApplicationStatus EtdlApplicationStatus { get; set; }
        public virtual User SubmittedByUser { get; set; }
        public virtual EtdlApplicationDetail EtdlApplicationDetail { get; set; }
        public virtual EtdlCompanyDetail EtdlCompanyDetail { get; set; }
        public virtual EtdlUserDetail EtdlUserDetail { get; set; }
        public virtual ICollection<CertificateLost> CertificateLost { get; set; }
        public virtual ICollection<CertificateStolen> CertificateStolen { get; set; }
        public virtual ICollection<CertificateWithdrawn> CertificateWithdrawn { get; set; }
        public virtual ICollection<ComplementaryCertificate> ComplementaryCertificate { get; set; }
        public virtual ICollection<EtdlApplicationFile> EtdlApplicationFile { get; set; }
        public virtual ICollection<EtdlUpdate> EtdlUpdate { get; set; }
    }
}
