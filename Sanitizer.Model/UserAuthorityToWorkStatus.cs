using System;

namespace Sanitizer.Model
{
    public partial class UserAuthorityToWorkStatus
    {
        public Guid UserAuthorityToWorkStatusId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public Guid EmployeeAuthorityToWorkStatusId { get; set; }
        public Guid? UpdatedByUserId { get; set; }
        public string Notes { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual EmployeeAuthorityToWorkStatus EmployeeAuthorityToWorkStatus { get; set; }
        public virtual User UpdatedByUser { get; set; }
        public virtual User User { get; set; }
    }
}
