using System;

namespace Interface
{
    public class SavingAccount : IBankAccount
    {
        private decimal _balance;
        private decimal _perDayLimit;

        public decimal AC_BALANCE
        {
            get
            {
                return _balance; //throw new NotImplementedException();
            }
        }

        public bool Deposite(decimal amount)
        {
            _balance += amount;
            return true;  //throw new NotImplementedException();
        }

        public bool Withdraw(decimal amount)
        {
            if (_balance < amount)
            {
                Console.WriteLine("Insufficient balance!");
                return false;
            }
            else if (_perDayLimit + amount > 5000) //limit is 5000
            {
                Console.WriteLine("Withdrawal attempt failed!");
                return false;
            }
            else
            {
                _balance -= amount;
                _perDayLimit += amount;
                Console.WriteLine(String.Format("Successfully withdraw: {0,6:C}", amount));

                return true;
            }
            //throw new NotImplementedException();
        }

        public override string ToString()
        {
            return String.Format("Saving Account Balance = {0,6:C}", _balance);
        }
    }
}
