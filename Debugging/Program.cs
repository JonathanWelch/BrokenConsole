using System;

namespace Debugging
{
    class Program
    {       
        static void Main(string[] args)
        {
            var logger = new Logger(new Clock());
            var orders = new OrdersPrinter(new Orders());
            try
            {
                logger.LogStart();

                orders.PrintAll();

                logger.LogFinish();
            }
            catch (Exception ex)
            {
                logger.LogError(ex);
            }
            finally
            {
                CloseApplication();
            }
        }

        private static void CloseApplication()
        {
            Console.WriteLine("Press a key to close the application");
            Console.ReadKey();
        }
    }
}