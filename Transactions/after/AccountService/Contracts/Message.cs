using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace DM.PetShop.Accounting
{
    [MessageContract(IsWrapped = false)]
    public class AccountBalanceMessageResponse
    {
        [MessageBodyMember(Name = "Account", Namespace = Constants.MESSAGE_NAMESPACE)]
        public Account Body;
    }

    [MessageContract(IsWrapped = false)]
    public class ChargeAccountMessage
    {
        [MessageBodyMember(Name = "Account", Namespace = Constants.MESSAGE_NAMESPACE)]
        public Account Body;
    }
}
