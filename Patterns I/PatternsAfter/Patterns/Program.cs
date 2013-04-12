using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount a = new CheckingAccount();
            a.DepositRules += (am, bl) => { if (am > 10000) Console.WriteLine("Call the government."); };
            a.WithdrawRules += (am, bl) => { if (bl < 0) Console.WriteLine("Balance is below 0."); };

            a.Deposit(11000);
            a.Withdraw(6000);
            a.Withdraw(6000);

            Console.ReadLine();
        }
    }

    public interface IAccount
    {
        int Deposit(int amount);
        int Withdraw(int amount);
    }

    public class Account : IAccount
    {
        int balance = 0;

        public int Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Deposit: {0}, Balance: {1}", amount, balance);
            return balance;
        }

        public int Withdraw(int amount)
        {
            balance -= amount;
            Console.WriteLine("Withdraw: {0}, Balance: {1}", amount, balance);
            return balance;
        }
    }

    public delegate void AccountAction(int amount, int balance);

    public class CheckingAccount : IAccount
    {
        Account acc = new Account();

        public event AccountAction DepositRules;
        public event AccountAction WithdrawRules;

        public int Deposit(int amount)
        {
            int b = acc.Deposit(amount);
            DepositRules(amount, b);
            return b;
        }

        public int Withdraw(int amount)
        {
            int b = acc.Withdraw(amount);
            WithdrawRules(amount, b);
            return b;
        }

        public CheckingAccount()
        {
            // This is called a Null Pattern. By adding an empty delegate to the list, I don't have to check if the event is a null pointer.
            DepositRules = WithdrawRules = (x,y) => { };
        }
    }
}
