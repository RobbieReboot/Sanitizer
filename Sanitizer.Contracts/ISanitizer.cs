using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sanitizer.Contracts
{
    public interface ISanitizer
    {
        string Name { get; }
        string Description { get; }
        int Sanitize(DbContext dbToSanitize);

    }
}
