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

        private void SavedSetupsPage_Load(object sender, EventArgs e)
        {
            string[] setupselection = new string[] { Properties.Settings.Default.FirstSetupName.ToString() };
            SetupSelection.Items.AddRange(setupselection);
        }

        private void LoadSetupButton_Click(object sender, EventArgs e)
        {

        }
    }
}
