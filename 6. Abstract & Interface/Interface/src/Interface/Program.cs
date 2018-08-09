using System;

namespace Interface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBankAccount savingaccount = new SavingAccount();
            IBankAccount currentaccount = new CurrentAccount();

            savingaccount.Deposite(10000);
            savingaccount.Withdraw(6000);
            savingaccount.ToString();

            currentaccount.Deposite(50000);
            currentaccount.Withdraw(25000);
            currentaccount.ToString();

            Console.ReadLine();
        }
    }
}
