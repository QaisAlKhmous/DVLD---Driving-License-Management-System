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
    public partial class frmUpdateApplicationType : Form
    {

        private int _AppTypeID = -1;
        clsApplicationType AppType;
        public frmUpdateApplicationType(int appTypeID)
        {
            InitializeComponent();
            _AppTypeID = appTypeID;
        }

        public delegate void RefreshDataHandle();
        public RefreshDataHandle RefreshData;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            AppType= clsApplicationType.Find(_AppTypeID);

            lblAppTypeID.Text = AppType.ApplicationTypeID.ToString();
            txtAppTitle.Text=AppType.ApplicationTypeTitle;
            txtAppFees.Text=AppType.ApplicationFees.ToString();
        }

        private void _SaveData()
        {
            AppType.ApplicationTypeTitle = txtAppTitle.Text;
            AppType.ApplicationFees = Convert.ToDecimal(txtAppFees.Text.ToString());

            if (AppType.Update())
            {
                RefreshData?.Invoke();
                MessageBox.Show("Application Type Updated Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _SaveData();


        }
    }
}
