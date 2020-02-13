using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class UserMedicalTestRequestType
    {
        public UserMedicalTestRequestType()
        {
            UserMedicalTestRequest = new HashSet<UserMedicalTestRequest>();
        }

        public Guid UserMedicalTestRequestTypeId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<UserMedicalTestRequest> UserMedicalTestRequest { get; set; }
    }
}
