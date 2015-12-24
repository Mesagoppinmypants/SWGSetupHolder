using System;
using System.Windows.Forms;

namespace TrooperSetupOrganizer
{
    public partial class WearablesForm : Form
    {
        public WearablesForm()
        {
            InitializeComponent();
        }

        private void ArmorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ArmorCheckbox.Checked)
            {
                RobeCheckbox.Checked = false;
                ArmorInputButton.Text = "Armor";
            }

            if (!ArmorCheckbox.Checked && !RobeCheckbox.Checked)
            {
                ArmorCheckbox.Checked = true;
            }
        }

        private void RobeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (RobeCheckbox.Checked)
            {
                ArmorCheckbox.Checked = false;
                ArmorInputButton.Text = "Robe/Cloak";
            }

            if (!ArmorCheckbox.Checked && !RobeCheckbox.Checked)
            {
                RobeCheckbox.Checked = true;
            }
        }

        private void ArmorInputButton_Click(object sender, EventArgs e)
        {
            if (ArmorCheckbox.Checked)
            {
                ArmorInputInformation aii = new ArmorInputInformation();
                aii.ShowDialog();
            }
            else
            {
                RobeInputInformation rii = new RobeInputInformation();
                rii.ShowDialog();
            }
        }

        private void WeaponInputButton_Click(object sender, EventArgs e)
        {
            WeaponInputInformation wii = new WeaponInputInformation();
            wii.ShowDialog();
        }

        private void ClothingInputButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, but this function isn't implemented yet.", "Error");
        }
    }
}
