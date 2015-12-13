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
                WeaponNameInput.Text = Properties.Settings.Default.FirstWeaponName;
            }
        }
    }
}
