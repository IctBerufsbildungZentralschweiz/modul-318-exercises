namespace M318.Exercises.Nr4_1
{
    partial class BankAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.amountLabel = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceDisplay = new System.Windows.Forms.Label();
            this.amountInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amountInput)).BeginInit();
            this.SuspendLayout();
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(12, 15);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(46, 13);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "Amount:";
            // 
            // depositButton
            // 
            this.depositButton.Enabled = false;
            this.depositButton.Location = new System.Drawing.Point(170, 10);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(125, 23);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.DepositButtonClick);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Enabled = false;
            this.withdrawButton.Location = new System.Drawing.Point(170, 39);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(125, 23);
            this.withdrawButton.TabIndex = 3;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.WithdrawButtonClick);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(12, 65);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(49, 13);
            this.balanceLabel.TabIndex = 5;
            this.balanceLabel.Text = "Balance:";
            // 
            // balanceDisplay
            // 
            this.balanceDisplay.AutoSize = true;
            this.balanceDisplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.balanceDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.balanceDisplay.Location = new System.Drawing.Point(67, 65);
            this.balanceDisplay.Name = "balanceDisplay";
            this.balanceDisplay.Size = new System.Drawing.Size(28, 13);
            this.balanceDisplay.TabIndex = 6;
            this.balanceDisplay.Text = "0.00";
            // 
            // amountInput
            // 
            this.amountInput.DecimalPlaces = 2;
            this.amountInput.Location = new System.Drawing.Point(64, 13);
            this.amountInput.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(100, 20);
            this.amountInput.TabIndex = 0;
            this.amountInput.ValueChanged += new System.EventHandler(this.AmountInputChanged);
            // 
            // BankAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 94);
            this.Controls.Add(this.amountInput);
            this.Controls.Add(this.balanceDisplay);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.amountLabel);
            this.Name = "BankAccountForm";
            this.Text = "M318 - Exercise 4 - Bank Account";
            ((System.ComponentModel.ISupportInitialize)(this.amountInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label balanceDisplay;
        private System.Windows.Forms.NumericUpDown amountInput;
    }
}

