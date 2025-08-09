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
    public partial class frmUserInfo : Form
    {
        private int _UserID = -1;
        private clsUser User;
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            this._UserID = UserID;


        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            User=clsUser.Find(_UserID);

            ctrlUserInformation1.FillUserControl(User.UserID, User.PersonID, User.UserName, User.Password, User.isActive);
        }
    }
}
