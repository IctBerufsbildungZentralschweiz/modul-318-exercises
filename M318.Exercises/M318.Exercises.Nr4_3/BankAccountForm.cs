using System;
using System.Windows.Forms;

namespace M318.Exercises.Nr4_3
{
    public partial class BankAccountForm : Form
    {
        private readonly BankAccount bankAccount = new BankAccount();
        private const string BalanceFormat = "0.00";

        public BankAccountForm()
        {
            InitializeComponent();
        }

        private void DepositButtonClick(object sender, EventArgs e)
        {
            if (bankAccount.Deposit(amountInput.Value))
            {
                ShowBalanceChange(amountInput.Value);
            }
            else
            {
                MessageBox.Show("Could not deposit the chosen amount.");
            }
        }

        private void WithdrawButtonClick(object sender, EventArgs e)
        {
            if (bankAccount.Withdraw(amountInput.Value))
            {
                ShowBalanceChange(-amountInput.Value);
            }
            else
            {
                MessageBox.Show("Could not withdraw the chosen amount.");
            }
        }

        private void ShowBalanceChange(decimal balanceChange)
        {
            balanceDisplay.Text = bankAccount.Balance.ToString(BalanceFormat);

            balanceChangesGrid.Rows.Add(new[]
            {
                DateTime.Now.ToLongTimeString(),
                balanceChange.ToString(BalanceFormat),
                bankAccount.Balance.ToString(BalanceFormat)
            });
        }

        private void AmountInputChanged(object sender, EventArgs e)
        {
            if (amountInput.Value == 0)
            {
                depositButton.Enabled = false;
                withdrawButton.Enabled = false;
            }
            else
            {
                depositButton.Enabled = true;
                withdrawButton.Enabled = true;
            }
        }
    }
}
