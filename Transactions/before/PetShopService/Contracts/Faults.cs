using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace DM.PetShop
{
    [DataContract(Name = "OrderFault", Namespace = Constants.DATA_NAMESPACE)]
    public class OrderFault
    {
        [DataMember(Name = "Description")]
        public string Description;
    }
}
