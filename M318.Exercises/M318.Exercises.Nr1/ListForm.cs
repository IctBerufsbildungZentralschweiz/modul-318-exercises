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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var text = $"{lbxTexts.Items.Count + 1}: {txbText.Text}";
            lbxTexts.Items.Add(text);
            txbText.Text = "";
        }

        private void txbText_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = txbText.Text.Length > 0;
        }
    }
}
