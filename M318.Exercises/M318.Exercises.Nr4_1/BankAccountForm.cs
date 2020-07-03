using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M318.Exercises.Nr4_1
{
    public partial class BankAccountForm : Form
    {
        private decimal balance = 0;

        public BankAccountForm()
        {
            InitializeComponent();
        }

        private void DepositButtonClick(object sender, EventArgs e)
        {
            this.balance = balance + amountInput.Value;
            balanceDisplay.Text = balance.ToString();
        }

        private void WithdrawButtonClick(object sender, EventArgs e)
        {
            var newBalance = balance - amountInput.Value;

            if (newBalance < 0)
            {
                MessageBox.Show("Your balance is too low to withdraw that amount.", "Balance too low");
                return;
            }

            this.balance = newBalance;
            balanceDisplay.Text = balance.ToString();
        }
    }
}
