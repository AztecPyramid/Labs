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

            a.DepositAction += new AccountAction(a_DepositAction);
            a.WithdrawAction += (amount, balance) => { if (balance <= 0) Console.Write("Balance is at or below zero!"); };

            a.Deposit(11000);
            a.Withdraw(6000);
            a.Withdraw(6000);


            Console.ReadLine();
        }

        static void a_DepositAction(double amount, double balance)
        {
            if (amount >10000)
                Console.WriteLine("Call the government!");
        }
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

    public interface IAccount
    {
        int Deposit(int amount);
        int Withdraw(int amount);
    }

    public class CheckingAccount : IAccount
    {
        Account account = new Account();

        public CheckingAccount()
        {
            // This is called a Null Pattern. By adding an empty delegate to the list, I don't have to check if the event is a null pointer.
            DepositAction = WithdrawAction = (x, y) => { };
        }

        public event AccountAction DepositAction;
        public event AccountAction WithdrawAction;

        public int Deposit(int amount)
        {
            int balance =  account.Deposit(amount);
            DepositAction(amount, balance);
            return balance;

        }

        public int Withdraw(int amount)
        {
            int balance =  account.Withdraw(amount);
            WithdrawAction(amount, balance);
            return balance;
        }
    }

    public delegate void AccountAction(double amount, double balance);
}
