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
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        public void FillControl(int LDLAppID)
        {

            clsLocalDrivingLicenseApplication ldlApp=clsLocalDrivingLicenseApplication.Find(LDLAppID);  
            clsLicenseClass lclass=clsLicenseClass.Find(ldlApp.LicenseClassID);
            clsLicense license=clsLicense.FindByApplicationID(ldlApp.ApplicationID);
            clsApplication app = clsApplication.Find(ldlApp.ApplicationID);
            clsPerson person = clsPerson.FindByID(app.ApplicationPersonID);
            clsDriver driver=clsDriver.FindByPersonID(person.PersonID);

            lblClass.Text=lclass.ClassName;
            lblName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
            lblLicenseID.Text=license.LicenseID.ToString();
            lblNationalID.Text=person.NationalNo;
            lblGender.Text=person.Gender.ToString();
            lblIssueDate.Text = license.IssueDate.ToString("yyyy-MM-dd");
            lblIssueReason.Text=license.IssueReason.ToString();
            lblNotes.Text=license.Notes.ToString();
            lblIsActive.Text = license.IsActive ? "Yes" : "NO";
            lblDateOfBirth.Text=person.DateOfBirth.ToString("yyyy-MM-dd");
            lblDriverID.Text=driver.DriverID.ToString();
            lblExdate.Text = license.ExpirationDate.ToString("yyyy-MM-dd");
            if (clsDetainedLicense.isLicenseDetained(license.LicenseID))
                lblIsDetained.Text = "Yes";
            else lblIsDetained.Text = "No";
            pbImage.ImageLocation = person.ImagePath;




        }


        public void FillControlByLicenseID(int LicenseID)
        {

           
            
            clsLicense license = clsLicense.Find(LicenseID);
            clsLicenseClass lclass = clsLicenseClass.Find(license.LicenseClass);
            clsApplication app = clsApplication.Find(license.ApplicationID);
            clsPerson person = clsPerson.FindByID(app.ApplicationPersonID);
            clsDriver driver = clsDriver.FindByPersonID(person.PersonID);

            lblClass.Text = lclass.ClassName;
            lblName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
            lblLicenseID.Text = license.LicenseID.ToString();
            lblNationalID.Text = person.NationalNo;
            lblGender.Text = person.Gender.ToString();
            lblIssueDate.Text = license.IssueDate.ToString("yyyy-MM-dd");
            lblIssueReason.Text = license.IssueReason.ToString();
            lblNotes.Text = license.Notes.ToString();
            lblIsActive.Text = license.IsActive ? "Yes" : "NO";
            lblDateOfBirth.Text = person.DateOfBirth.ToString("yyyy-MM-dd");
            lblDriverID.Text = driver.DriverID.ToString();
            lblExdate.Text = license.ExpirationDate.ToString("yyyy-MM-dd");

            if (clsDetainedLicense.isLicenseDetained(LicenseID))
                lblIsDetained.Text = "Yes";
            else lblIsDetained.Text = "No";

                pbImage.ImageLocation = person.ImagePath;




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
