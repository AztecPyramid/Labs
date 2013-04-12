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
        static ManualResetEvent readLock = new ManualResetEvent(false);
        static ManualResetEvent writeLock = new ManualResetEvent(true);

        static void Main(string[] args)
        {
            Thread t1 = new Thread(RunMe);
            t1.Name = "Generator";
            t1.Start();

            for (int i = 0; i < 10; i++)
            {
                readLock.WaitOne();
                Console.WriteLine(number);
                readLock.Reset();
                writeLock.Set();
            }

            Console.ReadLine();
        }

        static void RunMe()
        {
            for (int i = 0; i < 10; i++)
            {
                writeLock.WaitOne();
                number = i;
                writeLock.Reset();
                readLock.Set();
            }
        }
    }
}
