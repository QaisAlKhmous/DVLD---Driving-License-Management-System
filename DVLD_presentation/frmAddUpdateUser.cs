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
    public partial class frmAddUpdateUser : Form
    {


        enum enMode {AddNew=1,Update=2 };
        enMode _Mode;
        private int _UserID;
        private clsUser _User;


        public delegate void RefreshEventHandler();
        public RefreshEventHandler RefreshData;

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            if(UserID != -1)
                _Mode = enMode.Update;
            else
                _Mode = enMode.AddNew;

        }
        private void _LoadAddNew()
        {
            lblAddUpdateUser.Text = "Add New User";
            _User = new clsUser();
        }

        private void _LoadUpdate()
        {
            _User=clsUser.Find(_UserID);

            lblAddUpdateUser.Text = "Update User";
            lblUserID.Text = _UserID.ToString();
            txtUserName.Text=_User.UserName;    
            txtPassword.Text = _User.Password;
            txtConfirmPass.Text = _User.Password;
            ctrlPersonDetailsWithFilter1.DisableFindBy(_User.PersonID);

            ctrlPersonDetailsWithFilter1.FindPerson(_User.Person.PersonID);


        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {

            if(_Mode == enMode.AddNew)
            {
                _LoadAddNew();
                return;
            }

            _LoadUpdate();

        }



        private void btnNextTab_Click(object sender, EventArgs e)
        {
            tabControlUser.SelectedIndex = 1;
        }

        private void SaveUserData()
        {

            _User.PersonID=ctrlPersonDetailsWithFilter1.PersonID;  
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.isActive=cbIsActive.Checked;
            
            if(_User.Save())
            {
                MessageBox.Show("User Saved Successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lblAddUpdateUser.Text = "Update User";
                lblUserID.Text = _User.UserID.ToString();
                _Mode = enMode.Update;
            }
            else
            {
                MessageBox.Show("Failed to save user","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveUserData();
            RefreshData?.Invoke();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlPersonDetailsWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (string.IsNullOrEmpty(txt.Text))
            {

                errorProvider1.SetError(txt, "required!");
            }
            else
            {
                errorProvider1.SetError(txt, "");
            }
        }

        private bool _CheckConfirmPass(string ConfirmPass)
        {
            return txtPassword.Text == ConfirmPass; 
        }

        private void txtConfirmPass_Validating(object sender, CancelEventArgs e)
        {
           
            if (!_CheckConfirmPass(txtConfirmPass.Text))
            {

                errorProvider1.SetError(txtConfirmPass, "Passwords Doesnt Match!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPass, "");
            }
        }
    }
}
