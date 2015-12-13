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

        private void SaveWeaponInfoButton_Click(object sender, EventArgs e)
        {
            NewSetupPage nsp = new NewSetupPage();
            if (nsp.SetupNumberInput.Text == "1")
            {
                
            }
            Dispose();
        }

        private void WeaponInputInformation_Load(object sender, EventArgs e)
        {
            NewSetupPage nsp = new NewSetupPage();
            if (nsp.SetupNumberInput.Text == "1")
            {

            }
        }
    }
}
