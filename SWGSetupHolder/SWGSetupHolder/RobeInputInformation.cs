using System;
using System.Windows.Forms;

namespace TrooperSetupOrganizer
{
    public partial class RobeInputInformation : Form
    {
        public RobeInputInformation()
        {
            InitializeComponent();
        }

        private void RobeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (RobeCheckbox.Checked)
            {
                CloakCheckbox.Checked = false;
                RobeNameLabel.Text = "Robe";
                HoodDownCheckbox.Visible = false;
            }

            if (!RobeCheckbox.Checked && !CloakCheckbox.Checked)
            {
                RobeCheckbox.Checked = true;
            }
        }

        private void CloakCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (CloakCheckbox.Checked)
            {
                RobeCheckbox.Checked = false;
                RobeNameLabel.Text = "Cloak (Hood Up)";
                HoodDownCheckbox.Visible = true;   
            }

            if (!RobeCheckbox.Checked && !CloakCheckbox.Checked)
            {
                CloakCheckbox.Checked = true;
            }
        }

        private void RobeInputInformation_Load(object sender, EventArgs e)
        {
            HoodDownCheckbox.Visible = false;
        }

        private void HoodDownCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (HoodDownCheckbox.Checked)
            {
                RobeNameLabel.Text = "Cloak (Hood Down)";
            }
            else
            {
                RobeNameLabel.Text = "Cloak (Hood Up)";
            }
        }

        private void SaveRobeInfoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
