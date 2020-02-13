using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class EtdlApplicationType
    {
        public EtdlApplicationType()
        {
            EtdlApplicationDetail = new HashSet<EtdlApplicationDetail>();
        }

        public Guid EtdlApplicationTypeId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<EtdlApplicationDetail> EtdlApplicationDetail { get; set; }
    }
}
