using System;

namespace Sanitizer.Model
{
    public partial class UserToken
    {
        public Guid UserTokenId { get; set; }
        public string Token { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsPermanent { get; set; }

        public virtual User UserTokenNavigation { get; set; }
    }
}
