using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class InfrastructureAuthorisedToOperate
    {
        public InfrastructureAuthorisedToOperate()
        {
            InfrastructureAuthorisedToOperateSigningHistory = new HashSet<InfrastructureAuthorisedToOperateSigningHistory>();
        }

        public Guid InfrastructureAuthorisedToOperateId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserCompanyRoleId { get; set; }
        public DateTime Date { get; set; }
        public Guid RouteId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? ExpiryDateTime { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual Route Route { get; set; }
        public virtual UserCompanyRole UserCompanyRole { get; set; }
        public virtual ICollection<InfrastructureAuthorisedToOperateSigningHistory> InfrastructureAuthorisedToOperateSigningHistory { get; set; }
    }
}
