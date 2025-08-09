using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_businessLogic;

namespace DVLD_presentation
{
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

       private void _RefreshApplicationTypes()
        {
            dgvApplicationtypes.DataSource=clsApplicationType.GetAllApplicationTypes(); 
            lblNumberOfRecords.Text=dgvApplicationtypes.RowCount.ToString();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshApplicationTypes();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApptypeID = int.Parse(dgvApplicationtypes.CurrentRow.Cells[0].Value.ToString());
            frmUpdateApplicationType frm=new frmUpdateApplicationType(ApptypeID);
            frm.RefreshData += _RefreshApplicationTypes;
            frm.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
