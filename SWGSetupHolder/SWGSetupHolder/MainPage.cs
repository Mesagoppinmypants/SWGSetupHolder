using System;
using System.Windows.Forms;

namespace TrooperSetupOrganizer
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MakeNewSetupButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstSetupName != "" && Properties.Settings.Default.SecondSetupName != "" && Properties.Settings.Default.ThirdSetupName != "" && Properties.Settings.Default.FourthSetupName != "" && Properties.Settings.Default.FifthSetupName != "")
            {
                MessageBox.Show("You have already reached your max limit of setups to save, please delete one to be able to make another one.", "Error");
            }
            else
            {
                NewSetupPage nsp = new NewSetupPage();
                nsp.ShowDialog();
            }
        }

        private void ViewSavedSetupsButton_Click(object sender, EventArgs e)
        {
            SavedSetupsPage ssp = new SavedSetupsPage();
            ssp.ShowDialog();
        }

        private void DeleteAllSetupsButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete all saved setups?", "Warning", MessageBoxButtons.YesNo);
            
            if (dr == DialogResult.Yes)
            {
                // Delete All Name Data
                Properties.Settings.Default.FirstSetupName = "";
                Properties.Settings.Default.SecondSetupName = "";
                Properties.Settings.Default.ThirdSetupName = "";
                Properties.Settings.Default.FourthSetupName = "";
                Properties.Settings.Default.FifthSetupName = "";

                // Delete All Profession Data
                Properties.Settings.Default.FirstSetupProfession = "";
                Properties.Settings.Default.SecondSetupProfession = "";
                Properties.Settings.Default.ThirdSetupProfession = "";
                Properties.Settings.Default.FourthSetupProfession = "";
                Properties.Settings.Default.FifthSetupProfession = "";

                // Delete All Expertise Data
                Properties.Settings.Default.FirstSetupExpertise = "";
                Properties.Settings.Default.SecondSetupExpertise = "";
                Properties.Settings.Default.ThirdSetupExpertise = "";
                Properties.Settings.Default.FourthSetupExpertise = "";
                Properties.Settings.Default.FifthSetupExpertise = "";

                // Delete All Weapon Data
                Properties.Settings.Default.FirstWeaponName = "";
                Properties.Settings.Default.SecondWeaponName = "";
                Properties.Settings.Default.ThirdWeaponName = "";
                Properties.Settings.Default.FourthWeaponName = "";
                Properties.Settings.Default.FifthWeaponName = "";

                Properties.Settings.Default.FirstWeaponDPS = "";
                Properties.Settings.Default.SecondWeaponDPS = "";
                Properties.Settings.Default.ThirdWeaponDPS = "";
                Properties.Settings.Default.FourthWeaponDPS = "";
                Properties.Settings.Default.FifthWeaponDPS = "";

                Properties.Settings.Default.FirstWeaponElement = "";
                Properties.Settings.Default.SecondWeaponElement = "";
                Properties.Settings.Default.ThirdWeaponElement = "";
                Properties.Settings.Default.FourthWeaponElement = "";
                Properties.Settings.Default.FifthWeaponElement = "";

                Properties.Settings.Default.FirstWeaponExotics = "";
                Properties.Settings.Default.SecondWeaponExotics = "";
                Properties.Settings.Default.ThirdWeaponExotics = "";
                Properties.Settings.Default.FourthWeaponExotics = "";
                Properties.Settings.Default.FifthWeaponExotics = "";

                Properties.Settings.Default.FirstWeaponElementDamage = "";
                Properties.Settings.Default.SecondWeaponElementDamage = "";
                Properties.Settings.Default.ThirdWeaponElementDamage = "";
                Properties.Settings.Default.FourthWeaponElementDamage = "";
                Properties.Settings.Default.FifthWeaponElementDamage = "";

                // Delete All Armor Data
                Properties.Settings.Default.FirstArmorName = "";
                Properties.Settings.Default.SecondArmorName = "";
                Properties.Settings.Default.ThirdArmorName = "";
                Properties.Settings.Default.FourthArmorName = "";
                Properties.Settings.Default.FifthArmorName = "";

                Properties.Settings.Default.FirstArmorProtection = "";
                Properties.Settings.Default.SecondArmorProtection = "";
                Properties.Settings.Default.ThirdArmorProtection = "";
                Properties.Settings.Default.FourthArmorProtection = "";
                Properties.Settings.Default.FifthArmorProtection = "";

                Properties.Settings.Default.FirstArmorType = "";
                Properties.Settings.Default.SecondArmorType = "";
                Properties.Settings.Default.ThirdArmorType = "";
                Properties.Settings.Default.FourthArmorType = "";
                Properties.Settings.Default.FifthArmorType = "";

                Properties.Settings.Default.FirstArmorExotics = "";
                Properties.Settings.Default.SecondArmorExotics = "";
                Properties.Settings.Default.ThirdArmorExotics = "";
                Properties.Settings.Default.FourthArmorExotics = "";
                Properties.Settings.Default.FifthArmorExotics = "";

                MessageBox.Show("All data has been successfully deleted.");
            }
        }
    }
}
