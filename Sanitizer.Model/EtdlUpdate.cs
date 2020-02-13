using System;

namespace Sanitizer.Model
{
    public partial class EtdlUpdate
    {
        public Guid EtdlUpdateId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid EtdlUpdateTypeId { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public bool IsDeleted { get; set; }
        public Guid EtdlApplicationId { get; set; }

        public virtual Company Company { get; set; }
        public virtual EtdlApplication EtdlApplication { get; set; }
        public virtual EtdlUpdateType EtdlUpdateType { get; set; }
    }
}
