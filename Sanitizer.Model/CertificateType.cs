using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class CertificateType
    {
        public CertificateType()
        {
            ComplementaryCertificateCompanyDetail = new HashSet<ComplementaryCertificateCompanyDetail>();
        }

        public Guid CertificateTypeId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public short OrderIndex { get; set; }
        public bool DefaultSelection { get; set; }

        public virtual ICollection<ComplementaryCertificateCompanyDetail> ComplementaryCertificateCompanyDetail { get; set; }
    }
}
