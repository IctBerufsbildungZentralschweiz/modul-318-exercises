namespace M318.Exercises.Nr4_3
{
    using System;
    using System.Windows.Forms;

    public partial class BankAccountForm : Form
    {
        private const string BalanceFormat = "0.00";
        private readonly BankAccount bankAccount = new BankAccount();

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

            balanceChangesGrid.Rows.Add(new object[]
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
