using System;

namespace Sanitizer.Model
{
    public partial class EtdlCompanyDetail
    {
        public Guid EtdlCompanyDetailId { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public Guid AddressId { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public virtual Address Address { get; set; }
        public virtual Company Company { get; set; }
        public virtual EtdlApplication EtdlCompanyDetailNavigation { get; set; }
    }
}
