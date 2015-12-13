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
                Properties.Settings.Default.FirstSetupName = "";
                Properties.Settings.Default.SecondSetupName = "";
                Properties.Settings.Default.ThirdSetupName = "";
                Properties.Settings.Default.FourthSetupName = "";
                Properties.Settings.Default.FifthSetupName = "";
                MessageBox.Show("All data has been successfully deleted.");
            }
        }
    }
}
