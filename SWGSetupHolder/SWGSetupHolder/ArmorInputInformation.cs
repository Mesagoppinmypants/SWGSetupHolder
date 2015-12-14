using System;
using System.Windows.Forms;

namespace SWGSetupHolder
{
    public partial class ArmorInputInformation : Form
    {
        public ArmorInputInformation()
        {
            InitializeComponent();
        }

        private void SaveArmorInfoButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.GetCurrentSetupNumber == "1")
            {
                Properties.Settings.Default.FirstArmorName = ArmorNameInput.Text;
                Properties.Settings.Default.FirstArmorType = ArmorTypeInput.Text;
                Properties.Settings.Default.FirstArmorProtection = ArmorProtectionInput.Text;
                Properties.Settings.Default.FirstArmorExotics = ArmorExoticsInput.Text;
                Properties.Settings.Default.Save();
                Dispose();
            }

            if (Properties.Settings.Default.GetCurrentSetupNumber == "2")
            {
                Properties.Settings.Default.SecondArmorName = ArmorNameInput.Text;
                Properties.Settings.Default.SecondArmorType = ArmorTypeInput.Text;
                Properties.Settings.Default.SecondArmorProtection = ArmorProtectionInput.Text;
                Properties.Settings.Default.SecondArmorExotics = ArmorExoticsInput.Text;
                Properties.Settings.Default.Save();
                Dispose();
            }

            if (Properties.Settings.Default.GetCurrentSetupNumber == "3")
            {
                Properties.Settings.Default.ThirdArmorName = ArmorNameInput.Text;
                Properties.Settings.Default.ThirdArmorType = ArmorTypeInput.Text;
                Properties.Settings.Default.ThirdArmorProtection = ArmorProtectionInput.Text;
                Properties.Settings.Default.ThirdArmorExotics = ArmorExoticsInput.Text;
                Properties.Settings.Default.Save();
                Dispose();
            }

            if (Properties.Settings.Default.GetCurrentSetupNumber == "4")
            {
                Properties.Settings.Default.FourthArmorName = ArmorNameInput.Text;
                Properties.Settings.Default.FourthArmorType = ArmorTypeInput.Text;
                Properties.Settings.Default.FourthArmorProtection = ArmorProtectionInput.Text;
                Properties.Settings.Default.FourthArmorExotics = ArmorExoticsInput.Text;
                Properties.Settings.Default.Save();
                Dispose();
            }

            if (Properties.Settings.Default.GetCurrentSetupNumber == "5")
            {
                Properties.Settings.Default.FifthArmorName = ArmorNameInput.Text;
                Properties.Settings.Default.FifthArmorType = ArmorTypeInput.Text;
                Properties.Settings.Default.FifthArmorProtection = ArmorProtectionInput.Text;
                Properties.Settings.Default.FifthArmorExotics = ArmorExoticsInput.Text;
                Properties.Settings.Default.Save();
                Dispose();
            }
        }
    }
}
