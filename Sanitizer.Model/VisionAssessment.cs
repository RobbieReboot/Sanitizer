using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class VisionAssessment
    {
        public VisionAssessment()
        {
            UserMedicalDetail = new HashSet<UserMedicalDetail>();
        }

        public Guid VisionAssessmentId { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsDeleted { get; set; }
        public Guid DistanceVisionUnaidedResultId { get; set; }
        public Guid DistanceVisionAidedResultId { get; set; }
        public Guid NearVisionUnaidedResultId { get; set; }
        public Guid NearVisionAidedResultId { get; set; }
        public Guid ColourVisionResultId { get; set; }
        public Guid GlassesRequiredResultId { get; set; }
        public Guid TintedLensesUsedResultId { get; set; }

        public virtual MedicalAssessmentResult ColourVisionResult { get; set; }
        public virtual Company Company { get; set; }
        public virtual MedicalAssessmentResult DistanceVisionAidedResult { get; set; }
        public virtual MedicalAssessmentResult DistanceVisionUnaidedResult { get; set; }
        public virtual MedicalAssessmentResult GlassesRequiredResult { get; set; }
        public virtual MedicalAssessmentResult NearVisionAidedResult { get; set; }
        public virtual MedicalAssessmentResult NearVisionUnaidedResult { get; set; }
        public virtual MedicalAssessmentResult TintedLensesUsedResult { get; set; }
        public virtual ICollection<UserMedicalDetail> UserMedicalDetail { get; set; }
    }
}
