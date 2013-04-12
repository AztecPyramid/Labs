using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace DM.PetShop
{
    [DataContract(Name="Order", Namespace=Constants.DATA_NAMESPACE)]
    public class Order
    {
        [DataMember(Name="Quantity")]
        public int Quantity;

        [DataMember(Name = "ProductName")]
        public string ProductName;
    }
}
