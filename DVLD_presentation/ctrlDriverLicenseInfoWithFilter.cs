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
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        public delegate void EventHandler();
        public EventHandler handleET;

        public int licenseID { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtLicenseiD.Text.Length > 0)
            {
                licenseID = int.Parse(txtLicenseiD.Text.ToString());

                ctrlDriverLicenseInfo1.FillControlByLicenseID(licenseID);
                handleET?.Invoke();

            }
            else MessageBox.Show("Enter a valid License ID to search","error",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            

        }

        private void ctrlDriverLicenseInfoWithFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
