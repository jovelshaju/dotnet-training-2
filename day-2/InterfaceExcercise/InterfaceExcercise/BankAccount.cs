using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise
{
    class BankAccount : ISavingAccount, ICurrentAccount
    {
        int savingBalance;
        int currentBalance;
        public BankAccount()
        {
            savingBalance = 0;
            currentBalance = 0;
        }
        int ICurrentAccount.Balance => currentBalance;

        int ISavingAccount.Balance => savingBalance;

        void ICurrentAccount.Deposit(int amount)
        {
            currentBalance += amount;
        }

        void ISavingAccount.Deposit(int amount)
        {
            savingBalance += amount;
        }

        void ICurrentAccount.Withdraw(int amount)
        {
            currentBalance -= amount;
        }

        void ISavingAccount.Withdraw(int amount)
        {
            savingBalance -= amount;
        }
    }
}
