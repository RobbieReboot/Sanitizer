using System;

namespace Sanitizer.Model
{
    public partial class CertificateApplicationStatus
    {
        public Guid CertificateApplicationStatusId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
