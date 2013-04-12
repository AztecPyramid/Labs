using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace DM.PetShop.Accounting
{
    [DataContract(Name = "AccountingFault", Namespace = Constants.DATA_NAMESPACE)]
    public class AccountingFault
    {
        [DataMember(Name = "Description")]
        public string Description;
    }
}
