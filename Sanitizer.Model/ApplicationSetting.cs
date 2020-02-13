using System;

namespace Sanitizer.Model
{
    public partial class ApplicationSetting
    {
        public Guid ApplicationSettingId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
