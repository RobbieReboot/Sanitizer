using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class DrivingCategory
    {
        public DrivingCategory()
        {
            ComplementaryCertificateUserDetailDrivingCategory = new HashSet<ComplementaryCertificateUserDetailDrivingCategory>();
        }

        public Guid DrivingCategoryId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<ComplementaryCertificateUserDetailDrivingCategory> ComplementaryCertificateUserDetailDrivingCategory { get; set; }
    }
}
