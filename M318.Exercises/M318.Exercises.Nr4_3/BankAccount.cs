using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M318.Exercises.Nr4_3
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            this.Balance += amount;
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            var newBalance = this.Balance - amount;
            if (amount <= 0 || newBalance < 0)
            {
                return false;
            }

            this.Balance = newBalance;
            return true;
        }
    }
}
