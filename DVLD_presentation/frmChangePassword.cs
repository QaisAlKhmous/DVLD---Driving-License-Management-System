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
    public partial class frmChangePassword : Form
    {
        private int _UserID = -1;
        private clsUser User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;

        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if(txt!=null)
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
            return txtNewPass.Text == ConfirmPass;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User.Password = txtNewPass.Text;
            if (User.Save())
            {
                MessageBox.Show("Password Saved Successfully!", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Failed To Change Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
             User = clsUser.Find(_UserID);

            ctrlUserInformation1.FillUserControl(_UserID, User.PersonID,User.UserName,User.Password,User.isActive);
        }

        public delegate void RefreshEventHandler();
        public RefreshEventHandler RefreshData;

        private void txtCurrentPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtCurrentPass.Text != User.Password)
            {
                errorProvider2.SetError(txtNewPass, "Wrong Password!");
                e.Cancel = true;
            }else
            {
                errorProvider2.SetError(txtNewPass, "");
                e.Cancel = false;
            }
        }
    }
}
