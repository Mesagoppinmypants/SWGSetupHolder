using System;
using System.Windows.Forms;

namespace SWGSetupHolder
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MakeNewSetupButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstSetupName != "" && Properties.Settings.Default.SecondSetupName != "" && Properties.Settings.Default.ThirdSetupName != "" && Properties.Settings.Default.FourthSetupName != "" && Properties.Settings.Default.FifthSetupName != "")
            {
                MessageBox.Show("You have already reached your max limit of setups to save, please delete one to be able to make another one.", "Error");
            }
            else
            {
                NewSetupPage nsp = new NewSetupPage();
                nsp.ShowDialog();
            }
        }

        private void ViewSavedSetupsButton_Click(object sender, EventArgs e)
        {
            SavedSetupsPage ssp = new SavedSetupsPage();
            ssp.ShowDialog();
        }

        private void DeleteAllSetupsButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete all saved setups?", "Warning", MessageBoxButtons.YesNo);
            
            if (dr == DialogResult.Yes)
            {
                // Delete All Name Data
                Properties.Settings.Default.FirstSetupName = "";
                Properties.Settings.Default.SecondSetupName = "";
                Properties.Settings.Default.ThirdSetupName = "";
                Properties.Settings.Default.FourthSetupName = "";
                Properties.Settings.Default.FifthSetupName = "";

                // Delete All Profession Data
                Properties.Settings.Default.FirstSetupProfession = "";
                Properties.Settings.Default.SecondSetupProfession = "";
                Properties.Settings.Default.ThirdSetupProfession = "";
                Properties.Settings.Default.FourthSetupProfession = "";
                Properties.Settings.Default.FifthSetupProfession = "";

                // Delete All Expertise Data
                Properties.Settings.Default.FirstSetupExpertise = "";
                Properties.Settings.Default.SecondSetupExpertise = "";
                Properties.Settings.Default.ThirdSetupExpertise = "";
                Properties.Settings.Default.FourthSetupExpertise = "";
                Properties.Settings.Default.FifthSetupExpertise = "";

                MessageBox.Show("All data has been successfully deleted.");
            }
        }
    }
}
