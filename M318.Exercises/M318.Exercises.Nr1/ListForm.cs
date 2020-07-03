using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M318.Exercises.Nr1
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            var text = $"{textsList.Items.Count + 1}: {textInput.Text}";
            textsList.Items.Add(text);
            textInput.Text = "";
        }

        private void TextInputChanged(object sender, EventArgs e)
        {
            addButton.Enabled = textInput.Text.Length > 0;
        }
    }
}
