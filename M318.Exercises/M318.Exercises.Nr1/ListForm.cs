namespace M318.Exercises.Nr1
{
    using System;
    using System.Windows.Forms;

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
            textInput.Text = string.Empty;
        }

        private void TextInputChanged(object sender, EventArgs e)
        {
            addButton.Enabled = textInput.Text.Length > 0;
        }
    }
}
