using System;
using System.Windows.Forms;

namespace SWGSetupHolder
{
    public partial class ArmorOutputInformation : Form
    {
        public ArmorOutputInformation()
        {
            InitializeComponent();
        }

        private void ArmorOutputInformation_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CurrentSetupNumber == "1")
            {
                ArmorNameOutput.Text = Properties.Settings.Default.FirstArmorName;
                ArmorTypeOutput.Text = Properties.Settings.Default.FirstArmorType;
                ArmorProtectionOutput.Text = Properties.Settings.Default.FirstArmorProtection;
                ArmorExoticsOutput.Text = Properties.Settings.Default.FirstArmorExotics;
            }

            if (Properties.Settings.Default.CurrentSetupNumber == "2")
            {
                ArmorNameOutput.Text = Properties.Settings.Default.SecondArmorName;
                ArmorTypeOutput.Text = Properties.Settings.Default.SecondArmorType;
                ArmorProtectionOutput.Text = Properties.Settings.Default.SecondArmorProtection;
                ArmorExoticsOutput.Text = Properties.Settings.Default.SecondArmorExotics;
            }

            if (Properties.Settings.Default.CurrentSetupNumber == "3")
            {
                ArmorNameOutput.Text = Properties.Settings.Default.ThirdArmorName;
                ArmorTypeOutput.Text = Properties.Settings.Default.ThirdArmorType;
                ArmorProtectionOutput.Text = Properties.Settings.Default.ThirdArmorProtection;
                ArmorExoticsOutput.Text = Properties.Settings.Default.ThirdArmorExotics;
            }

            if (Properties.Settings.Default.CurrentSetupNumber == "4")
            {
                ArmorNameOutput.Text = Properties.Settings.Default.FourthArmorName;
                ArmorTypeOutput.Text = Properties.Settings.Default.FourthArmorType;
                ArmorProtectionOutput.Text = Properties.Settings.Default.FourthArmorProtection;
                ArmorExoticsOutput.Text = Properties.Settings.Default.FourthArmorExotics;
            }

            if (Properties.Settings.Default.CurrentSetupNumber == "5")
            {
                ArmorNameOutput.Text = Properties.Settings.Default.FifthArmorName;
                ArmorTypeOutput.Text = Properties.Settings.Default.FifthArmorType;
                ArmorProtectionOutput.Text = Properties.Settings.Default.FifthArmorProtection;
                ArmorExoticsOutput.Text = Properties.Settings.Default.FifthArmorExotics;
            }

            if (Properties.Settings.Default.EditButtonEnabled == true)
            {
                ArmorNameOutput.ReadOnly = false;
                ArmorTypeOutput.ReadOnly = false;
                ArmorProtectionOutput.ReadOnly = false;
                ArmorExoticsOutput.ReadOnly = false;
            }
        }

        private void ArmorOutputInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.EditButtonEnabled == true)
            {
                LoadedSetup ls = new LoadedSetup();
                if (ls.SetupNumberInput.Text == "1")
                {
                    Properties.Settings.Default.FirstArmorName = ArmorNameOutput.Text;
                    Properties.Settings.Default.FirstArmorType = ArmorTypeOutput.Text;
                    Properties.Settings.Default.FirstArmorProtection = ArmorProtectionOutput.Text;
                    Properties.Settings.Default.FirstArmorExotics = ArmorExoticsOutput.Text;
                    Properties.Settings.Default.Save();
                }

                if (ls.SetupNumberInput.Text == "2")
                {
                    Properties.Settings.Default.SecondArmorName = ArmorNameOutput.Text;
                    Properties.Settings.Default.SecondArmorType = ArmorTypeOutput.Text;
                    Properties.Settings.Default.SecondArmorProtection = ArmorProtectionOutput.Text;
                    Properties.Settings.Default.SecondArmorExotics = ArmorExoticsOutput.Text;
                    Properties.Settings.Default.Save();
                }

                if (ls.SetupNumberInput.Text == "3")
                {
                    Properties.Settings.Default.ThirdArmorName = ArmorNameOutput.Text;
                    Properties.Settings.Default.ThirdArmorType = ArmorTypeOutput.Text;
                    Properties.Settings.Default.ThirdArmorProtection = ArmorProtectionOutput.Text;
                    Properties.Settings.Default.ThirdArmorExotics = ArmorExoticsOutput.Text;
                    Properties.Settings.Default.Save();
                }

                if (ls.SetupNumberInput.Text == "4")
                {
                    Properties.Settings.Default.FourthArmorName = ArmorNameOutput.Text;
                    Properties.Settings.Default.FourthArmorType = ArmorTypeOutput.Text;
                    Properties.Settings.Default.FourthArmorProtection = ArmorProtectionOutput.Text;
                    Properties.Settings.Default.FourthArmorExotics = ArmorExoticsOutput.Text;
                    Properties.Settings.Default.Save();
                }

                if (ls.SetupNumberInput.Text == "5")
                {
                    Properties.Settings.Default.FifthArmorName = ArmorNameOutput.Text;
                    Properties.Settings.Default.FifthArmorType = ArmorTypeOutput.Text;
                    Properties.Settings.Default.FifthArmorProtection = ArmorProtectionOutput.Text;
                    Properties.Settings.Default.FifthArmorExotics = ArmorExoticsOutput.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }
    }
}
