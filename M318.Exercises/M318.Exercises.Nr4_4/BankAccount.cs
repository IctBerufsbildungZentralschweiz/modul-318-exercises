using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M318.Exercises.Nr4_4
{
    public class BankAccount
    {
        private readonly string balanceFilePath = Path.Combine(Environment.GetEnvironmentVariable("TEMP"), "BankAccount.txt");

        public decimal Balance { get; private set; }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            this.Balance += amount;
            return SaveBalanceToFile();
        }

        public bool Withdraw(decimal amount)
        {
            var newBalance = this.Balance - amount;
            if (amount <= 0 || newBalance < 0)
            {
                return false;
            }

            this.Balance = newBalance;
            return SaveBalanceToFile();
        }

        /// <summary>
        /// Load the balance from the file at "%TEMP%\BankAccount.txt".
        /// </summary>
        /// <returns>False if there was an error while loading the balance. True if the file does not exist or the balance could be loaded.</returns>
        public bool LoadBalanceFromFile()
        {
            try
            {
                if (!File.Exists(balanceFilePath))
                {
                    return true;
                }

                var fileText = File.ReadAllText(balanceFilePath);
                if (decimal.TryParse(fileText, out var balance))
                {
                    this.Balance = balance;
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        private bool SaveBalanceToFile()
        {
            try
            {
                if (!File.Exists(balanceFilePath))
                {
                    var createdFileStream = File.Create(balanceFilePath);
                    createdFileStream.Close();
                }

                File.WriteAllText(balanceFilePath, this.Balance.ToString());
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
