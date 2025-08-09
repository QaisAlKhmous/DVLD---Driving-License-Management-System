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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
         
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form frm = new ManagePeopleForm();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frmUsersManagement frm = new frmUsersManagement();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frmUserInfo frm = new frmUserInfo(clsGlobalSettings._LogedInUser.UserID);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frmChangePassword frm=new frmChangePassword(clsGlobalSettings._LogedInUser.UserID);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frmManageApplicationTypes frm = new frmManageApplicationTypes();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frmManageTestTypes frm = new frmManageTestTypes();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frmAddLocalDrivingLicenseApp frm = new frmAddLocalDrivingLicenseApp(-1);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frmManageLocalDrivingLicenseApplication frm = new frmManageLocalDrivingLicenseApplication();
                frm.MdiParent = this;
                frm.Show();
                    
            }
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frmManageDrivers frm = new frmManageDrivers();
                frm.MdiParent = this;
                frm.Show();

            }
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frmInternationalLicenseApplication frm = new frmInternationalLicenseApplication();
                frm.MdiParent = this;
                frm.Show();

            }
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frmManageInternationalDrivingLicenseApplications frm = new frmManageInternationalDrivingLicenseApplications();
                frm.MdiParent = this;
                frm.Show();

            }
        }

        private void renewLocalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.MdiChildren.Length == 0)
            {
                frmRenewLicenseApplication frm = new frmRenewLicenseApplication();
                frm.MdiParent = this;
                frm.Show();

            }

        }

        private void replacmentForToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frmReplacmentForDamaged frm = new frmReplacmentForDamaged();
                frm.MdiParent = this;
                frm.Show();

            }

        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frmDetainLicense frm = new frmDetainLicense();
                frm.MdiParent = this;
                frm.Show();

            }

        }

        private void releaseDetainedLicensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
                frm.MdiParent = this;
                frm.Show();

            }
        }

        private void manageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.MdiChildren.Length == 0)
            {
                frmListDetailedLicenses frm = new frmListDetailedLicenses();
                frm.MdiParent = this;
                frm.Show();

            }
        }
    }
}
