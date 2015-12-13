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
                if (Properties.Settings.Default.FirstSetupName == "")
                {
                    Properties.Settings.Default.FirstSetupName = SetupNameInput.Text;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to overwrite setup #1?", "Warning", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                    {
                        Properties.Settings.Default.FirstSetupName = SetupNameInput.Text;
                    }
                }
            }

            if (SetupNumberInput.Text == "2")
            {
                if (Properties.Settings.Default.SecondSetupName == "")
                {
                    Properties.Settings.Default.SecondSetupName = SetupNameInput.Text;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to overwrite setup #2?", "Warning", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                    {
                        Properties.Settings.Default.SecondSetupName = SetupNameInput.Text;
                    }
                }
            }

            Properties.Settings.Default.Save();
            Dispose();
        }

        private void NewSetupPage_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstSetupName == "")
            {
                SetupNumberInput.SelectedIndex = 0;
            }
            
            if (Properties.Settings.Default.FirstSetupName != "" && Properties.Settings.Default.SecondSetupName == "")
            {
                SetupNumberInput.SelectedIndex = 1;
            }

            if (Properties.Settings.Default.FirstSetupName != "" && Properties.Settings.Default.SecondSetupName != "" && Properties.Settings.Default.ThirdSetupName == "")
            {
                SetupNumberInput.SelectedIndex = 2;
            }

            if (Properties.Settings.Default.FirstSetupName != "" && Properties.Settings.Default.SecondSetupName != "" && Properties.Settings.Default.ThirdSetupName != "" && Properties.Settings.Default.FourthSetupName == "")
            {
                SetupNumberInput.SelectedIndex = 3;
            }

            if (Properties.Settings.Default.FirstSetupName != "" && Properties.Settings.Default.SecondSetupName != "" && Properties.Settings.Default.ThirdSetupName != "" && Properties.Settings.Default.FourthSetupName != "" && Properties.Settings.Default.FifthSetupName == "")
            {
                SetupNumberInput.SelectedIndex = 4;
            }

        }

        private void WeaponInput_Click(object sender, EventArgs e)
        {
            WeaponInputInformation wii = new WeaponInputInformation();
            wii.ShowDialog();
        }
    }
}
