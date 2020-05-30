using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M318.Exercises.Nr2
{
    public partial class BreakfastForm : Form
    {
        private readonly string[] possibleIngredients = new string[]
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

        private void BreakfastForm_Load(object sender, EventArgs e)
        {
            cbxBreakfastOptions.Items.AddRange(possibleIngredients);
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void cbxBreakfastOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = cbxBreakfastOptions.SelectedItem != null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbxSelectedBreakfast.Items.Add(cbxBreakfastOptions.SelectedItem);
            cbxBreakfastOptions.Items.Remove(cbxBreakfastOptions.SelectedItem);
            btnAdd.Enabled = false;
        }

        private void lbxSelectedBreakfast_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = lbxSelectedBreakfast.SelectedItem != null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveCurrentFromSelected();
        }

        private void lbxSelectedBreakfast_DoubleClick(object sender, EventArgs e)
        {
            if (lbxSelectedBreakfast.SelectedItem != null)
            {
                RemoveCurrentFromSelected();
            }
        }

        private void RemoveCurrentFromSelected()
        {
            cbxBreakfastOptions.Items.Add(lbxSelectedBreakfast.SelectedItem);
            lbxSelectedBreakfast.Items.Remove(lbxSelectedBreakfast.SelectedItem);
        }
    }
}
