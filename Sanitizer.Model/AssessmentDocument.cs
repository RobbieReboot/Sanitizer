﻿using System;

namespace Sanitizer.Model
{
    public partial class AssessmentDocument
    {
        public Guid AssessmentDocumentId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid AssessmentId { get; set; }
        public string DisplayFileName { get; set; }
        public string StorageFileName { get; set; }
        public string FileMimeType { get; set; }
        public long FileSizeBytes { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Assessment Assessment { get; set; }
        public virtual Company Company { get; set; }
    }
}
