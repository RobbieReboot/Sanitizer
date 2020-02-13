using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class DrugsAlcoholAndDiabetesAssessment
    {
        public DrugsAlcoholAndDiabetesAssessment()
        {
            UserMedicalDetail = new HashSet<UserMedicalDetail>();
        }

        public Guid DrugsAlcoholAndDiabetesAssessmentId { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsDeleted { get; set; }
        public Guid DrugsTestResultId { get; set; }
        public DateTime? DrugsTestResultDate { get; set; }
        public Guid AlcoholTestResultId { get; set; }
        public DateTime? AlcoholTestResultDate { get; set; }
        public Guid ForCauseScreeningResultId { get; set; }
        public Guid DiabetesTestResultId { get; set; }
        public Guid GeneralHealthResultId { get; set; }

        public virtual MedicalAssessmentResult AlcoholTestResult { get; set; }
        public virtual Company Company { get; set; }
        public virtual MedicalAssessmentResult DiabetesTestResult { get; set; }
        public virtual MedicalAssessmentResult DrugsTestResult { get; set; }
        public virtual MedicalAssessmentResult ForCauseScreeningResult { get; set; }
        public virtual MedicalAssessmentResult GeneralHealthResult { get; set; }
        public virtual ICollection<UserMedicalDetail> UserMedicalDetail { get; set; }
    }
}
