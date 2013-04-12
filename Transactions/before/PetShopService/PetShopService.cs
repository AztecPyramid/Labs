using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using DM.PetShop.Inventory;
using DM.PetShop.Accounting;

namespace DM.PetShop
{
    [ServiceBehavior(Name = "PetShopService", Namespace = Constants.SERVICE_NAMESPACE,
        InstanceContextMode = InstanceContextMode.PerCall,
        ConcurrencyMode = ConcurrencyMode.Single)]
    class PetShopService : IPetShopService
    {
        public void PlaceOrder(OrderMessage request)
        {
            using (ChannelWrapper<IPetShopInventoryService> inventory = new ChannelWrapper<IPetShopInventoryService>("Inventory"))
            using (ChannelWrapper<IPetShopAccountingService> accounting = new ChannelWrapper<IPetShopAccountingService>("Accounting"))
            {
                // update account
                int total = CalculateTotal(request.Body.ProductName, request.Body.Quantity);

                Account account = new Account();
                account.Balance = total;

                ChargeAccountMessage accountingMsg = new ChargeAccountMessage();
                accountingMsg.Body = account;

                try
                {
                    accounting.Channel.ChargeAccount(accountingMsg);
                }
                catch (FaultException<AccountingFault> ex)
                {
                    OrderFault fault = new OrderFault();
                    fault.Description = ex.Detail.Description;

                    throw new FaultException<OrderFault>(fault, "Order failed");
                }
                
                // update inventory
                UpdateInventoryMessage inventoryMsg = new UpdateInventoryMessage();
                inventoryMsg.Body = request.Body;

                try
                {
                    inventory.Channel.UpdateInventory(inventoryMsg);
                }
                catch (FaultException<InventoryFault> ex)
                {
                    OrderFault fault = new OrderFault();
                    fault.Description = ex.Detail.Description;

                    throw new FaultException<OrderFault>(fault, "Order failed");
                }
            }
        }

        public DM.PetShop.Inventory.InventoryMessageResponse GetInventory()
        {
            using (ChannelWrapper<IPetShopInventoryService> wrapper = new ChannelWrapper<IPetShopInventoryService>("Inventory"))
            {
                return wrapper.Channel.GetInventory();
            }
        }

        public DM.PetShop.Accounting.AccountBalanceMessageResponse GetAccountBalance()
        {
            using (ChannelWrapper<IPetShopAccountingService> wrapper = new ChannelWrapper<IPetShopAccountingService>("Accounting"))
            {
                return wrapper.Channel.GetAccountBalance();
            }
        }

        private int CalculateTotal(string animalName, int quantity)
        {
            InventoryMessageResponse response = GetInventory();
            AnimalDetails details = response.Body.Items[animalName];
            int animalPrice = details.Price;

            int total = animalPrice * quantity;
            return total;
        }
    }
}
