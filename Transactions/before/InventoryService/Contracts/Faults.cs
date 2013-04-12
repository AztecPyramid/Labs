using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace DM.PetShop.Inventory
{
    [DataContract(Name = "InventoryFault", Namespace = Constants.DATA_NAMESPACE)]
    public class InventoryFault
    {
        [DataMember(Name = "Description")]
        public string Description;
    }
}
