using System;
using System.Windows.Forms;

namespace TrooperSetupOrganizer
{
    public partial class WeaponInputInformation : Form
    {
        public WeaponInputInformation()
        {
            InitializeComponent();
        }

        private void SaveFirstWeaponInfo()
        {
            Properties.Settings.Default.FirstWeaponName = WeaponNameInput.Text;
            Properties.Settings.Default.FirstWeaponDPS = WeaponDPSInput.Text;
            Properties.Settings.Default.FirstWeaponElement = WeaponElementInput.Text;
            Properties.Settings.Default.FirstWeaponExotics = WeaponExoticsInput.Text;
            Properties.Settings.Default.FirstWeaponElementDamage = WeaponElementDamageInput.Text;
            Properties.Settings.Default.Save();
        }

        private void SaveSecondWeaponInfo()
        {
            Properties.Settings.Default.SecondWeaponName = WeaponNameInput.Text;
            Properties.Settings.Default.SecondWeaponDPS = WeaponDPSInput.Text;
            Properties.Settings.Default.SecondWeaponElement = WeaponElementInput.Text;
            Properties.Settings.Default.SecondWeaponExotics = WeaponExoticsInput.Text;
            Properties.Settings.Default.SecondWeaponElementDamage = WeaponElementDamageInput.Text;
            Properties.Settings.Default.Save();
        }

        private void SaveThirdWeaponInfo()
        {
            Properties.Settings.Default.ThirdWeaponName = WeaponNameInput.Text;
            Properties.Settings.Default.ThirdWeaponDPS = WeaponDPSInput.Text;
            Properties.Settings.Default.ThirdWeaponElement = WeaponElementInput.Text;
            Properties.Settings.Default.ThirdWeaponExotics = WeaponExoticsInput.Text;
            Properties.Settings.Default.ThirdWeaponElementDamage = WeaponElementDamageInput.Text;
            Properties.Settings.Default.Save();
        }

        private void SaveFourthWeaponInfo()
        {
            Properties.Settings.Default.FourthWeaponName = WeaponNameInput.Text;
            Properties.Settings.Default.FourthWeaponDPS = WeaponDPSInput.Text;
            Properties.Settings.Default.FourthWeaponElement = WeaponElementInput.Text;
            Properties.Settings.Default.FourthWeaponExotics = WeaponExoticsInput.Text;
            Properties.Settings.Default.FourthWeaponElementDamage = WeaponElementDamageInput.Text;
            Properties.Settings.Default.Save();
        }

        private void SaveFifthWeaponInfo()
        {
            Properties.Settings.Default.FifthWeaponName = WeaponNameInput.Text;
            Properties.Settings.Default.FifthWeaponDPS = WeaponDPSInput.Text;
            Properties.Settings.Default.FifthWeaponElement = WeaponElementInput.Text;
            Properties.Settings.Default.FifthWeaponExotics = WeaponExoticsInput.Text;
            Properties.Settings.Default.FifthWeaponElementDamage = WeaponElementDamageInput.Text;
            Properties.Settings.Default.Save();
        }

        private void SaveWeaponInfoButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.GetCurrentSetupNumber == "1")
            {
                SaveFirstWeaponInfo();
            }

            if (Properties.Settings.Default.GetCurrentSetupNumber == "2")
            {
                SaveSecondWeaponInfo();
            }

            if (Properties.Settings.Default.GetCurrentSetupNumber == "3")
            {
                SaveThirdWeaponInfo();
            }

            if (Properties.Settings.Default.GetCurrentSetupNumber == "4")
            {
                SaveFourthWeaponInfo();
            }

            if (Properties.Settings.Default.GetCurrentSetupNumber == "5")
            {
                SaveFifthWeaponInfo();
            }
            Dispose();
        }

        private void WeaponInputInformation_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.GetCurrentSetupNumber == "1")
            {
                WeaponNameInput.Text = Properties.Settings.Default.FirstWeaponName;
                WeaponDPSInput.Text = Properties.Settings.Default.FirstWeaponDPS;
                WeaponElementInput.Text = Properties.Settings.Default.FirstWeaponElement;
                WeaponExoticsInput.Text = Properties.Settings.Default.FirstWeaponExotics;
                WeaponElementDamageInput.Text = Properties.Settings.Default.FirstWeaponElementDamage;
            }

            if (Properties.Settings.Default.GetCurrentSetupNumber == "2")
            {
                WeaponNameInput.Text = Properties.Settings.Default.SecondWeaponName;
                WeaponDPSInput.Text = Properties.Settings.Default.SecondWeaponDPS;
                WeaponElementInput.Text = Properties.Settings.Default.SecondWeaponElement;
                WeaponExoticsInput.Text = Properties.Settings.Default.SecondWeaponExotics;
                WeaponElementDamageInput.Text = Properties.Settings.Default.SecondWeaponElementDamage;
            }

            if (Properties.Settings.Default.GetCurrentSetupNumber == "3")
            {
                WeaponNameInput.Text = Properties.Settings.Default.ThirdWeaponName;
                WeaponDPSInput.Text = Properties.Settings.Default.ThirdWeaponDPS;
                WeaponElementInput.Text = Properties.Settings.Default.ThirdWeaponElement;
                WeaponExoticsInput.Text = Properties.Settings.Default.ThirdWeaponExotics;
                WeaponElementDamageInput.Text = Properties.Settings.Default.ThirdWeaponElementDamage;
            }

            if (Properties.Settings.Default.GetCurrentSetupNumber == "4")
            {
                WeaponNameInput.Text = Properties.Settings.Default.FourthWeaponName;
                WeaponDPSInput.Text = Properties.Settings.Default.FourthWeaponDPS;
                WeaponElementInput.Text = Properties.Settings.Default.FourthWeaponElement;
                WeaponExoticsInput.Text = Properties.Settings.Default.FourthWeaponExotics;
                WeaponElementDamageInput.Text = Properties.Settings.Default.FourthWeaponElementDamage;
            }

            if (Properties.Settings.Default.GetCurrentSetupNumber == "5")
            {
                WeaponNameInput.Text = Properties.Settings.Default.FifthWeaponName;
                WeaponDPSInput.Text = Properties.Settings.Default.FifthWeaponDPS;
                WeaponElementInput.Text = Properties.Settings.Default.FifthWeaponElement;
                WeaponExoticsInput.Text = Properties.Settings.Default.FifthWeaponExotics;
                WeaponElementDamageInput.Text = Properties.Settings.Default.FifthWeaponElementDamage;
            }
        }
    }
}
