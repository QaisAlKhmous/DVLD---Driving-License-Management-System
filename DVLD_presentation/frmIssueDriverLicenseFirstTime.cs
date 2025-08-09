using DVLD_businessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_presentation
{
    public partial class frmIssueDriverLicenseFirstTime : Form
    {

        private int _LDLAppID;
        private int _NumOfPassedTests;
        public frmIssueDriverLicenseFirstTime(int LDLAppID,int NumOfPassedTests)
        {
            InitializeComponent();

            _LDLAppID = LDLAppID;
            _NumOfPassedTests = NumOfPassedTests;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseAppInfo1.FillControl(_LDLAppID, _NumOfPassedTests);  
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication ldlApp=clsLocalDrivingLicenseApplication.Find(_LDLAppID);
            clsApplication app=clsApplication.Find(ldlApp.ApplicationID);
            clsDriver Driver = clsDriver.Find(app.ApplicationPersonID);
            clsLicenseClass licenseClass=clsLicenseClass.Find(ldlApp.LicenseClassID);   
           if (Driver == null)
            {
                Driver=new clsDriver();
                Driver.PersonID=app.ApplicationPersonID;
                Driver.CreatedDate=DateTime.Now;
                Driver.CreatedByUserID=clsGlobalSettings._LogedInUser.UserID;

                Driver.Save();
            }
         
                clsLicense NewLicense = new clsLicense();

            NewLicense.ApplicationID=ldlApp.ApplicationID;
            NewLicense.DriverID=Driver.DriverID;
            NewLicense.LicenseClass=ldlApp.LicenseClassID;
            NewLicense.IssueDate=DateTime.Now;
            NewLicense.ExpirationDate = NewLicense.IssueDate.AddYears(licenseClass.DefaultValidityLength);
            NewLicense.Notes=txtNotes.Text;
            NewLicense.PaidFees=licenseClass.ClassFees;
            NewLicense.IsActive=true;
            NewLicense.IssueReason = 1;
            NewLicense.CreatedByUserID = clsGlobalSettings._LogedInUser.UserID;

            if (NewLicense.Save())
            {
                MessageBox.Show($"License Issued Successfully, LicemseID=[{NewLicense.LicenseID}]", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                app.ApplicationStatus = 3;
                app.Save();
            }else
            {
                MessageBox.Show("License Issue Failed","error",MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }


        }
    }
}
