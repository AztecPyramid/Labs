using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace Serialization1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serPayment = new XmlSerializer(typeof(Payment));
            XmlSerializer serResponse = new XmlSerializer(typeof(PaymentResponse));

            //IFormatter serPayment = new SoapFormatter();
            //IFormatter serResponse = serPayment;

            Bank b = new Bank();
            
            // Time 10000 payments
            DateTime now = DateTime.Now;
            for (int i = 0; i < 10000; i++) {
                Payment p = new Payment();
                p.Payee = "Amazon";
                p.Payer = "Bill Smith";
                p.Amount = i;
                p.Date = "08/10/08";
                p.Description = "A book";

                // Convert the object and put into memorystream
                MemoryStream ms = new MemoryStream();
                serPayment.Serialize(ms, p);

                MemoryStream msresp = b.Pay(ms) ;
                msresp.Seek(0,SeekOrigin.Begin) ;   // Move the stream pointer to the front

                PaymentResponse resp = (PaymentResponse)serResponse.Deserialize(msresp);
            }

            Console.WriteLine("Total time: {0}", DateTime.Now - now);
            Console.ReadLine();
        }
    }

    public class Bank
    {
        XmlSerializer serPayment = new XmlSerializer(typeof(Payment));
        XmlSerializer serResponse = new XmlSerializer(typeof(PaymentResponse));

        //IFormatter serPayment = new SoapFormatter();
        //IFormatter serResponse = new SoapFormatter();

        public MemoryStream Pay(MemoryStream ms)
        {
            ms.Seek(0, SeekOrigin.Begin);
            Payment p = (Payment)serPayment.Deserialize(ms);
            MemoryStream msresp = new MemoryStream();
            serResponse.Serialize(msresp, new PaymentResponse("Success"));

            return msresp;
        }
    }
    
    [Serializable]
    public class Payment
    {
        public string Payee { get; set; }
        public string Payer { get; set; }
        public int Amount { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }

        public Payment() { }
    }

    [Serializable]
    public class PaymentResponse
    {
        public string Status { get; set; }

        public PaymentResponse(string s)
        {
            Status = s;
        }

        public PaymentResponse() { }
    }


}
