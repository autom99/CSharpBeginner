﻿using System;

namespace Interface
{
    public class CurrentAccount : IBankAccount
    {
        private decimal _balance;

        public decimal AC_BALANCE
        {
            get
            {
                return _balance;  //throw new NotImplementedException();
            }
        }

        public bool Deposite(decimal amount)
        {
            _balance += amount;
            return true; //throw new NotImplementedException();
        }

        public bool Withdraw(decimal amount)
        {
            if (_balance < amount)
            {
                Console.WriteLine("Insufficient balance!");
                return false;
            }
            else
            {
                _balance -= amount;
                Console.WriteLine(String.Format("Successfully withdraw: {0,6:C}", amount));

                return true;
            }   //throw new NotImplementedException();
        }

        public override string ToString()
        {
            return String.Format("Current Account Balance = {0,6:C}", _balance);
        }
    }
}
