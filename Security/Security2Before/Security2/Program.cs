using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Security2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2) {
                Console.WriteLine("Enter 2 files to compare.");
                return ;
            }

            foreach (string file in args)
                if (!File.Exists(file)) {
                    Console.WriteLine("This file does not exist: {0}", file);
                    return;
                }

            // Add your code here...

            Console.ReadLine();
            return;
        }

        static void PrintHash(byte[] hashval)
        {
            for (int i = 0; i < hashval.Length; i++)
                Console.Write("{0:X2}", hashval[i]);
            Console.WriteLine();
        }
    }
}
