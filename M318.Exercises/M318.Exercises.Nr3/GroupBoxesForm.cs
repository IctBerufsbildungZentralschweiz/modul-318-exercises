namespace M318.Exercises.Nr3
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class GroupBoxesForm : Form
    {
        public GroupBoxesForm()
        {
            InitializeComponent();
        }

        private void ShowResultSimpleClicked(object sender, EventArgs e)
        {
            // Finde den Fehler
            var message = "Selected:\n";
            if (radioButtonOption11.Checked)
            {
                message += radioButtonOption11.Text + "\n";
            }

            if (radioButtonOption12.Checked)
            {
                message += radioButtonOption12.Text + "\n";
            }

            if (radioButtonOption13.Checked)
            {
                message += radioButtonOption13.Text + "\n";
            }

            if (radioButtonOption22.Checked)
            {
                message += radioButtonOption22.Text + "\n";
            }

            if (radioButtonOption21.Checked)
            {
                message += radioButtonOption21.Text + "\n";
            }

            if (radioButtonOption23.Checked)
            {
                message += radioButtonOption21.Text + "\n";
            }

            if (firstCheckBox.Checked)
            {
                message += firstCheckBox.Text + "\n";
            }

            if (secondCheckBox.Checked)
            {
                message += secondCheckBox.Text + "\n";
            }

            if (thirdCheckBox.Checked)
            {
                message += thirdCheckBox.Text + "\n";
            }

            MessageBox.Show(message);
        }

        private void ShowResultAdvancedClicked(object sender, EventArgs e)
        {
            var message = "Selected:\n";
            message += FindSelectedRadioButton(radioButtonsBox1);
            message += FindSelectedRadioButton(radioButtonsBox2);

            foreach (var checkBox in checkBoxesGroup.Controls.OfType<CheckBox>().ToList())
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

            return string.Empty;
        }
    }
}
