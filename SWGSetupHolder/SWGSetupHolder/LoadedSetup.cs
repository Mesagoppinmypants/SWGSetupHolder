using System;
using System.Windows.Forms;

namespace SWGSetupHolder
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
    }
}
