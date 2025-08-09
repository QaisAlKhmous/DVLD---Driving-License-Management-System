using DVLD_businessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_presentation
{
    public partial class frmManageLocalDrivingLicenseApplication : Form
    {
        public frmManageLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }


        private DataTable LDLApps;
        private DataView LDLAppsView;


        private void _RefreshData()
        {
           
            LDLApps = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLiocenseApplications();
            LDLAppsView=LDLApps.DefaultView;

            dgvLDLApps.DataSource= LDLAppsView;
            lblNumberOfRecords.Text=dgvLDLApps.RowCount.ToString(); 
        }

        private void frmManageLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_LDLAppsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            textLDLAppsFilter.Text = null;
            textLDLAppsFilter.Visible = false;
            cb_Status.Visible = false;

            textLDLAppsFilter.KeyPress -= textLDLAppsFilter_KeyPress;


            if (cb_LDLAppsFilter.SelectedIndex == 3 || cb_LDLAppsFilter.SelectedIndex == 2)
            {
                textLDLAppsFilter.Visible = true;
            }

                if (cb_LDLAppsFilter.SelectedIndex == 1 )
            {
                textLDLAppsFilter.Visible = true;
                
                textLDLAppsFilter.KeyPress += textLDLAppsFilter_KeyPress;
            }

            if(cb_LDLAppsFilter.SelectedIndex==4)
            {
                cb_Status.Visible = true;

            }
        }

        private void textLDLAppsFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits (0-9) and backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void cb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            LDLAppsView.RowFilter = "";
            if(cb_Status.SelectedIndex != 0 )
            LDLAppsView.RowFilter = $"Status='{cb_Status.Text}'";
            dgvLDLApps.DataSource = LDLAppsView;
            lblNumberOfRecords.Text = dgvLDLApps.RowCount.ToString();
        }

        private void textLDLAppsFilter_TextChanged(object sender, EventArgs e)
        {
            LDLAppsView.RowFilter = "";
            switch (cb_LDLAppsFilter.Text)
            {
                case "L.D.L.AppID":LDLAppsView.RowFilter = $"CONVERT(LocalDrivingLicenseApplicationID, 'System.String') LIKE '{textLDLAppsFilter.Text}%'";  break;
                case "National No.": LDLAppsView.RowFilter = $"NationalNo LIKE '{textLDLAppsFilter.Text}%'"; break;
                case "Full Name": LDLAppsView.RowFilter = $"FullName LIKE '{textLDLAppsFilter.Text}%'"; break;
                    default: LDLAppsView.RowFilter = ""; break;

            }

            dgvLDLApps.DataSource = LDLAppsView;
            lblNumberOfRecords.Text = dgvLDLApps.RowCount.ToString();
        }

        private void btnAddNewLDLApp_Click(object sender, EventArgs e)
        {
            frmAddLocalDrivingLicenseApp frm =new frmAddLocalDrivingLicenseApp(-1);
            frm.RefreshData += _RefreshData;
            frm.ShowDialog();

        }

        private void _cancelLocalApplication(int LDLAppID)
        {
           

            clsLocalDrivingLicenseApplication ldlapp = clsLocalDrivingLicenseApplication.Find(LDLAppID);

         




            clsApplication app = clsApplication.Find(ldlapp.ApplicationID);



            app.ApplicationStatus = Convert.ToByte(2);

            if (app.Save())
            {
                MessageBox.Show("Application Canceled Successfully!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed To Cancel", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString());

            if (MessageBox.Show($"Are You Sure You Want To Cancel This Application [{LDLAppID}]?","Cancel"
                ,MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.OK)
            {
                _cancelLocalApplication(LDLAppID);
                _RefreshData();
            }
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            itemCancelApp.Enabled = false;
            itemEditApp.Enabled = false;
            itemDeleteApp.Enabled = false;
            itemVisionTest.Enabled = false;
            itemWrittenTest.Enabled = false;
            itemStreetTest.Enabled = false;
            itemIssueDrivingLicense.Enabled = false;    
            if (dgvLDLApps.CurrentRow.Cells[6].Value.ToString()=="New")
            {
                itemCancelApp.Enabled = true;
                itemEditApp.Enabled = true;
                itemDeleteApp.Enabled = true;
                itemScheduleTest.Enabled = true;

                if (dgvLDLApps.CurrentRow.Cells[5].Value.ToString() == "0")
                    itemVisionTest.Enabled = true;
                if (dgvLDLApps.CurrentRow.Cells[5].Value.ToString() == "1")
                    itemWrittenTest.Enabled = true;
                if (dgvLDLApps.CurrentRow.Cells[5].Value.ToString() == "2")
                    itemStreetTest.Enabled = true;
                if(dgvLDLApps.CurrentRow.Cells[5].Value.ToString() == "3")
                {
                    itemScheduleTest.Enabled=false;
                    itemIssueDrivingLicense.Enabled=true;
                }
            }
            if(dgvLDLApps.CurrentRow.Cells[6].Value.ToString() == "Cancelled")
            {
                itemDeleteApp.Enabled = true;
            }

            
  
        }

        private void itemVisionTest_Click(object sender, EventArgs e)
        {
            int LDLAppID = int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString());
            int PassedTestsCount = int.Parse(dgvLDLApps.CurrentRow.Cells[5].Value.ToString());
            frmVisionTestAppointment frm=new frmVisionTestAppointment(LDLAppID, PassedTestsCount);
            frm.ShowDialog();
            _RefreshData();

        }

        private void itemWrittenTest_Click(object sender, EventArgs e)
        {
            int LDLAppID = int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString());
            int PassedTestsCount = int.Parse(dgvLDLApps.CurrentRow.Cells[5].Value.ToString());
            frmManageWrittenTestAppointment frm = new frmManageWrittenTestAppointment(LDLAppID, PassedTestsCount);
            frm.ShowDialog();
            _RefreshData();

        }


        private void itemStreetTest_Click(object sender, EventArgs e)
        {
            int LDLAppID = int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString());
            int PassedTestsCount = int.Parse(dgvLDLApps.CurrentRow.Cells[5].Value.ToString());
            frmManageStreetTestAppointments frm = new frmManageStreetTestAppointments(LDLAppID, PassedTestsCount);
            frm.ShowDialog();
            _RefreshData();
        }

        private void itemIssueDrivingLicense_Click(object sender, EventArgs e)
        {

            int LDLAppID = int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString());
            int PassedTestsCount = int.Parse(dgvLDLApps.CurrentRow.Cells[5].Value.ToString());
            frmIssueDriverLicenseFirstTime frm = new frmIssueDriverLicenseFirstTime(LDLAppID, PassedTestsCount);
            frm.ShowDialog();
            _RefreshData();
        }

        private void itemShowLicense_Click(object sender, EventArgs e)
        {
            int LDLAppID = int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString());
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(LDLAppID, false);
            frm.ShowDialog();
        }

        private void itemDeleteApp_Click(object sender, EventArgs e)
        {
            int LDLAppID = int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString());
            if (MessageBox.Show("Aru you sure you want to delete this application?", "delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if(clsLocalDrivingLicenseApplication.DeleteApplication(LDLAppID))
                {
                    _RefreshData();
                    MessageBox.Show("Application deleted successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              
            }
            
        }

        private void itemEditApp_Click(object sender, EventArgs e)
        {
            int LDLAppID = int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString());
            frmAddLocalDrivingLicenseApp frm = new frmAddLocalDrivingLicenseApp(LDLAppID);
            frm.RefreshData += _RefreshData;
            frm.ShowDialog();
        }

        private void itemShowLicenseHistory_Click(object sender, EventArgs e)
        {
            int LDLAppID = int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString());
            clsLocalDrivingLicenseApplication ldlapp=clsLocalDrivingLicenseApplication.Find(LDLAppID);
            clsApplication app=clsApplication.Find(ldlapp.ApplicationID);

            frmLicenseHistory frm = new frmLicenseHistory(app.ApplicationPersonID);
            frm.ShowDialog();

        }
    }
}
