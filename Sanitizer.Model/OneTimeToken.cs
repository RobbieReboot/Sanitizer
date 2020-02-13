using System;

namespace Sanitizer.Model
{
    public partial class OneTimeToken
    {
        public Guid OneTimeTokenId { get; set; }
        public string TokenType { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Guid CreatedByUserId { get; set; }

        public virtual User CreatedByUser { get; set; }
    }
}
