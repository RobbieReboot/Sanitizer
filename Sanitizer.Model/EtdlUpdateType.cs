using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class EtdlUpdateType
    {
        public EtdlUpdateType()
        {
            EtdlUpdate = new HashSet<EtdlUpdate>();
        }

        public Guid EtdlUpdateTypeId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<EtdlUpdate> EtdlUpdate { get; set; }
    }
}
