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
    public partial class frmInternationalLicenseApplication : Form
    {
        public frmInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private clsLicense license;
        clsInternationalLicense internationalLicense;
        clsApplication internationalLicenseapp;
        private void _BasicInfoLoad()
        {
            clsApplicationType InternationalApp = clsApplicationType.Find(6); // 6 is the id of the international license application
            lblAppDate.Text = DateTime.Now.ToString("d");
            lblIssueDate.Text = DateTime.Now.ToString("d");
            lblExpDate.Text = DateTime.Now.ToString("d");

            lblFees.Text=InternationalApp.ApplicationFees.ToString();

            lblCreatedByUser.Text=clsGlobalSettings._LogedInUser.UserName;
        }

        private void validatingandenabling()
        {

            int LicenseID=ctrlDriverLicenseInfoWithFilter1.licenseID;

             license= clsLicense.Find(LicenseID);

            if(clsInternationalLicense.IsActiveLicenseExists(license.DriverID))
            {
                internationalLicense = clsInternationalLicense.FindActiveByDriverID(license.DriverID);
                MessageBox.Show($"Person Already have an active international license with id= [{internationalLicense.LicenseID}]","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                lblShowLicenseInfo.Enabled = true;
                return;
            }

            if(!license.IsActive)
            {
                MessageBox.Show($"this person's local license is not active", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(DateTime.Now>license.ExpirationDate)
            {
                MessageBox.Show($"this person's local license is Expired", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnIssue.Enabled = true;
            lblLocalLicenseID.Text=license.LicenseID.ToString();


        }

        private void frmInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            _BasicInfoLoad();

            ctrlDriverLicenseInfoWithFilter1.handleET += validatingandenabling;
        }
        
        private void createNewApplicationAndLicense()
        {

             internationalLicenseapp = new clsApplication();
            clsApplication localLicenseApp = clsApplication.Find(license.ApplicationID);

            internationalLicenseapp.ApplicationPersonID = localLicenseApp.ApplicationPersonID;
            internationalLicenseapp.ApplicationDate = DateTime.Now;
            internationalLicenseapp.LastStatusDate = DateTime.Now;
            internationalLicenseapp.ApplicationTypeID = 6;
            internationalLicenseapp.ApplicationStatus = 1;
            internationalLicenseapp.PaidFees = decimal.Parse(lblFees.Text.ToString());
            internationalLicenseapp.CreatedByUserID = clsGlobalSettings._LogedInUser.UserID;

            if (!internationalLicenseapp.Save())
            {
                MessageBox.Show($"application failed to save", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


             internationalLicense = new clsInternationalLicense();

            internationalLicense.ApplicationID = internationalLicenseapp.ApplicationID;
            internationalLicense.DriverID = license.DriverID;
            internationalLicense.IssuedUsingLocalLicenseID = license.LicenseID;
            internationalLicense.IssueDate = DateTime.Now;
            internationalLicense.ExpirationDate = DateTime.Now;
            internationalLicense.IsActive = true;
            internationalLicense.CreatedByUserID = clsGlobalSettings._LogedInUser.UserID;


            if (internationalLicense.Save())
            {
                MessageBox.Show($"Internatioal license was issued successfully with id=[{internationalLicense.LicenseID}]", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Internatioal license failed to save", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            lblInterLicenseID.Text=internationalLicense.LicenseID.ToString();
            lblAppID.Text=internationalLicenseapp.ApplicationID.ToString(); 
            lblShowLicenseInfo.Enabled = true;



        }

       

        private void btnIssue_Click(object sender, EventArgs e)
        {

            createNewApplicationAndLicense();



        }

        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseInfo frm=new frmShowInternationalLicenseInfo(internationalLicense.LicenseID);
            frm.ShowDialog();
        }

        private void lblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            clsDriver driver=clsDriver.Find(license.DriverID);

       
            frmLicenseHistory frm=new frmLicenseHistory(driver.PersonID);
            frm.ShowDialog();
        }
    }
}
