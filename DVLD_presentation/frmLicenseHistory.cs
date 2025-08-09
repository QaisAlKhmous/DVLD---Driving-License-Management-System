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
    public partial class frmLicenseHistory : Form
    {

        private int _PersonID;
        public frmLicenseHistory(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {

            clsDriver driver=clsDriver.FindByPersonID(_PersonID);

            ctrlPersonDetailsWithFilter1.FindPerson(_PersonID);
            ctrlPersonDetailsWithFilter1.DisableFindBy(_PersonID);
            ctrlDriverLicenses1.FillControl(driver.DriverID);
            
        }
    }
}
