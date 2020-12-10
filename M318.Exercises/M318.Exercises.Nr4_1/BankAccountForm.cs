namespace M318.Exercises.Nr4_1
{
    using System;
    using System.Windows.Forms;

    public partial class BankAccountForm : Form
    {
        private const string BalanceFormat = "0.00";

        private decimal balance;

        public BankAccountForm()
        {
            InitializeComponent();
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

        private void DepositButtonClick(object sender, EventArgs e)
        {
            balance = balance + amountInput.Value;
            balanceDisplay.Text = balance.ToString(BalanceFormat);
        }

        private void WithdrawButtonClick(object sender, EventArgs e)
        {
            var newBalance = balance - amountInput.Value;

            if (newBalance < 0)
            {
                MessageBox.Show("Your balance is too low to withdraw that amount.", "Balance too low");
                return;
            }

            balance = newBalance;
            balanceDisplay.Text = balance.ToString(BalanceFormat);
        }
    }
}