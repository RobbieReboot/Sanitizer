using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class MedicalAssessmentResult
    {
        public MedicalAssessmentResult()
        {
            DrugsAlcoholAndDiabetesAssessmentAlcoholTestResult = new HashSet<DrugsAlcoholAndDiabetesAssessment>();
            DrugsAlcoholAndDiabetesAssessmentDiabetesTestResult = new HashSet<DrugsAlcoholAndDiabetesAssessment>();
            DrugsAlcoholAndDiabetesAssessmentDrugsTestResult = new HashSet<DrugsAlcoholAndDiabetesAssessment>();
            DrugsAlcoholAndDiabetesAssessmentForCauseScreeningResult = new HashSet<DrugsAlcoholAndDiabetesAssessment>();
            DrugsAlcoholAndDiabetesAssessmentGeneralHealthResult = new HashSet<DrugsAlcoholAndDiabetesAssessment>();
            HearingAssessmentHearingAidRequiredResult = new HashSet<HearingAssessment>();
            HearingAssessmentHearingAidedResult = new HashSet<HearingAssessment>();
            HearingAssessmentHearingUnaidedResult = new HashSet<HearingAssessment>();
            VisionAssessmentColourVisionResult = new HashSet<VisionAssessment>();
            VisionAssessmentDistanceVisionAidedResult = new HashSet<VisionAssessment>();
            VisionAssessmentDistanceVisionUnaidedResult = new HashSet<VisionAssessment>();
            VisionAssessmentGlassesRequiredResult = new HashSet<VisionAssessment>();
            VisionAssessmentNearVisionAidedResult = new HashSet<VisionAssessment>();
            VisionAssessmentNearVisionUnaidedResult = new HashSet<VisionAssessment>();
            VisionAssessmentTintedLensesUsedResult = new HashSet<VisionAssessment>();
        }

        public Guid MedicalAssessmentResultId { get; set; }
        public string Reference { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<DrugsAlcoholAndDiabetesAssessment> DrugsAlcoholAndDiabetesAssessmentAlcoholTestResult { get; set; }
        public virtual ICollection<DrugsAlcoholAndDiabetesAssessment> DrugsAlcoholAndDiabetesAssessmentDiabetesTestResult { get; set; }
        public virtual ICollection<DrugsAlcoholAndDiabetesAssessment> DrugsAlcoholAndDiabetesAssessmentDrugsTestResult { get; set; }
        public virtual ICollection<DrugsAlcoholAndDiabetesAssessment> DrugsAlcoholAndDiabetesAssessmentForCauseScreeningResult { get; set; }
        public virtual ICollection<DrugsAlcoholAndDiabetesAssessment> DrugsAlcoholAndDiabetesAssessmentGeneralHealthResult { get; set; }
        public virtual ICollection<HearingAssessment> HearingAssessmentHearingAidRequiredResult { get; set; }
        public virtual ICollection<HearingAssessment> HearingAssessmentHearingAidedResult { get; set; }
        public virtual ICollection<HearingAssessment> HearingAssessmentHearingUnaidedResult { get; set; }
        public virtual ICollection<VisionAssessment> VisionAssessmentColourVisionResult { get; set; }
        public virtual ICollection<VisionAssessment> VisionAssessmentDistanceVisionAidedResult { get; set; }
        public virtual ICollection<VisionAssessment> VisionAssessmentDistanceVisionUnaidedResult { get; set; }
        public virtual ICollection<VisionAssessment> VisionAssessmentGlassesRequiredResult { get; set; }
        public virtual ICollection<VisionAssessment> VisionAssessmentNearVisionAidedResult { get; set; }
        public virtual ICollection<VisionAssessment> VisionAssessmentNearVisionUnaidedResult { get; set; }
        public virtual ICollection<VisionAssessment> VisionAssessmentTintedLensesUsedResult { get; set; }
    }
}
