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
        }
    }
}
