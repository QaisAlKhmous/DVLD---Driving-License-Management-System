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
    public partial class frmManageInternationalDrivingLicenseApplications : Form
    {
        public frmManageInternationalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private DataTable LicensesTable;
        private DataView LicensesView;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewLDLApp_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseApplication application = new frmInternationalLicenseApplication();
            application.ShowDialog();
        }

        private void _RefreshData()
        {
            LicensesTable = clsInternationalLicense.GetAllLicenses();
            LicensesView = LicensesTable.DefaultView;
            dgvIDLApps.DataSource = LicensesTable;
        }

        private void frmManageInternationalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _RefreshData();
            lblNumberOfRecords.Text=dgvIDLApps.RowCount.ToString(); 


        }

        private void cb_LDLAppsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            textLDLAppsFilter.Text = null;
            textLDLAppsFilter.Visible = true;
            cb_Status.Visible = false;

            textLDLAppsFilter.KeyPress -= textLDLAppsFilter_KeyPress;
           
      

            if (cb_LDLAppsFilter.SelectedIndex == 7)
            {
                textLDLAppsFilter.Visible = false;
                cb_Status.Visible = true;

            }

            if(cb_LDLAppsFilter.SelectedIndex==0)
            {
                textLDLAppsFilter.Visible = false;
                cb_Status.Visible = false;
            }

            if (cb_LDLAppsFilter.SelectedIndex != 5 && cb_LDLAppsFilter.SelectedIndex != 6)
            {
                textLDLAppsFilter.KeyPress += textLDLAppsFilter_KeyPress;
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

        private void textLDLAppsFilter_TextChanged(object sender, EventArgs e)
        {

            LicensesView.RowFilter = "";
            switch (cb_LDLAppsFilter.Text)
            {
                case "I.License ID": LicensesView.RowFilter = $"CONVERT(InternationalLicenseID, 'System.String') LIKE '{textLDLAppsFilter.Text}%'"; break;
                case "Application ID": LicensesView.RowFilter = $"CONVERT(ApplicationID, 'System.String') LIKE '{textLDLAppsFilter.Text}%'"; break;
                case "Driver ID": LicensesView.RowFilter = $"CONVERT(DriverID, 'System.String') LIKE '{textLDLAppsFilter.Text}%'"; break;
                case "L.License ID": LicensesView.RowFilter = $"CONVERT(IssuedUsingLocalLicenseID, 'System.String') LIKE '{textLDLAppsFilter.Text}%'"; break;
                case "Issue Date": LicensesView.RowFilter = $"CONVERT(IssueDate, 'System.String') LIKE '{textLDLAppsFilter.Text}%'"; break;
                case "Expiration Date": LicensesView.RowFilter = $"CONVERT(ExpirationDate, 'System.String') LIKE '{textLDLAppsFilter.Text}%'"; break;
                default: LicensesView.RowFilter = ""; break;

            }

            dgvIDLApps.DataSource = LicensesView;
            lblNumberOfRecords.Text = dgvIDLApps.RowCount.ToString();

        }

        private void cb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            LicensesView.RowFilter = "";
            if (cb_Status.SelectedIndex == 1)
            {
                LicensesView.RowFilter = "IsActive = 1";
            } 
            if(cb_Status.SelectedIndex == 2)
            {
                LicensesView.RowFilter = "IsActive = 0";
            }

            dgvIDLApps.DataSource = LicensesView;
            lblNumberOfRecords.Text = dgvIDLApps.RowCount.ToString();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = int.Parse(dgvIDLApps.CurrentRow.Cells[2].Value.ToString());
            clsDriver driver=clsDriver.Find(DriverID);
            frmPersonDetails frm = new frmPersonDetails(driver.PersonID);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void showLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = int.Parse(dgvIDLApps.CurrentRow.Cells[2].Value.ToString());
            clsDriver driver = clsDriver.Find(DriverID);
            frmLicenseHistory frm = new frmLicenseHistory(driver.PersonID);
            frm.ShowDialog();
        }
    }
}
