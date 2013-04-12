using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Concurrency
{
    class Program
    {
        delegate int DoItDelegate();

        static void Main(string[] args)
        {
            Process p1 = new Process();
            Process p2 = new Process();
            Process p3 = new Process();
            DateTime now = DateTime.Now;

            DoItDelegate doIt1 = new DoItDelegate(p1.DoIt);
            DoItDelegate doIt2 = new DoItDelegate(p2.DoIt);
            DoItDelegate doIt3 = new DoItDelegate(p3.DoIt);

            IAsyncResult result1 = doIt1.BeginInvoke(null, null);
            IAsyncResult result2 = doIt2.BeginInvoke(null, null);
            IAsyncResult result3 = doIt3.BeginInvoke(null, null);

            WaitHandle.WaitAll(new WaitHandle[] { result1.AsyncWaitHandle, result2.AsyncWaitHandle, result3.AsyncWaitHandle });

            int one = doIt1.EndInvoke(result1);
            int two = doIt2.EndInvoke(result2);
            int three = doIt3.EndInvoke(result3);

            Console.WriteLine("DoIt Total Time: {0}", one + two + three);


            //int x = p1.DoIt();
            //int y = p2.DoIt();
            //int z = p3.DoIt();
            //Console.WriteLine("DoIt Total Time: {0}", x + y + z);

            Console.WriteLine("Program Total time: {0}", (DateTime.Now - now).TotalMilliseconds);
            Console.ReadLine();
        }
    }

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
