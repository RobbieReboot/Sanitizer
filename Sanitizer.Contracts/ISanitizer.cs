using System;
using System.Collections.Generic;

namespace Sanitizer.Contracts
{
    public interface ISanitizer
    {
        string Name { get; set; }
        int Sanitize();

    }
}
