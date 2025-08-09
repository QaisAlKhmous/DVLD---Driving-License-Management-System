using DVLD_businessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_presentation
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void _RefreshTestTypes()
        {
            dgvTestTypes.DataSource=clsTestType.GetAllTestTypes();
            lblNumberOfRecords.Text=dgvTestTypes.RowCount.ToString();
        }
        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshTestTypes();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int TestTypeID=int.Parse(dgvTestTypes.CurrentRow.Cells[0].Value.ToString());  
            frmUpdateTestTypes frm = new frmUpdateTestTypes(TestTypeID);
            frm.RefreshData += _RefreshTestTypes;
            frm.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
