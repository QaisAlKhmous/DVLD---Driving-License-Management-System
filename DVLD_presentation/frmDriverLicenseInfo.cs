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
    public partial class frmDriverLicenseInfo : Form
    {

        private int _ID;
        private bool _LicensID;
        public frmDriverLicenseInfo(int ID,bool LicenseID)
        {
            InitializeComponent();
            _ID = ID; 
            _LicensID = LicenseID;
        }

        private void frmDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            if(_LicensID)
            ctrlDriverLicenseInfo1.FillControlByLicenseID(_ID);
            else ctrlDriverLicenseInfo1.FillControl(_ID);
        }
    }
}
