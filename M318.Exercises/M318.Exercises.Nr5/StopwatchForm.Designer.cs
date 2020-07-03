namespace M318.Exercises.Nr5
{
    partial class StopwatchForm
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
            this.components = new System.ComponentModel.Container();
            this.timeDisplay = new System.Windows.Forms.TextBox();
            this.startStopButton = new System.Windows.Forms.Button();
            this.lapResetButton = new System.Windows.Forms.Button();
            this.lapList = new System.Windows.Forms.ListBox();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timeDisplay
            // 
            this.timeDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeDisplay.Enabled = false;
            this.timeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDisplay.Location = new System.Drawing.Point(12, 12);
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.ReadOnly = true;
            this.timeDisplay.Size = new System.Drawing.Size(284, 53);
            this.timeDisplay.TabIndex = 0;
            this.timeDisplay.Text = "00:00:00";
            this.timeDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(12, 71);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(100, 23);
            this.startStopButton.TabIndex = 1;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.StartStopButtonClick);
            // 
            // lapResetButton
            // 
            this.lapResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lapResetButton.Location = new System.Drawing.Point(196, 71);
            this.lapResetButton.Name = "lapResetButton";
            this.lapResetButton.Size = new System.Drawing.Size(100, 23);
            this.lapResetButton.TabIndex = 2;
            this.lapResetButton.Text = "Lap";
            this.lapResetButton.UseVisualStyleBackColor = true;
            this.lapResetButton.Click += new System.EventHandler(this.LapResetButtonClick);
            // 
            // lapList
            // 
            this.lapList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lapList.FormattingEnabled = true;
            this.lapList.Location = new System.Drawing.Point(12, 100);
            this.lapList.Name = "lapList";
            this.lapList.Size = new System.Drawing.Size(284, 342);
            this.lapList.TabIndex = 3;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 50;
            this.refreshTimer.Tick += new System.EventHandler(this.RefreshTimerTick);
            // 
            // StopwatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 454);
            this.Controls.Add(this.lapList);
            this.Controls.Add(this.lapResetButton);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.timeDisplay);
            this.Name = "StopwatchForm";
            this.Text = "M318 - Exercise 5 - Stopwatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timeDisplay;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Button lapResetButton;
        private System.Windows.Forms.ListBox lapList;
        private System.Windows.Forms.Timer refreshTimer;
    }
}

