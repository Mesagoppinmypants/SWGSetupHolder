using System;
using System.Windows.Forms;

namespace SWGSetupHolder
{
    public partial class NewSetupPage : Form
    {
        //public static string FirstSetupName;

        public NewSetupPage()
        {
            InitializeComponent();
        }

        private void SaveNewSetupButton_Click(object sender, EventArgs e)
        {
            //FirstSetupName = SetupNameInput.Text;
            Properties.Settings.Default.FirstSetupName = SetupNameInput.Text;
            Properties.Settings.Default.Save();
            Dispose();
        }

        private void NewSetupPage_Load(object sender, EventArgs e)
        {

        }
    }
}
