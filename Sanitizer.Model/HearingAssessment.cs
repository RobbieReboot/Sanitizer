using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class HearingAssessment
    {
        public HearingAssessment()
        {
            UserMedicalDetail = new HashSet<UserMedicalDetail>();
        }

        public Guid HearingAssessmentId { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? HearingUnaidedResultId { get; set; }
        public Guid? HearingAidedResultId { get; set; }
        public Guid? HearingAidRequiredResultId { get; set; }

        public virtual Company Company { get; set; }
        public virtual MedicalAssessmentResult HearingAidRequiredResult { get; set; }
        public virtual MedicalAssessmentResult HearingAidedResult { get; set; }
        public virtual MedicalAssessmentResult HearingUnaidedResult { get; set; }
        public virtual ICollection<UserMedicalDetail> UserMedicalDetail { get; set; }
    }
}
