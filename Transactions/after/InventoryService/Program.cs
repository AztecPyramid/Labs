using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace DM.PetShop.Inventory
{
    class Host
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(InventoryService)))
            {
                host.Open();
                Console.Title = "InventoryService";
                Console.WriteLine("InventoryService {0} is running...\n", host.Description.Endpoints[0].Address);
                Console.ReadLine();
            }
        }
    }
}
