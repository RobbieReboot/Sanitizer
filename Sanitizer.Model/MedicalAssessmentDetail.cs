using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class MedicalAssessmentDetail
    {
        public MedicalAssessmentDetail()
        {
            UserMedicalDetail = new HashSet<UserMedicalDetail>();
        }

        public Guid MedicalAssessmentDetailId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid MedicalIndicatorId { get; set; }
        public string AssessmentCompletedBy { get; set; }
        public DateTime DateOfMedicalAssessment { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? MedicalTimeframeId { get; set; }

        public virtual Company Company { get; set; }
        public virtual MedicalIndicator MedicalIndicator { get; set; }
        public virtual MedicalTimeframe MedicalTimeframe { get; set; }
        public virtual ICollection<UserMedicalDetail> UserMedicalDetail { get; set; }
    }
}
