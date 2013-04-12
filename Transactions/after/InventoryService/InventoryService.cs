using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace DM.PetShop.Inventory
{
    [ServiceBehavior(Name = "PetShopInventoryService", Namespace = Constants.SERVICE_NAMESPACE,
        InstanceContextMode = InstanceContextMode.PerCall,
        ConcurrencyMode = ConcurrencyMode.Single)]
    class InventoryService : IPetShopInventoryService
    {
        [OperationBehavior(TransactionScopeRequired = true)]
        public void UpdateInventory(UpdateInventoryMessage request)
        {
            try
            {
                InventoryStore.UpdateInventory(request.Body.ProductName, request.Body.Quantity);
            }
            catch (InventoryException)
            {
                InventoryFault fault = new InventoryFault();
                fault.Description = "Not enough units in stock";

                FaultException<InventoryFault> faultException = new FaultException<InventoryFault>(fault, "Inventory Error");
                throw faultException;
            }
        }

        public InventoryMessageResponse GetInventory()
        {
            InventoryDetails body = new InventoryDetails();
            body.Items = InventoryStore.GetInventory();

            InventoryMessageResponse response = new InventoryMessageResponse();
            response.Body = body;

            return response;
        }
    }
}
