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

            Stream f1, f2;
            byte[] h1 = null, h2 = null;

            MD5 hash = MD5.Create();

            f1 = File.OpenRead(args[0]);
            h1 = hash.ComputeHash(f1);

            f2 = File.OpenRead(args[1]);
            h2 = hash.ComputeHash(f2);

            bool same = true;
            // Compare two files, check for equality
            for (int i=0; i < h1.Length; i++)
                if (h1[i] != h2[i]) {
                    same = false;
                    break;
                }
            
            if (same) 
                Console.WriteLine("Files are equal.");
            else
                Console.WriteLine("Files are not equal.");

            // Emit a hexadecimal representation of the MD5 hash value
            Console.Write(args[0] + ": ");
            PrintHash(h1);

            Console.Write(args[1] + ": ");
            PrintHash(h2);

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
