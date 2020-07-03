namespace M318.Exercises.Nr2
{
    partial class BreakfastForm
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
            this.selectedBreakfastList = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.breakfastOptionsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // selectedBreakfastList
            // 
            this.selectedBreakfastList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedBreakfastList.FormattingEnabled = true;
            this.selectedBreakfastList.Location = new System.Drawing.Point(343, 12);
            this.selectedBreakfastList.Name = "selectedBreakfastList";
            this.selectedBreakfastList.Size = new System.Drawing.Size(250, 199);
            this.selectedBreakfastList.TabIndex = 7;
            this.selectedBreakfastList.SelectedIndexChanged += new System.EventHandler(this.SelectedBreakfastSelectedIndexChanged);
            this.selectedBreakfastList.DoubleClick += new System.EventHandler(this.SelectedBreakfastDoubleClick);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(269, 39);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(68, 23);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "<<";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButtonClicked);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(269, 10);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(68, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = ">>";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClicked);
            // 
            // breakfastOptionsComboBox
            // 
            this.breakfastOptionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.breakfastOptionsComboBox.FormattingEnabled = true;
            this.breakfastOptionsComboBox.Location = new System.Drawing.Point(13, 12);
            this.breakfastOptionsComboBox.Name = "breakfastOptionsComboBox";
            this.breakfastOptionsComboBox.Size = new System.Drawing.Size(250, 21);
            this.breakfastOptionsComboBox.TabIndex = 4;
            this.breakfastOptionsComboBox.SelectedIndexChanged += new System.EventHandler(this.BreakfastOptionsSelectedIndexChanged);
            // 
            // BreakfastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 223);
            this.Controls.Add(this.selectedBreakfastList);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.breakfastOptionsComboBox);
            this.Name = "BreakfastForm";
            this.Text = "M318 - Excercise 2 - Zmorge";
            this.Load += new System.EventHandler(this.BreakfastFormLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox selectedBreakfastList;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox breakfastOptionsComboBox;
    }
}

