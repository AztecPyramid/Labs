using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Transactions;

namespace DM
{
    [ServiceBehavior(ConfigurationName="OrderService")]
    class OrderService : IOrderService
    {
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = false)]
        public void StartPlaceOrder(string data)
        {
            Console.WriteLine("PlaceOrder({0})", data);
            DumpSessionInfo();
            DumpTransactionInfo();
        }

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = false)]
        public void AddOrderItem(string item, int quantity)
        {
            Console.WriteLine("AddOrderItem({0}, {1})", item, quantity);
            DumpSessionInfo();
            DumpTransactionInfo();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void FinishedPlaceOrder()
        {
            Console.WriteLine("FinishedPlaceOrder()");
            DumpSessionInfo();
            DumpTransactionInfo();
        }

        void DumpSessionInfo()
        {
            string sessionId = OperationContext.Current.SessionId;
            if (sessionId != null)
            {
                Console.WriteLine("SessionID={0}", sessionId);
            }
            else
            {
                Console.WriteLine("Not executing within a session");
            }
        }

        void DumpTransactionInfo()
        {
            Transaction trx = Transaction.Current;
            if (trx != null)
            {
                Console.WriteLine("LocalID={0}", trx.TransactionInformation.LocalIdentifier);
                Console.WriteLine("DistributedID={0}", trx.TransactionInformation.DistributedIdentifier);
            }
            else
            {
                Console.WriteLine("No current transaction");
            }
        }
    }
}