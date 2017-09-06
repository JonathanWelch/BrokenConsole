using System;

namespace Debugging
{
    public class Logger
    {
        private readonly IClock _clock;

        public Logger(IClock clock)
        {
            _clock = clock;
        }

        public void LogStart()
        {
            Console.WriteLine($"Application started at {_clock.UtcNow}");
        }

        public void LogFinish()
        {
            Console.WriteLine($"Application finished at {_clock.UtcNow}");
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine($"Application throw the exception '{exception}' at {_clock.UtcNow}");
        }
    }
}
