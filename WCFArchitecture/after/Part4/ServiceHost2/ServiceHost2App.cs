using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace ServiceHost2
{
    class ServiceHost2App
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(DM.PetShop.OrderService)))
            {
                host.Open();
                Console.Title = String.Format("{0} is running ...",
                                              host.Description.Endpoints[0].Address);
                Console.ReadLine();
            }
            Console.Title = "OrderService closed.";
        }
    }
}
