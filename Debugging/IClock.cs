using System;

namespace Debugging
{
    public interface IClock
    {
        DateTime UtcNow { get; }
    }
}
