using System;

namespace Sanitizer.Model
{
    public partial class UserSupportLevel
    {
        public Guid UserSupportLevelId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public Guid SupportLevelId { get; set; }
        public Guid? UpdatedByUserId { get; set; }
        public string Notes { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual SupportLevel SupportLevel { get; set; }
        public virtual User UpdatedByUser { get; set; }
        public virtual User User { get; set; }
    }
}
