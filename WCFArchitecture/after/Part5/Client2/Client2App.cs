using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace Client2
{
    class Client2App
    {
        static void Main(string[] args)
        {
            PetShop.PetShopOrderContractClient proxy = new PetShop.PetShopOrderContractClient();
            try
            {
                proxy.PlaceOrder("2 hamsters, please");
            }
            finally
            {
                try
                {
                    if (proxy.State != CommunicationState.Closed)
                        proxy.Close();
                }
                catch
                {
                    proxy.Abort();
                }
            }
        }
    }
}
