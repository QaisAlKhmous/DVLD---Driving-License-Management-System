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
    public partial class ctrlDriverInternationalLicenseinfo : UserControl
    {
        public ctrlDriverInternationalLicenseinfo()
        {
            InitializeComponent();
        }

        public void FillControl(int InterLicenseID)
        {
            clsInternationalLicense interLicense = clsInternationalLicense.FindByLicenseID(InterLicenseID);
            clsApplication app = clsApplication.Find(interLicense.ApplicationID);
            clsPerson person = clsPerson.FindByID(app.ApplicationPersonID);

            lblName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
            lblLicenseID.Text = interLicense.LicenseID.ToString();
            lblNationalNumber.Text = person.NationalNo.ToString();
            if (person.Gender == 0)
            {
                lblGender.Text = "Male";
            }
            else lblGender.Text = "Female";

            lblIssueDate.Text=interLicense.IssueDate.ToString("d");    
            lblAppID.Text=app.ApplicationID.ToString();
            if (interLicense.IsActive)
            {
                lblIsActive.Text = "Yes";
            }
            else lblIsActive.Text = "No";


            lblDateOfBirth.Text=person.DateOfBirth.ToString("d");
            lblDriverID.Text=interLicense.DriverID.ToString();  
            lblExpirationDate.Text=interLicense.ExpirationDate.ToString();  
            pbImage.ImageLocation=person.ImagePath;

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
