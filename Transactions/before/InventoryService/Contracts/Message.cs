using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace DM.PetShop.Inventory
{
    [MessageContract(IsWrapped=false)]
    public class UpdateInventoryMessage
    {
        [MessageBodyMember(Name = "Order", Namespace = Constants.MESSAGE_NAMESPACE)]
        public Order Body;
    }

    [MessageContract(IsWrapped = false)]
    public class InventoryMessageResponse
    {
        [MessageBodyMember(Name = "Inventory", Namespace = Constants.MESSAGE_NAMESPACE)]
        public InventoryDetails Body;
    }
}
