using DVLD_businessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_presentation
{
    public partial class ctrlDriverLicenses : UserControl
    {
        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        public void FillControl(int DriverID)
        {
            dgvLocalLicenses.DataSource=clsLicense.GetLicenses(DriverID);
            dgvInternationalLicenses.DataSource = clsInternationalLicense.GetLicenses(DriverID);

           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcDriverLicenses.SelectedIndex == 0)
            {
                lblNumberOfRecodrs.Text = dgvLocalLicenses.RowCount.ToString();
            } else
            {
                lblNumberOfRecodrs.Text = dgvInternationalLicenses.RowCount.ToString();
            }

        }
    }
}
