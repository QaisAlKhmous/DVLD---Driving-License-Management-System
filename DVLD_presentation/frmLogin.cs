using DVLD_businessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Win32;

namespace DVLD_presentation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void _OpenMainForm()
        {
            MainForm frm = new MainForm();
            frm.ShowDialog();
        }

        private void _RememberUser(string Username,string Password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";


            try
            {
                // Write the value to the Registry
                Registry.SetValue(KeyPath, "Username", Username, RegistryValueKind.String);
                Registry.SetValue(KeyPath, "Password", Password, RegistryValueKind.String);


                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

      private void _FillWithRememberdUser()
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            try
            {
                // Read the value from the Registry
                string Username = Registry.GetValue(keyPath, "Username", null) as string;
                string Password = Registry.GetValue(keyPath, "Password", null) as string;


                if (Username != null&&Password!=null)
                {
                    txtUserName.Text = Username;
                    txtPassword.Text = Password;
                }
              

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username=txtUserName.Text;
            string password=txtPassword.Text;

            clsGlobalSettings.SetCurrentUser(username);

            bool Password = clsGlobalSettings._LogedInUser.CheckPassword(password);

            if (clsGlobalSettings._LogedInUser!=null&&clsGlobalSettings._LogedInUser.CheckPassword(password))
            {
                if(clsGlobalSettings._LogedInUser.isActive)
                {

                    if (cbRemeberme.Checked)
                        _RememberUser(username, password);

                    this.Visible = false;

                    _OpenMainForm();
                    
                    this.Visible=true;
                }
                else
                {
                    MessageBox.Show("Your Account Was Deactivated Please Contact Your Admin!", "Not Active", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Username/Password!","Wrong Credntials",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _FillWithRememberdUser();
        }
    }
}
