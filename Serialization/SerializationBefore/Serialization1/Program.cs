using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Serialization1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Bank b = new Bank();

            // Time 10000 payments
            for (int i = 0; i < 10000; i++)
            {
                Payment p = new Payment();
                p.Payee = "Amazon";
                p.Payer = "Bill Smith";
                p.Amount = i;
                p.Date = "08/10/08";
                p.Description = "A book";

                MemoryStream ms = new MemoryStream();

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Payment));

                xmlSerializer.Serialize(ms,p);
                // formatter.Serialize(ms, p);

                PaymentResponse returnMs = b.Pay(ms);
            }

            Console.WriteLine("Total time: {0}", DateTime.Now - now);
            Console.ReadLine();
        }
    }

    class Bank
    {
        public PaymentResponse Pay(MemoryStream p)
        {
            // IFormatter formatter = new BinaryFormatter();
            XmlSerializer seria = new XmlSerializer(typeof(PaymentResponse));
            p.Seek(0, SeekOrigin.Begin);
            // Payment payment = (Payment)formatter.Deserialize(p);
            Payment payment = (Payment)seria.Deserialize(p);
            return new PaymentResponse("Success");
        }
    }

    [Serializable]
    public class Payment
    {
        public Payment()
        {
        }
        public string Payee { get; set; }
        public string Payer { get; set; }
        public int Amount { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
    }

    [Serializable]
    public class PaymentResponse
    {
        public PaymentResponse()
        {
        }
        public string Status { get; set; }

        public PaymentResponse(string s)
        {
            Status = s;
        }
    }
}


