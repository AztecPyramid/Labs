using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace DM.PetShop
{
    [ServiceBehavior (Name="DM.PetShop.OrderService", Namespace=Constants.SERVICE_NAMESPACE, ConcurrencyMode=ConcurrencyMode.Single)]
    public class OrderService : IOrderContract
    {

        public void PlaceOrder(string message)
        {
            Console.WriteLine("An order has been placed");
        }
        
    }
}
