using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
When we need an interface?
Suppose we have an event in our company for which we have different type of persons to register.
Guest: with no fee but special treatment
Employee: with no fee
Outsiders: need to pay fee
Now we can create IPerson interface with a method Save and derive three classes Guest, Employee and Outsiders.
 */

namespace Interface
{
    interface IBankAccount
    {
        bool Deposite(decimal amount);
        bool Withdraw(decimal amount);
        decimal AC_BALANCE { get; }
    }
}
