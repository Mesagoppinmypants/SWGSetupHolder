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
            NewSetupPage nsp = new NewSetupPage();
            nsp.ShowDialog();
        }

        private void ViewSavedSetupsButton_Click(object sender, EventArgs e)
        {
            SavedSetupsPage ssp = new SavedSetupsPage();
            ssp.ShowDialog();
        }
    }
}
