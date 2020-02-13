using System;

namespace Sanitizer.Model
{
    public partial class UserPasswordReset
    {
        public Guid UserPasswordResetId { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual User User { get; set; }
    }
}
