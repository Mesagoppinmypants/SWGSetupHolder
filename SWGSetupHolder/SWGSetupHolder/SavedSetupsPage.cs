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
            string[] second = new string[] { Properties.Settings.Default.SecondSetupName };
            string[] third = new string[] { Properties.Settings.Default.ThirdSetupName };
            string[] fourth = new string[] { Properties.Settings.Default.FourthSetupName };
            string[] fifth = new string[] { Properties.Settings.Default.FifthSetupName };

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
            if (SetupSelection.SelectedIndex >= 0)
            {
                LoadedSetup ls = new LoadedSetup();
                ls.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a valid saved setup.", "Error");
            }
        }

        private void SetupSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SetupSelection.SelectedIndex == 0)
            {
                Properties.Settings.Default.CurrentSetupNumber = "1";
            }

            if (SetupSelection.SelectedIndex == 1)
            {
                Properties.Settings.Default.CurrentSetupNumber = "2";
            }

            if (SetupSelection.SelectedIndex == 2)
            {
                Properties.Settings.Default.CurrentSetupNumber = "3";
            }

            if (SetupSelection.SelectedIndex == 3)
            {
                Properties.Settings.Default.CurrentSetupNumber = "4";
            }

            if (SetupSelection.SelectedIndex == 4)
            {
                Properties.Settings.Default.CurrentSetupNumber = "5";
            }
            Properties.Settings.Default.Save();
        }
    }
}
