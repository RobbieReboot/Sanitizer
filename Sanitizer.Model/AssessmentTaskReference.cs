namespace Sanitizer.Model
{
    public partial class AssessmentTaskReference
    {
        public string AssessmentTaskId { get; set; }
        public string CompanyId { get; set; }
        public string Value { get; set; }
        public string OrderByField { get; set; }
        public bool IsDeleted { get; set; }
    }
}
