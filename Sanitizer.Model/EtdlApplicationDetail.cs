using System;

namespace Sanitizer.Model
{
    public partial class EtdlApplicationDetail
    {
        public Guid EtdlApplicationDetailId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid EtdlApplicationTypeId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string SafetyOrganisationAppliedTo { get; set; }
        public Guid SafetyOrganisationAppliedToAddressId { get; set; }
        public string LicenceEuropeanIdentificationNumber { get; set; }
        public DateTime? DateOfFirstIssue { get; set; }
        public string AccompanyingDocumentationNotes { get; set; }

        public virtual Company Company { get; set; }
        public virtual EtdlApplication EtdlApplicationDetailNavigation { get; set; }
        public virtual EtdlApplicationType EtdlApplicationType { get; set; }
        public virtual Address SafetyOrganisationAppliedToAddress { get; set; }
    }
}
