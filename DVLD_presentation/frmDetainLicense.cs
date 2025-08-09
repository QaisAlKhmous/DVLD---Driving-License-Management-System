using DVLD_businessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_presentation
{
    public partial class frmDetainLicense : Form
    {
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        clsLicense license;

        private void _LoadBasics()
        {
            lblDetainDate.Text = DateTime.Now.ToString("d");
            lblCreatedBy.Text = clsGlobalSettings._LogedInUser.UserName;
        }

        private void _CheckDetained()
        {

            lblLicenseID.Text = ctrlDriverLicenseInfoWithFilter1.licenseID.ToString();
            if (clsDetainedLicense.isLicenseDetained(ctrlDriverLicenseInfoWithFilter1.licenseID))
            {
                MessageBox.Show("License is already detaind","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            btnDetain.Enabled = true;
            
        }
        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            _LoadBasics();

            ctrlDriverLicenseInfoWithFilter1.handleET += _CheckDetained;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are you sure you want to detain this licens?","Detain",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.No)
            {
                return;
            }
             license = clsLicense.Find(ctrlDriverLicenseInfoWithFilter1.licenseID);
            int Fees = (int.Parse(txtFees.Text.ToString()));
            clsDetainedLicense DetaindLicense = license.Detain(Fees);
            if (DetaindLicense != null)
            {
                MessageBox.Show("License Detained Successfully", "Detain", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            lblLicenseInfo.Enabled = true;
            btnDetain.Enabled=false;
            lblDetainID.Text=DetaindLicense.DetainID.ToString();


        }

        private void lblLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsLicense license = clsLicense.Find(ctrlDriverLicenseInfoWithFilter1.licenseID);
            clsDriver driver=clsDriver.Find(license.DriverID);
            frmLicenseHistory frm = new frmLicenseHistory(driver.PersonID);
            frm.ShowDialog();
        }

        private void lblLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm=new frmDriverLicenseInfo(ctrlDriverLicenseInfoWithFilter1.licenseID,true);
            frm.ShowDialog();
        }
    }
}
