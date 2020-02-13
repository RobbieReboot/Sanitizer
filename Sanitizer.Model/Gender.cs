using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class Gender
    {
        public Gender()
        {
            EtdlUserDetail = new HashSet<EtdlUserDetail>();
            UserProfile = new HashSet<UserProfile>();
        }

        public Guid GenderId { get; set; }
        public string Reference { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<EtdlUserDetail> EtdlUserDetail { get; set; }
        public virtual ICollection<UserProfile> UserProfile { get; set; }
    }
}
