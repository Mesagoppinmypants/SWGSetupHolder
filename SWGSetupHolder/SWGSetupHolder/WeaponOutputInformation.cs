using System;
using System.Windows.Forms;

namespace SWGSetupHolder
{
    public partial class WeaponOutputInformation : Form
    {
        public WeaponOutputInformation()
        {
            InitializeComponent();
        }

        private void WeaponOutputInformation_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CurrentSetupNumber == "1")
            {
                WeaponNameOutput.Text = Properties.Settings.Default.FirstWeaponName;
                WeaponDPSOutput.Text = Properties.Settings.Default.FirstWeaponDPS;
                WeaponElementOutput.Text = Properties.Settings.Default.FirstWeaponElement;
                WeaponExoticsOutput.Text = Properties.Settings.Default.FirstWeaponExotics;
                WeaponElementDamageOutput.Text = Properties.Settings.Default.FirstWeaponElementDamage;
            }

            if (Properties.Settings.Default.CurrentSetupNumber == "2")
            {
                WeaponNameOutput.Text = Properties.Settings.Default.SecondWeaponName;
                WeaponDPSOutput.Text = Properties.Settings.Default.SecondWeaponDPS;
                WeaponElementOutput.Text = Properties.Settings.Default.SecondWeaponElement;
                WeaponExoticsOutput.Text = Properties.Settings.Default.SecondWeaponExotics;
                WeaponElementDamageOutput.Text = Properties.Settings.Default.SecondWeaponElementDamage;
            }

            if (Properties.Settings.Default.CurrentSetupNumber == "3")
            {
                WeaponNameOutput.Text = Properties.Settings.Default.ThirdWeaponName;
                WeaponDPSOutput.Text = Properties.Settings.Default.ThirdWeaponDPS;
                WeaponElementOutput.Text = Properties.Settings.Default.ThirdWeaponElement;
                WeaponExoticsOutput.Text = Properties.Settings.Default.ThirdWeaponExotics;
                WeaponElementDamageOutput.Text = Properties.Settings.Default.ThirdWeaponElementDamage;
            }

            if (Properties.Settings.Default.CurrentSetupNumber == "4")
            {
                WeaponNameOutput.Text = Properties.Settings.Default.FourthWeaponName;
                WeaponDPSOutput.Text = Properties.Settings.Default.FourthWeaponDPS;
                WeaponElementOutput.Text = Properties.Settings.Default.FourthWeaponElement;
                WeaponExoticsOutput.Text = Properties.Settings.Default.FourthWeaponExotics;
                WeaponElementDamageOutput.Text = Properties.Settings.Default.FourthWeaponElementDamage;
            }

            if (Properties.Settings.Default.CurrentSetupNumber == "5")
            {
                WeaponNameOutput.Text = Properties.Settings.Default.FifthWeaponName;
                WeaponDPSOutput.Text = Properties.Settings.Default.FifthWeaponDPS;
                WeaponElementOutput.Text = Properties.Settings.Default.FifthWeaponElement;
                WeaponExoticsOutput.Text = Properties.Settings.Default.FifthWeaponExotics;
                WeaponElementDamageOutput.Text = Properties.Settings.Default.FifthWeaponElementDamage;
            }
        }
    }
}
