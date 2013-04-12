using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace DM.PetShop.Inventory
{
    [ServiceContract(Name = "PetShopInventoryServiceContract", Namespace = Constants.SERVICE_NAMESPACE, 
        SessionMode = SessionMode.NotAllowed)]
    public interface IPetShopInventoryService
    {
        [OperationContract(Name = "UpdateInventory", Action = "UpdateInventory", ReplyAction = "UpdateInventoryReply")]
        [FaultContract(typeof(InventoryFault), Name = "InventoryFault", Namespace = Constants.DATA_NAMESPACE, Action = "InventoryFault")]
        void UpdateInventory(UpdateInventoryMessage request);

        [OperationContract(Name = "GetInventory", Action = "GetInventory", ReplyAction = "GetInventoryReply")]
        InventoryMessageResponse GetInventory();
    }
}
