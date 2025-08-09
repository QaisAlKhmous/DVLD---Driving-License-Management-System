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
    public partial class frmReplacmentForDamaged : Form
    {
        public frmReplacmentForDamaged()
        {
            InitializeComponent();
        }
        clsLicense oldLicense;
        clsApplicationType AppType;
        clsLicense newLicesne;
        private void CheckIfActive()
        {
             oldLicense=clsLicense.Find(ctrlDriverLicenseInfoWithFilter1.licenseID);

            if(!oldLicense.IsActive)
            {
                MessageBox.Show("Selected License is not active, choose an active license","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            lblOldLicenseId.Text=oldLicense.LicenseID.ToString();
            btnRenew.Enabled = true;

        }
        private void _FillBasics()
        {
            lblAppDate.Text = DateTime.Now.ToString("d");
            lblCreatedBy.Text = clsGlobalSettings._LogedInUser.UserName;
            rbDamaged.Checked=true;
        }
        private void frmReplacmentForDamaged_Load(object sender, EventArgs e)
        {
            _FillBasics();
            ctrlDriverLicenseInfoWithFilter1.handleET += CheckIfActive;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rbDamaged.Checked)
            {
                 AppType = clsApplicationType.Find(4);
            } else
            {
                 AppType = clsApplicationType.Find(3);
            }

            lblAppFees.Text=AppType.ApplicationFees.ToString(); 

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {

          if(  MessageBox.Show("Are you sure you want to replace license","replace",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.No)
            {
                return;
            }
            newLicesne = oldLicense.ReplaceLicense(AppType.ApplicationTypeID, "");
            if (newLicesne == null)
            {
                MessageBox.Show("an error has occured, try again later!","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }    
            lblNewLicenseID.Text=newLicesne.LicenseID.ToString();
            lblAppID.Text=newLicesne.ApplicationID.ToString();
            lblLicenseInfo.Enabled=true;

            oldLicense.IsActive = false;
            oldLicense.Save();


            MessageBox.Show("new license has been created successfully", "replace", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsDriver driver=clsDriver.Find(oldLicense.DriverID);
            frmLicenseHistory frm=new frmLicenseHistory(driver.PersonID);
            frm.ShowDialog();
        }

        private void lblLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(newLicesne.LicenseID, true);
            frm.ShowDialog();
        }
    }
}
