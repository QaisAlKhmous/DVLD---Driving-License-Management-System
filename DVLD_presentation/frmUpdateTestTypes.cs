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
    public partial class frmUpdateTestTypes : Form
    {

        private int _TestTypeID=-1;
        clsTestType TestType;
        public frmUpdateTestTypes(int TestTypesID)
        {
            InitializeComponent();
            _TestTypeID = TestTypesID;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _UpdateTestType()
        {
            TestType.TestTypeTitle = txtTestTitle.Text;
            TestType.TestTypeDescription = txtDescription.Text;
            TestType.TestTypeFees = Convert.ToDecimal(txtTestFees.Text);

            if(TestType.Update())
            {
                MessageBox.Show("Test Type Updated Successfully!","update",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            


        }

        public delegate void RefreshDataHandler();
        public RefreshDataHandler RefreshData;


        private void btnSave_Click(object sender, EventArgs e)
        {
            _UpdateTestType();
            RefreshData?.Invoke();
        }

        private void frmUpdateTestTypes_Load(object sender, EventArgs e)
        {
            TestType = clsTestType.Find(_TestTypeID);

            txtTestTitle.Text = TestType.TestTypeTitle;
            lblTestTypeID.Text=TestType.TestTypeID.ToString();
            txtDescription.Text = TestType.TestTypeDescription; 
            txtTestFees.Text=TestType.TestTypeFees.ToString();
        }
    }
}
