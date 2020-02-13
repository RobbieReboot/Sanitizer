using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class ComplementaryCertificateFileType
    {
        public ComplementaryCertificateFileType()
        {
            ComplementaryCertificateFile = new HashSet<ComplementaryCertificateFile>();
        }

        public Guid ComplementaryCertificateFileTypeId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<ComplementaryCertificateFile> ComplementaryCertificateFile { get; set; }
    }
}
