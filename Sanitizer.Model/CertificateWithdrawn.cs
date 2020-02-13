using System;

namespace Sanitizer.Model
{
    public partial class CertificateWithdrawn
    {
        public Guid CertificateWithdrawnId { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime DateReported { get; set; }
        public Guid EtdlApplicationId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual EtdlApplication EtdlApplication { get; set; }
    }
}
