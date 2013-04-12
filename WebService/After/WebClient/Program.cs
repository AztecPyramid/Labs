using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace WebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("http://localhost:9000/Contact/Surana/Pinku/Email");
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sread = new StreamReader(stream);
            Console.WriteLine(sread.ReadToEnd());

            Console.ReadLine();
        }
    }
}
