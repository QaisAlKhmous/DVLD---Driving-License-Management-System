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
    public partial class frmRenewLicenseApplication : Form
    {
        public frmRenewLicenseApplication()
        {
            InitializeComponent();
        }
        clsApplicationType RenewType;
        clsLicense license;
        clsLicenseClass ordinaryLicense;
        clsLocalDrivingLicenseApplication localLicensApp;
        private void _LoadBasicinfo()
        {
            lblAppDate.Text = DateTime.Now.ToString("d");
            lblIssueDate.Text = DateTime.Now.ToString("d");
            lblCreatedBy.Text = clsGlobalSettings._LogedInUser.UserName;
             RenewType = clsApplicationType.Find(2);
            lblAppFees.Text=RenewType.ApplicationFees.ToString();

        }

        private void _CheckExpirationDate()
        {
            int LicensID=ctrlDriverLicenseInfoWithFilter1.licenseID;

             license=clsLicense.Find(LicensID);
            if (license.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show($"Selected Licenses is not yet expired, it will expire on {license.ExpirationDate.ToString("d")}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            btnRenew.Enabled = true;
            lblOldLicenseID.Text = license.LicenseID.ToString();
             ordinaryLicense=clsLicenseClass.Find(3);

            lblLicenseFees.Text=ordinaryLicense.ClassFees.ToString();  
            lblTotalFees.Text= (RenewType.ApplicationFees+ordinaryLicense.ClassFees).ToString();
            lblExpDate.Text=DateTime.Now.AddYears(ordinaryLicense.DefaultValidityLength).ToString();


        }

        private void frmRenewLicenseApplication_Load(object sender, EventArgs e)
        {
            _LoadBasicinfo();
            ctrlDriverLicenseInfoWithFilter1.handleET += _CheckExpirationDate;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            clsApplication renewLicenseApp=new clsApplication();

            clsDriver driver=clsDriver.Find(license.DriverID);

            renewLicenseApp.ApplicationPersonID=driver.PersonID;
            renewLicenseApp.ApplicationDate=DateTime.Now;   
            renewLicenseApp.LastStatusDate=DateTime.Now;
            renewLicenseApp.ApplicationTypeID = 2;
            renewLicenseApp.ApplicationStatus = 1;
            renewLicenseApp.PaidFees=RenewType.ApplicationFees;
            renewLicenseApp.CreatedByUserID=clsGlobalSettings._LogedInUser.UserID;

            renewLicenseApp.Save();

             localLicensApp=new clsLocalDrivingLicenseApplication();
            localLicensApp.ApplicationID=renewLicenseApp.ApplicationID;
            localLicensApp.LicenseClassID=ordinaryLicense.LicenseClassID;

            localLicensApp.Save();

            clsLicense newLicense=new clsLicense();
            newLicense.ApplicationID=renewLicenseApp.ApplicationID;
            newLicense.DriverID=driver.DriverID;
            newLicense.LicenseClass=license.LicenseClass;
            newLicense.IssueDate=DateTime.Now;
            newLicense.ExpirationDate=DateTime.Now.AddYears(ordinaryLicense.DefaultValidityLength);
            if (txtNotes.Text.Length > 0)
            {
                newLicense.Notes = txtNotes.Text;
            }

            newLicense.PaidFees=ordinaryLicense.ClassFees;
            newLicense.IsActive=true;
            newLicense.IssueReason = 2;
            newLicense.CreatedByUserID=clsGlobalSettings._LogedInUser.UserID;

            if(newLicense.Save() )
            {
                MessageBox.Show($"License Renewed Successfully With Lisence ID=[{newLicense.LicenseID}]", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else MessageBox.Show("Something Went Wrong!","error",MessageBoxButtons.OK, MessageBoxIcon.Error);  

            license.IsActive=false;

            license.Save();

            lblLicenseInfo.Enabled=true;


        }

        private void lblLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsDriver driver = clsDriver.Find(license.DriverID);
            frmLicenseHistory frm = new frmLicenseHistory(driver.PersonID);
            frm.ShowDialog();
        }

        private void lblLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(localLicensApp.LocalDrivingLicenseApplicationID,false);
            frm.ShowDialog();
        }
    }
}
