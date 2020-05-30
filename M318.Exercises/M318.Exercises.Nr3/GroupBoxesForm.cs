using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace M318.Exercises.Nr3
{
    public partial class GroupBoxesForm : Form
    {
        public GroupBoxesForm()
        {
            InitializeComponent();
        }

        private void btnShowResultSimple_Click(object sender, EventArgs e)
        {
            // Finde den Fehler

            var message = "Selected:\n";
            if (rbtOption11.Checked)
            {
                message += rbtOption11.Text + "\n";
            }
            if (rbtOption12.Checked)
            {
                message += rbtOption12.Text + "\n";
            }
            if (rbtOption13.Checked)
            {
                message += rbtOption13.Text + "\n";
            }

            if (rbtOption21.Checked)
            {
                message += rbtOption21.Text + "\n";
            }
            if (rbtOption22.Checked)
            {
                message += rbtOption22.Text + "\n";
            }
            if (rbtOption23.Checked)
            {
                message += rbtOption22.Text + "\n";
            }

            if (chbFirst.Checked)
            {
                message += chbFirst.Text + "\n";
            }
            if (chbSecond.Checked)
            {
                message += chbSecond.Text + "\n";
            }
            if (chbThird.Checked)
            {
                message += chbThird.Text + "\n";
            }

            MessageBox.Show(message);
        }

        private void btnShowResultAdvanced_Click(object sender, EventArgs e)
        {
            var message = "Selected:\n";
            message += FindSelectedRadioButton(gbxRadioButtons1);
            message += FindSelectedRadioButton(gbxRadioButtons2);

            foreach (var checkBox in gbxCheckBoxes.Controls.OfType<CheckBox>().ToList())
            {
                if (checkBox.Checked)
                {
                    message += $"{checkBox.Text}\n";
                }
            }

            MessageBox.Show(message);
        }

        private string FindSelectedRadioButton(GroupBox groupBox)
        {
            foreach (var radioButton in groupBox.Controls.OfType<RadioButton>().ToList())
            {
                if (radioButton.Checked)
                {
                    return $"{radioButton.Text}\n";
                }
            }

            return "";
        }
    }
}
