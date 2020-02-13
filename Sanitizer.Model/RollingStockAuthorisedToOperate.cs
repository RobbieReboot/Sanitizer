using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class RollingStockAuthorisedToOperate
    {
        public RollingStockAuthorisedToOperate()
        {
            RollingStockAuthorisedToOperateSigningHistory = new HashSet<RollingStockAuthorisedToOperateSigningHistory>();
        }

        public Guid RollingStockAuthorisedToOperateId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserCompanyRoleId { get; set; }
        public DateTime Date { get; set; }
        public Guid TractionId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? ExpiryDateTime { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual Traction Traction { get; set; }
        public virtual UserCompanyRole UserCompanyRole { get; set; }
        public virtual ICollection<RollingStockAuthorisedToOperateSigningHistory> RollingStockAuthorisedToOperateSigningHistory { get; set; }
    }
}
