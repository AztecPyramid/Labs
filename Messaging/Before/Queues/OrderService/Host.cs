using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Transactions;

namespace DM
{
    class Host
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(OrderService)))
            {
                host.Open();
                Console.Title = "OrderService listening at " + host.Description.Endpoints[0].ListenUri.ToString();
                Console.ReadLine();
            }
        }
    }
}
