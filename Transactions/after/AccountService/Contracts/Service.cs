using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace DM.PetShop.Accounting
{
    [ServiceContract(Name = "PetShopAccountingContract", Namespace = Constants.SERVICE_NAMESPACE, 
        SessionMode = SessionMode.NotAllowed)]
    public interface IPetShopAccountingService
    {
        [OperationContract(Name = "GetAccountBalance", Action = "GetAccountBalance", ReplyAction = "GetAccountBalanceReply")]
        AccountBalanceMessageResponse GetAccountBalance();

        [OperationContract(Name = "ChargeAccount", Action = "ChargeAccount", ReplyAction = "ChargeAccountReply")]
        [FaultContract(typeof(AccountingFault), Name = "AccountingFault", Namespace = Constants.DATA_NAMESPACE, Action = "AccountingFault")]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        void ChargeAccount(ChargeAccountMessage request);
    }
}
