using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace DM.PetShop
{
    class Host
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(PetShopService)))
            {
                host.Open();
                Console.Title = "PetShopService";
                Console.WriteLine("PetShopService {0} is running...\n", host.Description.Endpoints[0].Address);
                Console.ReadLine();
            }
        }
    }
}
