using System;

namespace Sanitizer.Model
{
    public partial class ComplementaryCertificateDateInfo
    {
        public Guid ComplementaryCertificateDateInfoId { get; set; }
        public Guid ComplementaryCertificateId { get; set; }
        public DateTime? RecertificationDate { get; set; }
        public Guid? SubmittedByUserId { get; set; }
        public DateTime? SubmittedDateTime { get; set; }
        public DateTime IssuingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ComplementaryCertificate ComplementaryCertificate { get; set; }
        public virtual User SubmittedByUser { get; set; }
    }
}
