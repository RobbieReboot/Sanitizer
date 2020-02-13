using System;

namespace Sanitizer.Model
{
    public partial class YesNo
    {
        public Guid YesNoId { get; set; }
        public string Reference { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public int FieldOrder { get; set; }
        public short IntValue { get; set; }
    }
}
