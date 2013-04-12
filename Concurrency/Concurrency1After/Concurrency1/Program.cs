using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Concurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p1 = new Process();
            Process p2 = new Process();
            Process p3 = new Process();
            DateTime now = DateTime.Now;

            //int x = p1.DoIt();
            //int y = p2.DoIt();
            //int z = p3.DoIt();

            Function f1 = p1.DoIt;
            Function f2 = p2.DoIt;
            Function f3 = p3.DoIt;

            IAsyncResult a1 = f1.BeginInvoke(null, null);
            IAsyncResult a2 = f2.BeginInvoke(null, null);
            IAsyncResult a3 = f3.BeginInvoke(null, null);

            WaitHandle.WaitAll(new WaitHandle[] { a1.AsyncWaitHandle, a2.AsyncWaitHandle, a3.AsyncWaitHandle });

            int x = f1.EndInvoke(a1);
            int y = f2.EndInvoke(a2);
            int z = f3.EndInvoke(a3);

            Console.WriteLine("DoIt Total Time: {0}", x+y+z);
            Console.WriteLine("Program Total time: {0}", (DateTime.Now-now).TotalMilliseconds);
            Console.ReadLine();
        }
    }

    delegate int Function() ;

    class Process
    {
        static Random r = new Random();
        int ms;

        public int DoIt()
        {
            Thread.Sleep(ms);
            Console.WriteLine("DoIt time: {0}", ms);
            return ms;
        }

        public Process()
        {
            ms = r.Next(500, 5000);
        }
    }

}
