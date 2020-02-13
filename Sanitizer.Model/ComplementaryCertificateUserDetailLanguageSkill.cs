using System;

namespace Sanitizer.Model
{
    public partial class ComplementaryCertificateUserDetailLanguageSkill
    {
        public Guid ComplementaryCertificateUserDetailLanguageSkillId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid ComplementaryCertificateUserDetailId { get; set; }
        public DateTime Date { get; set; }
        public string Language { get; set; }
        public string Notes { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual ComplementaryCertificateUserDetail ComplementaryCertificateUserDetail { get; set; }
    }
}
