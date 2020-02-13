using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class EtdlUserDetail
    {
        public EtdlUserDetail()
        {
            EtdlUserMedicalDetail = new HashSet<EtdlUserMedicalDetail>();
        }

        public Guid EtdlUserDetailId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Guid PostalAddressId { get; set; }
        public Guid GenderId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string BirthplacePostcode { get; set; }
        public string BirthplaceTown { get; set; }
        public string Nationality { get; set; }
        public string NativeLanguage { get; set; }
        public Guid PermanentAddressId { get; set; }
        public string Telephone { get; set; }
        public Guid CompanyRoleId { get; set; }

        public virtual Company Company { get; set; }
        public virtual CompanyRole CompanyRole { get; set; }
        public virtual EtdlApplication EtdlUserDetailNavigation { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Address PermanentAddress { get; set; }
        public virtual Address PostalAddress { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<EtdlUserMedicalDetail> EtdlUserMedicalDetail { get; set; }
    }
}
