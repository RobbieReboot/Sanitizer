using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class EtdlApplicationFileType
    {
        public EtdlApplicationFileType()
        {
            EtdlApplicationFile = new HashSet<EtdlApplicationFile>();
        }

        public Guid EtdlApplicationFileTypeId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<EtdlApplicationFile> EtdlApplicationFile { get; set; }
    }
}
