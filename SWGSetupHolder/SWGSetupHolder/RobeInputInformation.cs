using System;
using System.Drawing;
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
                RobeNameLabel.Location = new Point(103, 109);
                RobeNameLabel.Text = "Robe Name";
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
                RobeNameLabel.Location = new Point(80, 109);
                RobeNameLabel.Text = "Cloak Name (Hood Up)";
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
                RobeNameLabel.Location = new Point(80, 109);
                RobeNameLabel.Text = "Cloak Name (Hood Down)";
            }
            else
            {
                RobeNameLabel.Location = new Point(80, 109);
                RobeNameLabel.Text = "Cloak Name (Hood Up)";
            }
        }

        private void SaveRobeInfoButton_Click(object sender, EventArgs e)
        {
            NewSetupPage nsp = new NewSetupPage();
            if (nsp.SetupNumberInput.Text == "1")
            {
                Properties.Settings.Default.FirstRobeName = RobeNameLabel.Text;
            }

            if (nsp.SetupNumberInput.Text == "2")
            {
                Properties.Settings.Default.SecondRobeName = RobeNameLabel.Text;
            }

            if (nsp.SetupNumberInput.Text == "3")
            {
                Properties.Settings.Default.ThirdRobeName = RobeNameLabel.Text;
            }

            if (nsp.SetupNumberInput.Text == "4")
            {
                Properties.Settings.Default.FourthRobeName = RobeNameLabel.Text;
            }

            if (nsp.SetupNumberInput.Text == "5")
            {
                Properties.Settings.Default.FifthRobeName = RobeNameLabel.Text;
            }
            Dispose();
        }
    }
}
