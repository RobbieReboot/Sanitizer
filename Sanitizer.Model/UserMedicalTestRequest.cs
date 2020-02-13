using System;

namespace Sanitizer.Model
{
    public partial class UserMedicalTestRequest
    {
        public Guid UserMedicalTestRequestId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public Guid UserMedicalTestRequestTypeId { get; set; }
        public Guid CreatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual User CreatedByUser { get; set; }
        public virtual User User { get; set; }
        public virtual UserMedicalTestRequestType UserMedicalTestRequestType { get; set; }
    }
}
