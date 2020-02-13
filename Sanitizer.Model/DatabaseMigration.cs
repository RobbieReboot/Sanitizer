using System;

namespace Sanitizer.Model
{
    public partial class DatabaseMigration
    {
        public int DatabaseMigrationId { get; set; }
        public string Description { get; set; }
        public DateTime DateApplied { get; set; }
        public string Name { get; set; }
    }
}
