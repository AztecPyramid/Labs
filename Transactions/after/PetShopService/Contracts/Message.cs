using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace DM.PetShop
{
    [MessageContract(IsWrapped=false)]
    public class OrderMessage
    {
        [MessageBodyMember(Name = "Order", Namespace = Constants.MESSAGE_NAMESPACE)]
        public DM.PetShop.Inventory.Order Body;
    }
}
