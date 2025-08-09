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
    public partial class frmPersonDetails : Form
    {

        int _PersonID;
        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            
            ctrlPersonInformation1.FillControl(_PersonID); 

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
