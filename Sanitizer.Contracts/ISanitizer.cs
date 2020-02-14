using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sanitizer.Contracts
{
    public interface ISanitizer
    {
        public string Name { get; set; }
        public int Sanitize(DbContext dbToSanitize);

    }
}
