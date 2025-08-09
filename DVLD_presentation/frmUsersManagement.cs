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
    public partial class frmUsersManagement : Form
    {
        public frmUsersManagement()
        {
            InitializeComponent();
        }
        private DataTable _Users;
        private DataView _UsersView;
        

        private void _RefreshNumberOfRecordsLabel()
        {
            lblNumberOfRecords.Text = dgv_ManageUsers.RowCount.ToString();
        }

        private void _RefreshUsersData()
        {

            _Users= clsUser.GetAllUsers();
            _UsersView=_Users.DefaultView;
            dgv_ManageUsers.DataSource = _Users;
            _RefreshNumberOfRecordsLabel();

        }

        private void frmUsersManagement_Load(object sender, EventArgs e)
        {
           
            cb_UsersFilter.SelectedIndex = 0;   

            _RefreshUsersData();
        }



        private void cb_UsersFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            textUsersFilter.Text = null;
            textUsersFilter.KeyPress -= textPeopleFilter_KeyPress;


            if(cb_UsersFilter.SelectedIndex==0)
            {
                textUsersFilter.Visible = false;
                cbIsActive.Visible = false;
            }
          

           else if(cb_UsersFilter.SelectedIndex == 5)
            {
                cbIsActive.Visible=true;
                textUsersFilter.Visible = false;
            }


           else 
            {
                cbIsActive.Visible = false;
                textUsersFilter.Visible = true;
                if(cb_UsersFilter.SelectedIndex==1||cb_UsersFilter.SelectedIndex==2)
                textUsersFilter.KeyPress += textPeopleFilter_KeyPress;
            }

          
        }

        private void textPeopleFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits (0-9) and backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void textUsersFilter_TextChanged(object sender, EventArgs e)
        {
            _UsersView.RowFilter = "";
            if (textUsersFilter.Text != "")

            {
                string column = cb_UsersFilter.Text.Replace(" ", "");

                _UsersView.RowFilter = $"CONVERT({column}, 'System.String') LIKE '{textUsersFilter.Text}%'";
            }
            dgv_ManageUsers.DataSource = _UsersView;
            _RefreshNumberOfRecordsLabel();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _UsersView.RowFilter = "";
            if (cbIsActive.SelectedIndex == 1)
            {
                _UsersView.RowFilter = "isActive = 1";
            }
            if(cbIsActive.SelectedIndex == 2)
            {
                _UsersView.RowFilter = "isActive = 0";
            }

            dgv_ManageUsers.DataSource = _UsersView;
            _RefreshNumberOfRecordsLabel();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenAddNewUserForm()
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(-1);
            frm.RefreshData += _RefreshUsersData;
            frm.ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            OpenAddNewUserForm();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm=new frmAddUpdateUser(int.Parse(dgv_ManageUsers.CurrentRow.Cells[0].Value.ToString()));
            frm.RefreshData += _RefreshUsersData;
            frm.ShowDialog();
        }

        private void _DeleteUser(int UserID)
        {
            if (clsUser.DeleteUser(UserID))
                MessageBox.Show($"User[{UserID}] Deleted Successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show($"Failed To Delete User[{UserID}]", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = int.Parse(dgv_ManageUsers.CurrentRow.Cells[0].Value.ToString());

            if(MessageBox.Show($"Are You Sure You Want To Delete This User With ID[{UserID}]","User Deletion",MessageBoxButtons.OKCancel
                ,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.OK)
            {
                _DeleteUser(UserID);
                _RefreshUsersData();
            }
           
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddNewUserForm();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = int.Parse(dgv_ManageUsers.CurrentRow.Cells[0].Value.ToString());
            frmChangePassword frm = new frmChangePassword(UserID);
            frm.RefreshData += _RefreshUsersData;
            frm.ShowDialog();

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = int.Parse(dgv_ManageUsers.CurrentRow.Cells[0].Value.ToString());
            frmUserInfo frm = new frmUserInfo(UserID);
            frm.ShowDialog();
        }
    }
}
