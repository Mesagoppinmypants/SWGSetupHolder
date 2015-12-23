using System;
using System.Windows.Forms;

namespace TrooperSetupOrganizer
{
    public partial class LoadedSetup : Form
    {
        public LoadedSetup()
        {
            InitializeComponent();
        }

        private void LoadedSetup_Load(object sender, EventArgs e)
        {
            SavedSetupsPage ssp = new SavedSetupsPage();
            SetupNumberInput.Text = Properties.Settings.Default.CurrentSetupNumber;

            if (Properties.Settings.Default.CurrentSetupNumber == "1")
            {
                SetupNameInput.Text = Properties.Settings.Default.FirstSetupName;
                ProfessionInput.Text = Properties.Settings.Default.FirstSetupProfession;
                ExpertiseInput.Text = Properties.Settings.Default.FirstSetupExpertise;
            }

            if (Properties.Settings.Default.CurrentSetupNumber == "2")
            {
                SetupNameInput.Text = Properties.Settings.Default.SecondSetupName;
                ProfessionInput.Text = Properties.Settings.Default.SecondSetupProfession;
                ExpertiseInput.Text = Properties.Settings.Default.SecondSetupExpertise;
            }

            if (Properties.Settings.Default.CurrentSetupNumber == "3")
            {
                SetupNameInput.Text = Properties.Settings.Default.ThirdSetupName;
                ProfessionInput.Text = Properties.Settings.Default.ThirdSetupProfession;
                ExpertiseInput.Text = Properties.Settings.Default.ThirdSetupExpertise;
            }

            if (Properties.Settings.Default.CurrentSetupNumber == "4")
            {
                SetupNameInput.Text = Properties.Settings.Default.FourthSetupName;
                ProfessionInput.Text = Properties.Settings.Default.FourthSetupProfession;
                ExpertiseInput.Text = Properties.Settings.Default.FourthSetupExpertise;
            }

            if (Properties.Settings.Default.CurrentSetupNumber == "5")
            {
                SetupNameInput.Text = Properties.Settings.Default.FifthSetupName;
                ProfessionInput.Text = Properties.Settings.Default.FifthSetupProfession;
                ExpertiseInput.Text = Properties.Settings.Default.FifthSetupExpertise;
            }
        }

        private void WeaponInput_Click(object sender, EventArgs e)
        {
            WeaponOutputInformation woi = new WeaponOutputInformation();
            woi.ShowDialog();
        }

        private void ArmorInput_Click(object sender, EventArgs e)
        {
            ArmorOutputInformation aoi = new ArmorOutputInformation();
            aoi.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (EditButton.Text == "Edit")
            {
                Properties.Settings.Default.EditButtonEnabled = true;

                EditButton.Text = "Save";
                SetupNameInput.ReadOnly = false;
                ProfessionInput.ReadOnly = false;
                ExpertiseInput.ReadOnly = false;
            }
            else
            {
                Properties.Settings.Default.EditButtonEnabled = false;

                EditButton.Text = "Edit";
                SetupNameInput.ReadOnly = true;
                ProfessionInput.ReadOnly = true;
                ExpertiseInput.ReadOnly = true;

                if (SetupNumberInput.Text == "1")
                {
                    Properties.Settings.Default.FirstSetupName = SetupNameInput.Text;
                    Properties.Settings.Default.FirstSetupProfession = ProfessionInput.Text;
                    Properties.Settings.Default.FirstSetupExpertise = ExpertiseInput.Text;
                    Properties.Settings.Default.Save();
                }

                if (SetupNumberInput.Text == "2")
                {
                    Properties.Settings.Default.SecondSetupName = SetupNameInput.Text;
                    Properties.Settings.Default.SecondSetupProfession = ProfessionInput.Text;
                    Properties.Settings.Default.SecondSetupExpertise = ExpertiseInput.Text;
                    Properties.Settings.Default.Save();
                }

                if (SetupNumberInput.Text == "3")
                {
                    Properties.Settings.Default.ThirdSetupName = SetupNameInput.Text;
                    Properties.Settings.Default.ThirdSetupProfession = ProfessionInput.Text;
                    Properties.Settings.Default.ThirdSetupExpertise = ExpertiseInput.Text;
                    Properties.Settings.Default.Save();
                }

                if (SetupNumberInput.Text == "4")
                {
                    Properties.Settings.Default.FourthSetupName = SetupNameInput.Text;
                    Properties.Settings.Default.FourthSetupProfession = ProfessionInput.Text;
                    Properties.Settings.Default.FourthSetupExpertise = ExpertiseInput.Text;
                    Properties.Settings.Default.Save();
                }

                if (SetupNumberInput.Text == "5")
                {
                    Properties.Settings.Default.FifthSetupName = SetupNameInput.Text;
                    Properties.Settings.Default.FifthSetupProfession = ProfessionInput.Text;
                    Properties.Settings.Default.FifthSetupExpertise = ExpertiseInput.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }
    }
}
