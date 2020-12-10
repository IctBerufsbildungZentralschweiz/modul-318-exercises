namespace M318.Exercises.Nr2
{
    using System;
    using System.Windows.Forms;

    public partial class BreakfastForm : Form
    {
        private readonly object[] possibleIngredients =
            {
                "Brot",
                "Käse",
                "Butter",
                "Konfi",
                "Kaffee",
                "Müesli",
                "Apfel",
                "Banane"
            };

        public BreakfastForm()
        {
            InitializeComponent();
        }

        private void BreakfastFormLoad(object sender, EventArgs e)
        {
            breakfastOptionsComboBox.Items.AddRange(possibleIngredients);
            addButton.Enabled = false;
            removeButton.Enabled = false;
        }

        private void BreakfastOptionsSelectedIndexChanged(object sender, EventArgs e)
        {
            addButton.Enabled = breakfastOptionsComboBox.SelectedItem != null;
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            selectedBreakfastList.Items.Add(breakfastOptionsComboBox.SelectedItem);
            breakfastOptionsComboBox.Items.Remove(breakfastOptionsComboBox.SelectedItem);
            addButton.Enabled = false;
        }

        private void SelectedBreakfastSelectedIndexChanged(object sender, EventArgs e)
        {
            removeButton.Enabled = selectedBreakfastList.SelectedItem != null;
        }

        private void RemoveButtonClicked(object sender, EventArgs e)
        {
            RemoveCurrentFromSelected();
        }

        private void SelectedBreakfastDoubleClick(object sender, EventArgs e)
        {
            if (selectedBreakfastList.SelectedItem != null)
            {
                RemoveCurrentFromSelected();
            }
        }

        private void RemoveCurrentFromSelected()
        {
            breakfastOptionsComboBox.Items.Add(selectedBreakfastList.SelectedItem);
            selectedBreakfastList.Items.Remove(selectedBreakfastList.SelectedItem);
        }
    }
}
