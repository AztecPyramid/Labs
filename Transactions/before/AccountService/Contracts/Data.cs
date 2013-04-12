using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace DM.PetShop.Accounting
{
    [DataContract(Name = "AccountBalance", Namespace = Constants.DATA_NAMESPACE)]
    public class Account
    {
        [DataMember(Name = "Balance")]
        public int Balance;
    }
}
