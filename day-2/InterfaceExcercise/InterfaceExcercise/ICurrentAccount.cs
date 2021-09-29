using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise
{
    interface ICurrentAccount
    {
        int Balance { get; }
        void Deposit(int amount);
        void Withdraw(int amount);
         
    }
}
