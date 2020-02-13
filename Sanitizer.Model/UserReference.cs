namespace Sanitizer.Model
{
    public partial class UserReference
    {
        public string UserId { get; set; }
        public string Value { get; set; }
        public string FieldOrder { get; set; }
        public bool IsDeleted { get; set; }
        public string CompanyId { get; set; }
    }
}
