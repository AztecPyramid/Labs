using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace DM.PetShop.Accounting
{
    [ServiceBehavior(Name = "PetShopAccountingService", Namespace = Constants.SERVICE_NAMESPACE,
        InstanceContextMode = InstanceContextMode.PerCall,
        ConcurrencyMode = ConcurrencyMode.Single)]
    class AccountingService : IPetShopAccountingService
    {
        public AccountBalanceMessageResponse GetAccountBalance()
        {           
            Account account = new Account();
            account.Balance = AccountStore.GetBalance();

            AccountBalanceMessageResponse response = new AccountBalanceMessageResponse();
            response.Body = account;

            return response;
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void ChargeAccount(ChargeAccountMessage request)
        {
            try
            {
                AccountStore.Debit(request.Body.Balance);
            }
            catch (CreditExceededException)
            {
                AccountingFault fault = new AccountingFault();
                fault.Description = "You exceeded your credit";

                FaultException<AccountingFault> faultException = new FaultException<AccountingFault>(fault, "Accounting Errror");
                throw faultException;
            }
        }
    }
}