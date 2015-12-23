using System;
using System.Windows.Forms;

namespace TrooperSetupOrganizer
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

            if (Properties.Settings.Default.EditButtonEnabled == true)
            {
                WeaponNameOutput.ReadOnly = false;
                WeaponDPSOutput.ReadOnly = false;
                WeaponElementOutput.ReadOnly = false;
                WeaponExoticsOutput.ReadOnly = false;
                WeaponElementDamageOutput.ReadOnly = false;
            }
        }

        private void WeaponOutputInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.EditButtonEnabled == true)
            {
                LoadedSetup ls = new LoadedSetup();
                if (ls.SetupNumberInput.Text == "1")
                {
                    Properties.Settings.Default.FirstWeaponName = WeaponNameOutput.Text;
                    Properties.Settings.Default.FirstWeaponDPS = WeaponDPSOutput.Text;
                    Properties.Settings.Default.FirstWeaponElement = WeaponElementOutput.Text;
                    Properties.Settings.Default.FirstWeaponExotics = WeaponExoticsOutput.Text;
                    Properties.Settings.Default.FirstWeaponElementDamage = WeaponElementDamageOutput.Text;
                    Properties.Settings.Default.Save();
                }

                if (ls.SetupNumberInput.Text == "2")
                {
                    Properties.Settings.Default.SecondWeaponName = WeaponNameOutput.Text;
                    Properties.Settings.Default.SecondWeaponDPS = WeaponDPSOutput.Text;
                    Properties.Settings.Default.SecondWeaponElement = WeaponElementOutput.Text;
                    Properties.Settings.Default.SecondWeaponExotics = WeaponExoticsOutput.Text;
                    Properties.Settings.Default.SecondWeaponElementDamage = WeaponElementDamageOutput.Text;
                    Properties.Settings.Default.Save();
                }

                if (ls.SetupNumberInput.Text == "3")
                {
                    Properties.Settings.Default.ThirdWeaponName = WeaponNameOutput.Text;
                    Properties.Settings.Default.ThirdWeaponDPS = WeaponDPSOutput.Text;
                    Properties.Settings.Default.ThirdWeaponElement = WeaponElementOutput.Text;
                    Properties.Settings.Default.ThirdWeaponExotics = WeaponExoticsOutput.Text;
                    Properties.Settings.Default.ThirdWeaponElementDamage = WeaponElementDamageOutput.Text;
                    Properties.Settings.Default.Save();
                }

                if (ls.SetupNumberInput.Text == "4")
                {
                    Properties.Settings.Default.FourthWeaponName = WeaponNameOutput.Text;
                    Properties.Settings.Default.FourthWeaponDPS = WeaponDPSOutput.Text;
                    Properties.Settings.Default.FourthWeaponElement = WeaponElementOutput.Text;
                    Properties.Settings.Default.FourthWeaponExotics = WeaponExoticsOutput.Text;
                    Properties.Settings.Default.FourthWeaponElementDamage = WeaponElementDamageOutput.Text;
                    Properties.Settings.Default.Save();
                }

                if (ls.SetupNumberInput.Text == "5")
                {
                    Properties.Settings.Default.FifthWeaponName = WeaponNameOutput.Text;
                    Properties.Settings.Default.FifthWeaponDPS = WeaponDPSOutput.Text;
                    Properties.Settings.Default.FifthWeaponElement = WeaponElementOutput.Text;
                    Properties.Settings.Default.FifthWeaponExotics = WeaponExoticsOutput.Text;
                    Properties.Settings.Default.FifthWeaponElementDamage = WeaponElementDamageOutput.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }
    }
}
