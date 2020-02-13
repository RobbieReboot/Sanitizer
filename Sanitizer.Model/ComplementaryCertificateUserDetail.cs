using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class ComplementaryCertificateUserDetail
    {
        public ComplementaryCertificateUserDetail()
        {
            ComplementaryCertificateUserDetailDrivingCategory = new HashSet<ComplementaryCertificateUserDetailDrivingCategory>();
            ComplementaryCertificateUserDetailLanguageSkill = new HashSet<ComplementaryCertificateUserDetailLanguageSkill>();
        }

        public Guid ComplementaryCertificateUserDetailId { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string AdditionalInformation { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Notes { get; set; }
        public Guid? AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Company Company { get; set; }
        public virtual ComplementaryCertificate ComplementaryCertificateUserDetailNavigation { get; set; }
        public virtual ICollection<ComplementaryCertificateUserDetailDrivingCategory> ComplementaryCertificateUserDetailDrivingCategory { get; set; }
        public virtual ICollection<ComplementaryCertificateUserDetailLanguageSkill> ComplementaryCertificateUserDetailLanguageSkill { get; set; }
    }
}
