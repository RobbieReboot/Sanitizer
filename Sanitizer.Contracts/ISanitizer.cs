using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sanitizer.Contracts
{
    public interface ISanitizer
    {
        string Name { get; set; }
        int Sanitize(DbContext dbToSanitize);

    }
}
