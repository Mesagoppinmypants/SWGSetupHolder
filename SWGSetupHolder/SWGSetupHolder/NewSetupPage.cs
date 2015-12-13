using System;
using System.Windows.Forms;

namespace SWGSetupHolder
{
    public partial class NewSetupPage : Form
    {
        public NewSetupPage()
        {
            InitializeComponent();
        }

        private void SaveNewSetupButton_Click(object sender, EventArgs e)
        {
            if (SetupNumberInput.Text == "1")
            {
                Properties.Settings.Default.FirstSetupName = SetupNameInput.Text;
            }
            
            Properties.Settings.Default.Save();
            Dispose();
        }

        private void NewSetupPage_Load(object sender, EventArgs e)
        {
            string FindUnusedIndex;
            FindUnusedIndex = Properties.Settings.Default.FirstSetupName;

            if (FindUnusedIndex == "")
            {
                SetupNumberInput.SelectedIndex = 0;
            }
            else
            {
                SetupNumberInput.SelectedIndex = 1;
            }
        }
    }
}
