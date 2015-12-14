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

        private void SaveWeaponInfoButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.GetCurrentSetupNumber == "1")
            {
                SaveFirstWeaponInfo();
            }
            Dispose();
        }

        private void WeaponInputInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
