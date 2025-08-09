using DVLD_businessLogic;
using DVLD_presentation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_presentation
{
    public partial class frmAddUpdatePerson : Form
    {

        enum enMode {AddNew=0,Update=1 };
        private enMode _Mode;
        private int _PersonID;
       clsPerson _Person;
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            if (_PersonID==-1)
            {
                _Mode = enMode.AddNew;
            }else _Mode = enMode.Update;


        }


        private void _FillCountriesDropDownList()
        {
            DataTable Countries = clsCountry.GetAllCountries();

            foreach (DataRow row in Countries.Rows)
            {
                cbCountries.Items.Add(row[1].ToString());
            }
           
        }
        private void _LoadForNew()
        {
            
                _Person = new clsPerson();
                cbCountries.SelectedIndex = 89;
                lblAddUpdatePerson.Text = "Add New Person";
               
            
        }

        private void _LoadForUpdate()
        {
            _Person = clsPerson.FindByID(_PersonID);

            lblAddUpdatePerson.Text = "Update Person";
            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.Find(_Person.NationalityCountryID).CountryName);
            if (_Person.ImagePath != "")
            {
                pbImage.Load(_Person.ImagePath);    
                linkRemoveImage.Visible = true;
            }

            if (_Person.Gender == 0)
            {
                rbMale.Checked = true;
            }
            else rbFemale.Checked = true;
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            _FillCountriesDropDownList();


            if (_Mode == enMode.AddNew)
            {
                _LoadForNew();
                return;
            }

           

            _LoadForUpdate();


        }


        public delegate void RefreshDataHandlerUser(int personID);
        public event RefreshDataHandlerUser RefreshDataUser;

        public delegate void RefreshDataHandler();
        public event RefreshDataHandler RefreshData;

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt=sender as TextBox;  


            if (string.IsNullOrEmpty(txt.Text))
            {
                
                errorProvider.SetError(txt, "required!");
            }
            else
            {
                errorProvider.SetError(txt, "");
            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (clsPerson.isPersonExistsByNationalNo(txtNationalNo.Text))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "National Number Is Used For Another Person!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNo, "");
            }
        }

        
        

        private void ChangeImageBasedOnGender()
        {
            if (rbMale.Checked)
            {
                pbImage.Image = Properties.Resources.Male_512;
            }
            else
            {
                pbImage.Image = Properties.Resources.Female_512;
            }
        }

        private void rbGender_CheckedChanged(object sender, EventArgs e)
        {
            if (pbImage.ImageLocation==null)
            {
                ChangeImageBasedOnGender();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUpdatePerson()
        {
             
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.NationalNo = txtNationalNo.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Address = txtAddress.Text;
            _Person.Phone = txtPhone.Text;
            _Person.Email = txtEmail.Text;
            if(rbFemale.Checked)
            _Person.Gender=1;
            else
            {
                 _Person.Gender = 0;
            }
            _Person.NationalityCountryID = clsCountry.GetCountryIDFromName(cbCountries.Text);
            if (pbImage.ImageLocation!=null)
                _Person.ImagePath = pbImage.ImageLocation;
           else
              _Person.ImagePath = "";

            if(_Person.Save())
            {
                MessageBox.Show("Person Saved Successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                lblAddUpdatePerson.Text = "Update Person";
                lblPersonID.Text=_Person.PersonID.ToString();
                _PersonID=_Person.PersonID; 
            }
            
            
        }

        private void SavePersonImage()
        {
            string folderPath = @"D:\DVLDproj\RegisterdPeopleImages";  // Folder to save the image


            Guid newGuid = Guid.NewGuid();
       

            string fileName = newGuid.ToString();           // Image file name
            string fullPath = Path.Combine(folderPath, fileName);
            pbImage.Image.Save(fullPath, System.Drawing.Imaging.ImageFormat.Jpeg);
           
        }

        //Save Person
        private void btnSave_Click(object sender, EventArgs e)
        {
            AddUpdatePerson();
            RefreshData?.Invoke();
            RefreshDataUser?.Invoke(_PersonID);
            SavePersonImage();
          
           
        }

      

        private void linkSelectImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ofdSelectPersonImage.InitialDirectory = "D:\\DVLDproj\\PeopleImages";
            ofdSelectPersonImage.Title = "Select Image";

            if(ofdSelectPersonImage.ShowDialog() == DialogResult.OK)
            {
                pbImage.Load(ofdSelectPersonImage.FileName);

               

                linkRemoveImage.Visible=true;
            }


        }

        //Email Validating

        private static readonly Regex EmailRegex = new Regex(
      @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
      RegexOptions.Compiled
             );

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!EmailRegex.IsMatch(txtEmail.Text) && !string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProviderEmail.SetError(txtEmail, "Invalid Email Format!");
            }
            else
            {
                errorProviderEmail.SetError(txtEmail, "");
            }
        }

        private void linkRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeImageBasedOnGender();

            linkRemoveImage.Visible = false;
            pbImage.ImageLocation = null;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
