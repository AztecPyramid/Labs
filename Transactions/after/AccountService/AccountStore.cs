using System;
using System.Collections.Generic;
using System.Text;
using VolatileResourceManager;

namespace DM.PetShop.Accounting
{
    static class AccountStore
    {
        static Transactional<int> _balance;
        
        static AccountStore()
        {
            _balance = new Transactional<int>();

            _balance.Value = 1000;
        }

        public static int GetBalance()
        {
            return _balance.Value;
        }

        public static void Debit(int amount)
        {
            if ((_balance.Value - amount) >= 0)
            {
                _balance.Value -= amount;
            }
            else
            {
                throw new CreditExceededException();
            }
        }
    }


    [global::System.Serializable]
    public class CreditExceededException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public CreditExceededException() { }
        public CreditExceededException(string message) : base(message) { }
        public CreditExceededException(string message, Exception inner) : base(message, inner) { }
        protected CreditExceededException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
