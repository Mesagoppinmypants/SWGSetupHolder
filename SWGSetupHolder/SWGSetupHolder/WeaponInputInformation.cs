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
            WeaponNameInput.Text = Properties.Settings.Default.FirstWeaponName;
            WeaponDPSInput.Text = Properties.Settings.Default.FirstWeaponDPS;
            WeaponElementInput.Text = Properties.Settings.Default.FirstWeaponElement;
            WeaponExoticsInput.Text = Properties.Settings.Default.FirstWeaponExotics;
        }

        private void SaveWeaponInfoButton_Click(object sender, EventArgs e)
        {
            NewSetupPage nsp = new NewSetupPage();
            if (nsp.SetupNumberInput.Text == "1")
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
