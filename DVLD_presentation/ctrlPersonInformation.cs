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
    public partial class ctrlPersonInformation : UserControl
    {
        public int _PersonID=-1;

     public void FillControl(int PersonID)
        {
            _PersonID= PersonID;
            clsPerson Person=clsPerson.FindByID(PersonID);
            if(Person==null)
            {
                MessageBox.Show($"Person With This Id[{PersonID}] Doesn't Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblPersonID.Text = PersonID.ToString();
            lblName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            lblNationalNo.Text=Person.NationalNo;
            if (Person.Gender == 0)
                lblGender.Text = "Male";
            else lblGender.Text = "Female";

            lblEmail.Text = Person.Email;
            lblAddress.Text = Person.Address;
            lblPhone.Text = Person.Phone;   
            lblDateOfBirth.Text=Person.DateOfBirth.Date.ToString("yyyy-MM-dd");
            lblCountry.Text=clsCountry.Find(Person.NationalityCountryID).CountryName;
            pbImage.ImageLocation=Person.ImagePath;
        }

        public void FillControl(string NationalNo)
        {
            
            clsPerson Person = clsPerson.FindByNationalNo(NationalNo);
            if (Person == null)
            {
                MessageBox.Show($"Person With This NationalNo[{NationalNo}] Doesn't Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _PersonID = Person.PersonID;    
            lblPersonID.Text = Person.PersonID.ToString();
            lblName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            lblNationalNo.Text = Person.NationalNo;
            if (Person.Gender == 0)
                lblGender.Text = "Male";
            else lblGender.Text = "Female";

            lblEmail.Text = Person.Email;
            lblAddress.Text = Person.Address;
            lblPhone.Text = Person.Phone;
            lblDateOfBirth.Text = Person.DateOfBirth.Date.ToString("yyyy-MM-dd");
            lblCountry.Text = clsCountry.Find(Person.NationalityCountryID).CountryName;
            pbImage.ImageLocation = Person.ImagePath;
        }

        public ctrlPersonInformation()
        {
            InitializeComponent();
           
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_PersonID != -1)
            {
                frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
                frm.ShowDialog();
                FillControl(_PersonID);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
