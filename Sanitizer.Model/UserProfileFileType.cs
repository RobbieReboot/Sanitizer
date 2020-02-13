using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class UserProfileFileType
    {
        public UserProfileFileType()
        {
            UserProfileFile = new HashSet<UserProfileFile>();
        }

        public Guid UserProfileFileTypeId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<UserProfileFile> UserProfileFile { get; set; }
    }
}
