using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace DM.PetShop
{
    [ServiceBehavior(Name="DM.PetShop.OrderService", Namespace=Constants.SERVICE_NAMESPACE)]
    public class OrderService : IOrderContract
    {
        public void PlaceOrder(string orderData)
        {
            Console.WriteLine("Order '{0}' placed", orderData);
        }
    }
}
