using System;
using System.Transactions;
using System.ServiceModel;

namespace Client
{
    class Program
    {
        static void Main()
        {
            using (TransactionScope ts = new TransactionScope())
            {
                OrderService.IOrderService proxy = new OrderService.OrderServiceClient();
                proxy.StartPlaceOrder("Order1");
                proxy.AddOrderItem("Parrot", 2);
                proxy.AddOrderItem("Dog", 3);
                proxy.FinishedPlaceOrder();
                Cleanup(proxy);
                ts.Complete();
            }
        }

        static void Cleanup(object obj)
        {
            ICommunicationObject commObj = (ICommunicationObject)obj;
            try
            {
                commObj.Close();
            }
            catch
            {
                commObj.Abort();
                throw;
            }
        }
    }
}
