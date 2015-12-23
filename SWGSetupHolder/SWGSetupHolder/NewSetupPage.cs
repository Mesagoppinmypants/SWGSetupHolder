using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TrooperSetupOrganizer
{
    public partial class NewSetupPage : Form
    {
        public NewSetupPage()
        {
            InitializeComponent();
        }

        private void FirstSetupSave()
        {
            Properties.Settings.Default.FirstSetupName = SetupNameInput.Text;
            Properties.Settings.Default.FirstSetupProfession = ProfessionInput.Text;
            Properties.Settings.Default.FirstSetupExpertise = ExpertiseInput.Text;
            Properties.Settings.Default.Save();
            Dispose();
        }

        private void SecondSetupSave()
        {
            Properties.Settings.Default.SecondSetupName = SetupNameInput.Text;
            Properties.Settings.Default.SecondSetupProfession = ProfessionInput.Text;
            Properties.Settings.Default.SecondSetupExpertise = ExpertiseInput.Text;
            Properties.Settings.Default.Save();
            Dispose();
        }

        private void ThirdSetupSave()
        {
            Properties.Settings.Default.ThirdSetupName = SetupNameInput.Text;
            Properties.Settings.Default.ThirdSetupProfession = ProfessionInput.Text;
            Properties.Settings.Default.ThirdSetupExpertise = ExpertiseInput.Text;
            Properties.Settings.Default.Save();
            Dispose();
        }

        private void FourthSetupSave()
        {
            Properties.Settings.Default.FourthSetupName = SetupNameInput.Text;
            Properties.Settings.Default.FourthSetupProfession = ProfessionInput.Text;
            Properties.Settings.Default.FourthSetupExpertise = ExpertiseInput.Text;
            Properties.Settings.Default.Save();
            Dispose();
        }

        private void FifthSetupSave()
        {
            Properties.Settings.Default.FifthSetupName = SetupNameInput.Text;
            Properties.Settings.Default.FifthSetupProfession = ProfessionInput.Text;
            Properties.Settings.Default.FifthSetupExpertise = ExpertiseInput.Text;
            Properties.Settings.Default.Save();
            Dispose();
        }

        private void SaveNewSetupButton_Click(object sender, EventArgs e)
        {
            if (SetupNameInput.Text != "" && SetupNameInput.Text != Properties.Settings.Default.FirstSetupName && SetupNameInput.Text != Properties.Settings.Default.SecondSetupName && SetupNameInput.Text != Properties.Settings.Default.ThirdSetupName && SetupNameInput.Text != Properties.Settings.Default.FourthSetupName && SetupNameInput.Text != Properties.Settings.Default.FifthSetupName)
            {
                if (SetupNumberInput.Text == "1")
                {
                    if (Properties.Settings.Default.FirstSetupName == "")
                    {
                        FirstSetupSave();
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you want to overwrite setup #1?", "Warning", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {
                            FirstSetupSave();
                        }
                    }
                }

                if (SetupNumberInput.Text == "2")
                {
                    if (Properties.Settings.Default.SecondSetupName == "")
                    {
                        SecondSetupSave();
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you want to overwrite setup #2?", "Warning", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {
                            SecondSetupSave();
                        }
                    }
                }

                if (SetupNumberInput.Text == "3")
                {
                    if (Properties.Settings.Default.ThirdSetupName == "")
                    {
                        ThirdSetupSave();
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you want to overwrite setup #3?", "Warning", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {
                            ThirdSetupSave();
                        }
                    }
                }

                if (SetupNumberInput.Text == "4")
                {
                    if (Properties.Settings.Default.FourthSetupName == "")
                    {
                        FourthSetupSave();
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you want to overwrite setup #4?", "Warning", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {
                            FourthSetupSave();
                        }
                    }
                }

                if (SetupNumberInput.Text == "5")
                {
                    if (Properties.Settings.Default.FifthSetupName == "")
                    {
                        FifthSetupSave();
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you want to overwrite setup #5?", "Warning", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {
                            FifthSetupSave();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: Please enter a valid setup name. The current name that you are trying to save the setup as may be already in use.", "Error Saving");
            }
            
        }

        private void NewSetupPage_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstSetupName == "")
            {
                SetupNumberInput.Text = "1";
            }
            
            if (Properties.Settings.Default.FirstSetupName != "" && Properties.Settings.Default.SecondSetupName == "")
            {
                SetupNumberInput.Text = "2";
            }

            if (Properties.Settings.Default.FirstSetupName != "" && Properties.Settings.Default.SecondSetupName != "" && Properties.Settings.Default.ThirdSetupName == "")
            {
                SetupNumberInput.Text = "3";
            }

            if (Properties.Settings.Default.FirstSetupName != "" && Properties.Settings.Default.SecondSetupName != "" && Properties.Settings.Default.ThirdSetupName != "" && Properties.Settings.Default.FourthSetupName == "")
            {
                SetupNumberInput.Text = "4";
            }

            if (Properties.Settings.Default.FirstSetupName != "" && Properties.Settings.Default.SecondSetupName != "" && Properties.Settings.Default.ThirdSetupName != "" && Properties.Settings.Default.FourthSetupName != "" && Properties.Settings.Default.FifthSetupName == "")
            {
                SetupNumberInput.Text = "5";
            }

            Properties.Settings.Default.GetCurrentSetupNumber = SetupNumberInput.Text;

        }

        private void WeaponInput_Click(object sender, EventArgs e)
        {
            WeaponInputInformation wii = new WeaponInputInformation();
            wii.ShowDialog();
        }

        private void ArmorInput_Click(object sender, EventArgs e)
        {
            ArmorInputInformation aii = new ArmorInputInformation();
            aii.ShowDialog();
        }

        private void CreateExpertiseButton_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.oekevo.org/expertisecalculator/");
        }
    }
}
