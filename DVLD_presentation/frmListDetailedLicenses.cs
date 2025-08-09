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
    public partial class frmListDetailedLicenses : Form
    {
        public frmListDetailedLicenses()
        {
            InitializeComponent();
        }

        DataTable detainedLicenses_table;
        DataView detainedLicense_view;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshData()
        {
            detainedLicenses_table=clsDetainedLicense.GetAllDetainedLicenses();
            detainedLicense_view=detainedLicenses_table.DefaultView;
            dgvDetainedLicenses.DataSource= detainedLicenses_table;

            lblNumberOfRecords.Text=dgvDetainedLicenses.RowCount.ToString();
        }

        private void frmListDetailedLicenses_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void btnAddNewLDLApp_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm=new frmDetainLicense();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm=new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {


            if ((bool)dgvDetainedLicenses.CurrentRow.Cells["IsReleased"].Value == true)
            {
                cmsReleasedDetainedLicense.Enabled = false;
            }
            else
                cmsReleasedDetainedLicense.Enabled = true;
        }
    }
}
