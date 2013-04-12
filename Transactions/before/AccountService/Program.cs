using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace DM.PetShop.Accounting
{
    class Host
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(AccountingService)))
            {
                host.Open();
                Console.Title = "AccountingService";
                Console.WriteLine("AccountingService {0} is running...\n", host.Description.Endpoints[0].Address);
                Console.ReadLine();
            }
        }
    }
}
