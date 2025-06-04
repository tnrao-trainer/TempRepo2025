using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp9
{

    interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message);
        void LogWarning(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine("[ERROR] : {0}", message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("[INFO] : {0}", message);
        }

        public void LogWarning(string message)
        {
            Console.WriteLine("[WARNING] : {0}", message);
        }
    }




    class Program
    {
        static void Main()
        {

            ConsoleLogger logger = new ConsoleLogger();

            int x, y, z = 0;
            try
            {
                Console.WriteLine("Enter value for X: ");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter value for Y: ");
                y = int.Parse(Console.ReadLine());

                z = x / y;

                System.Console.WriteLine("Result  :  " + z);
                logger.LogInfo("Process completed successfully");
            }
            catch (Exception e)
            {
                //   Console.WriteLine("Exception Raised. Reason : " + e.Message);
                logger.LogError("Exception Raised. Reason : " + e.Message);
            }



            Console.ReadLine();
        }
    }
}
