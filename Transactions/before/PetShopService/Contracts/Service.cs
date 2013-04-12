using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace DM.PetShop
{
    [ServiceContract(Name = "PetShopServiceContract", Namespace = Constants.SERVICE_NAMESPACE, 
        SessionMode = SessionMode.NotAllowed)]
    interface IPetShopService
    {
        [OperationContract(Name = "PlaceOrder", Action = "Placeorder", ReplyAction = "PlaceOrderReply")]
        [FaultContract(typeof(OrderFault), Name = "OrderFault", Namespace = Constants.DATA_NAMESPACE, Action = "OrderFault")]
        void PlaceOrder(OrderMessage request);

        // pass thru operations
        [OperationContract(Name = "GetInventory", Action = "GetInventory", ReplyAction = "GetInventoryReply")]
        DM.PetShop.Inventory.InventoryMessageResponse GetInventory();

        [OperationContract(Name = "GetAccountBalance", Action = "GetAccountBalance", ReplyAction = "GetAccountBalanceReply")]
        DM.PetShop.Accounting.AccountBalanceMessageResponse GetAccountBalance();
    }
}
