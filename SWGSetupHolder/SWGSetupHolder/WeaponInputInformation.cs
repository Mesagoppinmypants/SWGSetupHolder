using System;
using System.Windows.Forms;

namespace SWGSetupHolder
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
            Properties.Settings.Default.Save();
        }

        private void SaveSecondWeaponInfo()
        {
            Properties.Settings.Default.SecondWeaponName = WeaponNameInput.Text;
            Properties.Settings.Default.SecondWeaponDPS = WeaponDPSInput.Text;
            Properties.Settings.Default.SecondWeaponElement = WeaponElementInput.Text;
            Properties.Settings.Default.SecondWeaponExotics = WeaponExoticsInput.Text;
            Properties.Settings.Default.Save();
        }

        private void SaveThirdWeaponInfo()
        {
            Properties.Settings.Default.ThirdWeaponName = WeaponNameInput.Text;
            Properties.Settings.Default.ThirdWeaponDPS = WeaponDPSInput.Text;
            Properties.Settings.Default.ThirdWeaponElement = WeaponElementInput.Text;
            Properties.Settings.Default.ThirdWeaponExotics = WeaponExoticsInput.Text;
            Properties.Settings.Default.Save();
        }

        private void SaveFourthWeaponInfo()
        {
            Properties.Settings.Default.FourthWeaponName = WeaponNameInput.Text;
            Properties.Settings.Default.FourthWeaponDPS = WeaponDPSInput.Text;
            Properties.Settings.Default.FourthWeaponElement = WeaponElementInput.Text;
            Properties.Settings.Default.FourthWeaponExotics = WeaponExoticsInput.Text;
            Properties.Settings.Default.Save();
        }

        private void SaveFifthWeaponInfo()
        {
            Properties.Settings.Default.FifthWeaponName = WeaponNameInput.Text;
            Properties.Settings.Default.FifthWeaponDPS = WeaponDPSInput.Text;
            Properties.Settings.Default.FifthWeaponElement = WeaponElementInput.Text;
            Properties.Settings.Default.FifthWeaponExotics = WeaponExoticsInput.Text;
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

        }
    }
}
