using System;

namespace Sanitizer.Model
{
    public partial class ComplementaryCertificateUserDetailDrivingCategory
    {
        public Guid ComplementaryCertificateUserDetailDrivingCategoryId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid ComplementaryCertificateUserDetailId { get; set; }
        public Guid DrivingCategoryId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual ComplementaryCertificateUserDetail ComplementaryCertificateUserDetail { get; set; }
        public virtual DrivingCategory DrivingCategory { get; set; }
    }
}
