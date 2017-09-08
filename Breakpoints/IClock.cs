using System;

namespace Breakpoints
{
    public interface IClock
    {
        DateTime UtcNow { get; }
    }
}
