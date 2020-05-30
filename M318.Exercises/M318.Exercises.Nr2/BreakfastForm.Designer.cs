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
            this.lbxSelectedBreakfast = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxBreakfastOptions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbxSelectedBreakfast
            // 
            this.lbxSelectedBreakfast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxSelectedBreakfast.FormattingEnabled = true;
            this.lbxSelectedBreakfast.Location = new System.Drawing.Point(343, 12);
            this.lbxSelectedBreakfast.Name = "lbxSelectedBreakfast";
            this.lbxSelectedBreakfast.Size = new System.Drawing.Size(250, 199);
            this.lbxSelectedBreakfast.TabIndex = 7;
            this.lbxSelectedBreakfast.SelectedIndexChanged += new System.EventHandler(this.lbxSelectedBreakfast_SelectedIndexChanged);
            this.lbxSelectedBreakfast.DoubleClick += new System.EventHandler(this.lbxSelectedBreakfast_DoubleClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(269, 39);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(68, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(269, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxBreakfastOptions
            // 
            this.cbxBreakfastOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBreakfastOptions.FormattingEnabled = true;
            this.cbxBreakfastOptions.Location = new System.Drawing.Point(13, 12);
            this.cbxBreakfastOptions.Name = "cbxBreakfastOptions";
            this.cbxBreakfastOptions.Size = new System.Drawing.Size(250, 21);
            this.cbxBreakfastOptions.TabIndex = 4;
            this.cbxBreakfastOptions.SelectedIndexChanged += new System.EventHandler(this.cbxBreakfastOptions_SelectedIndexChanged);
            // 
            // BreakfastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 223);
            this.Controls.Add(this.lbxSelectedBreakfast);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxBreakfastOptions);
            this.Name = "BreakfastForm";
            this.Text = "M318 - Zmorge";
            this.Load += new System.EventHandler(this.BreakfastForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSelectedBreakfast;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxBreakfastOptions;
    }
}

