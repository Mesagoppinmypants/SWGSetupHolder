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
            string[] first = new string[] { Properties.Settings.Default.FirstSetupName };
            string[] second = new string[] { Properties.Settings.Default.FirstSetupName, Properties.Settings.Default.SecondSetupName };
            string[] third = new string[] { Properties.Settings.Default.FirstSetupName, Properties.Settings.Default.SecondSetupName, Properties.Settings.Default.ThirdSetupName };
            string[] fourth = new string[] { Properties.Settings.Default.FirstSetupName, Properties.Settings.Default.SecondSetupName, Properties.Settings.Default.ThirdSetupName, Properties.Settings.Default.FourthSetupName };
            string[] fifth = new string[] { Properties.Settings.Default.FirstSetupName, Properties.Settings.Default.SecondSetupName, Properties.Settings.Default.ThirdSetupName, Properties.Settings.Default.FourthSetupName, Properties.Settings.Default.FifthSetupName };

            if (Properties.Settings.Default.FirstSetupName != "")
            {
                SetupSelection.Items.AddRange(first);
            }

            if (Properties.Settings.Default.FirstSetupName != "" && Properties.Settings.Default.SecondSetupName != "")
            {
                SetupSelection.Items.AddRange(second);
            }

            if (Properties.Settings.Default.FirstSetupName != "" && Properties.Settings.Default.SecondSetupName != "" && Properties.Settings.Default.ThirdSetupName != "")
            {
                SetupSelection.Items.AddRange(third);
            }

            if (Properties.Settings.Default.FirstSetupName != "" && Properties.Settings.Default.SecondSetupName != "" && Properties.Settings.Default.ThirdSetupName != "" && Properties.Settings.Default.FourthSetupName != "")
            {
                SetupSelection.Items.AddRange(fourth);
            }

            if (Properties.Settings.Default.FirstSetupName != "" && Properties.Settings.Default.SecondSetupName != "" && Properties.Settings.Default.ThirdSetupName != "" && Properties.Settings.Default.FourthSetupName != "" && Properties.Settings.Default.FifthSetupName != "")
            {
                SetupSelection.Items.AddRange(fifth);
            }
        }

        private void LoadSetupButton_Click(object sender, EventArgs e)
        {

        }
    }
}
