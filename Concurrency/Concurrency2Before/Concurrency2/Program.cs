using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Concurrency2
{
    class Program
    {
        static volatile int number;

        static void Main(string[] args)
        {
            Thread t1 = new Thread(RunMe);
            t1.Name = "Generator";
            t1.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }

        static void RunMe()
        {
            for (int i = 0; i < 10; i++)
            {
                number = i;
            }
        }
    }
}
