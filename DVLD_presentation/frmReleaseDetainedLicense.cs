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
    public partial class frmReleaseDetainedLicense : Form
    {
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        clsDetainedLicense detainedLicense;
        private void _CheckDetained()
        {
            lblLicenseID.Text = ctrlDriverLicenseInfoWithFilter1.licenseID.ToString();

            if (!clsDetainedLicense.isLicenseDetained(ctrlDriverLicenseInfoWithFilter1.licenseID))
            {
                MessageBox.Show("Selected license is not detained!","not detained",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            detainedLicense = clsDetainedLicense.FindByLicenseID_NotReleased(ctrlDriverLicenseInfoWithFilter1.licenseID);
            clsApplicationType releaseType = clsApplicationType.Find(5);
            btnRelease.Enabled = true;
            lblDetainID.Text=detainedLicense.DetainID.ToString();
            lblDetainDate.Text = detainedLicense.DetainDate.ToString("d");
            lblCreatedBy.Text=clsGlobalSettings._LogedInUser.UserName.ToString();
            lblAppFees.Text=releaseType.ApplicationFees.ToString();
            lblFineFees.Text=detainedLicense.FineFees.ToString();
            lblTotalFees.Text= (releaseType.ApplicationFees+ detainedLicense.FineFees).ToString();

        }
        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.handleET += _CheckDetained;
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
           
            if(MessageBox.Show("Are you sure you want to release this detained license","release",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                return;
            }

            if(detainedLicense.Release())
            MessageBox.Show("License released successfully!","release",MessageBoxButtons.OK,MessageBoxIcon.Information);

            lblLicenseInfo.Enabled = true;
            lblAppID.Text=detainedLicense.ReleaseApplicationID.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(clsDriver.Find(clsLicense.Find(detainedLicense.LicenseID).DriverID).PersonID);
            frm.ShowDialog();
        }

        private void lblLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(ctrlDriverLicenseInfoWithFilter1.licenseID,true);
            frm.ShowDialog();   
        }
    }
}
