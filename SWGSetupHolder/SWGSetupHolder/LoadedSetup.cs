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
            DiscardButton.Visible = false;
            SaveButton.Visible = false;

            LoadSelectedSetup();
        }

        private void LoadSelectedSetup()
        {
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

        private void WearablesInput_Click(object sender, EventArgs e)
        {
            WearablesForm wf = new WearablesForm();
            wf.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EditButtonEnabled = true;
            SetupNameInput.ReadOnly = false;
            ProfessionInput.ReadOnly = false;
            ExpertiseInput.ReadOnly = false;
            EditButton.Visible = false;
            SaveButton.Visible = true;
            DiscardButton.Visible = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement a way so you can't edit the setup name exactly like another one.
            if (SetupNumberInput.Text == "1")
            {
                if (SetupNameInput.Text != Properties.Settings.Default.SecondSetupName || SetupNameInput.Text != Properties.Settings.Default.ThirdSetupName || SetupNameInput.Text !=  Properties.Settings.Default.FourthSetupName || SetupNameInput.Text !=  Properties.Settings.Default.FifthSetupName)
                {
                    Properties.Settings.Default.EditButtonEnabled = false;
                    Properties.Settings.Default.FirstSetupName = SetupNameInput.Text;
                    Properties.Settings.Default.FirstSetupProfession = ProfessionInput.Text;
                    Properties.Settings.Default.FirstSetupExpertise = ExpertiseInput.Text;
                    Properties.Settings.Default.Save();
                    DoneEditing();
                }
            }
            else if (SetupNumberInput.Text == "2")
            {
                if (SetupNameInput.Text != Properties.Settings.Default.FirstSetupName || SetupNameInput.Text != Properties.Settings.Default.ThirdSetupName || SetupNameInput.Text != Properties.Settings.Default.FourthSetupName || SetupNameInput.Text != Properties.Settings.Default.FifthSetupName)
                {
                    Properties.Settings.Default.EditButtonEnabled = false;
                    Properties.Settings.Default.SecondSetupName = SetupNameInput.Text;
                    Properties.Settings.Default.SecondSetupProfession = ProfessionInput.Text;
                    Properties.Settings.Default.SecondSetupExpertise = ExpertiseInput.Text;
                    Properties.Settings.Default.Save();
                    DoneEditing();
                }
            }
            else if (SetupNumberInput.Text == "3")
            {
                if (SetupNameInput.Text != Properties.Settings.Default.FirstSetupName || SetupNameInput.Text != Properties.Settings.Default.SecondSetupName || SetupNameInput.Text != Properties.Settings.Default.FourthSetupName || SetupNameInput.Text != Properties.Settings.Default.FifthSetupName)
                {
                    Properties.Settings.Default.EditButtonEnabled = false;
                    Properties.Settings.Default.ThirdSetupName = SetupNameInput.Text;
                    Properties.Settings.Default.ThirdSetupProfession = ProfessionInput.Text;
                    Properties.Settings.Default.ThirdSetupExpertise = ExpertiseInput.Text;
                    Properties.Settings.Default.Save();
                    DoneEditing();
                }
            }
            else if (SetupNumberInput.Text == "4")
            {
                if (SetupNameInput.Text != Properties.Settings.Default.FirstSetupName || SetupNameInput.Text != Properties.Settings.Default.SecondSetupName || SetupNameInput.Text != Properties.Settings.Default.ThirdSetupName || SetupNameInput.Text != Properties.Settings.Default.FifthSetupName)
                {
                    Properties.Settings.Default.EditButtonEnabled = false;
                    Properties.Settings.Default.FourthSetupName = SetupNameInput.Text;
                    Properties.Settings.Default.FourthSetupProfession = ProfessionInput.Text;
                    Properties.Settings.Default.FourthSetupExpertise = ExpertiseInput.Text;
                    Properties.Settings.Default.Save();
                    DoneEditing();
                }
            }
            else if (SetupNumberInput.Text == "5")
            {
                if (SetupNameInput.Text != Properties.Settings.Default.FirstSetupName || SetupNameInput.Text != Properties.Settings.Default.SecondSetupName || SetupNameInput.Text != Properties.Settings.Default.ThirdSetupName || SetupNameInput.Text != Properties.Settings.Default.FourthSetupName)
                {
                    Properties.Settings.Default.EditButtonEnabled = false;
                    Properties.Settings.Default.FifthSetupName = SetupNameInput.Text;
                    Properties.Settings.Default.FifthSetupProfession = ProfessionInput.Text;
                    Properties.Settings.Default.FifthSetupExpertise = ExpertiseInput.Text;
                    Properties.Settings.Default.Save();
                    DoneEditing();
                }
            }
            else
            {
                MessageBox.Show("Error: Setup Name is matching another Setup Name that already exists.", "Error");
            }
        }

        private void DoneEditing()
        {
            SetupNameInput.ReadOnly = true;
            ProfessionInput.ReadOnly = true;
            ExpertiseInput.ReadOnly = true;
            EditButton.Visible = true;
            SaveButton.Visible = false;
            DiscardButton.Visible = false;
        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EditButtonEnabled = false;

            SetupNameInput.ReadOnly = true;
            ProfessionInput.ReadOnly = true;
            ExpertiseInput.ReadOnly = true;
            EditButton.Visible = true;
            SaveButton.Visible = false;
            DiscardButton.Visible = false;

            LoadSelectedSetup();
        }
    }
}
