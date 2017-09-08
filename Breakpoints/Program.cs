﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakpoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger(new Clock());
            var ordersPrinter = new OrdersPrinter(new Orders());
            try
            {
                logger.LogStart();

                ordersPrinter.PrintAll();

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
