using System;
using System.Windows.Forms;

namespace SWGSetupHolder
{
    public partial class SavedSetupsPage : Form
    {
        public SavedSetupsPage()
        {
            InitializeComponent();
        }

        //private string FirstSavedSetup = "";

        private void SavedSetupsPage_Load(object sender, EventArgs e)
        {
            //FirstSavedSetup = Properties.Settings.Default.FirstSetupName;
            string[] setupselection = new string[] { Properties.Settings.Default.FirstSetupName };
            SetupSelection.Text = Properties.Settings.Default.FirstSetupName;
        }

        private void LoadSetupButton_Click(object sender, EventArgs e)
        {

        }
    }
}
