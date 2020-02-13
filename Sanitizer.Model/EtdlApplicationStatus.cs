using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class EtdlApplicationStatus
    {
        public EtdlApplicationStatus()
        {
            EtdlApplication = new HashSet<EtdlApplication>();
        }

        public Guid EtdlApplicationStatusId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<EtdlApplication> EtdlApplication { get; set; }
    }
}
