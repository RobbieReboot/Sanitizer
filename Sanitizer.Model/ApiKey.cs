using System;

namespace Sanitizer.Model
{
    public partial class ApiKey
    {
        public Guid ApiKeyId { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public bool? IsEnabled { get; set; }
        public string CallbackApiKey { get; set; }
        public string CallbackApiUrl { get; set; }
        public string CallbackApiVersion { get; set; }
    }
}
