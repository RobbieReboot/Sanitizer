using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class UserTimeWithManager
    {
        public UserTimeWithManager()
        {
            UserTimeWithManagerDocument = new HashSet<UserTimeWithManagerDocument>();
        }

        public Guid UserTimeWithManagerId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public DateTime CompletedDate { get; set; }
        public Guid ManagerUserId { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? CompletedByUserId { get; set; }
        public Guid LocationId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual User CompletedByUser { get; set; }
        public virtual Location Location { get; set; }
        public virtual User ManagerUser { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<UserTimeWithManagerDocument> UserTimeWithManagerDocument { get; set; }
    }
}
