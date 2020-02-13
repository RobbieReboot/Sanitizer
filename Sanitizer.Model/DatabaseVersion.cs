using System;

namespace Sanitizer.Model
{
    public partial class DatabaseVersion
    {
        public int Id { get; set; }
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Hotfix { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
