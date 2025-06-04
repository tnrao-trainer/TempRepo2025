using System;
using System.Text;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("[Using StringBuilder]");
            Console.WriteLine("Start Time: {0}", DateTime.Now.ToString("T"));
            for (int i = 0; i < 200000; i++)
            {
                sb.Append(i);
            }
            Console.WriteLine("End Time: {0}", DateTime.Now.ToString("T"));


            string numbers = "";
            Console.WriteLine("[Using String]");
            Console.WriteLine("Start Time: {0}", DateTime.Now.ToString("T"));

            for (int i = 0; i < 200000; i++)
            {
                numbers = numbers + i;
            }
            Console.WriteLine("End Time: {0}", DateTime.Now.ToString("T"));


            Console.ReadLine();
        }
    }
}
