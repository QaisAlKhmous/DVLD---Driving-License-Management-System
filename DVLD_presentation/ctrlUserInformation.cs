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
    public partial class ctrlUserInformation : UserControl
    {
        public ctrlUserInformation()
        {
            InitializeComponent();
        }

        public void FillUserControl(int UserID,int PersonID,string UserName,string Password,bool IsActive)
        {
            


            lblUserID.Text=UserID.ToString();
            lblUserName.Text=UserName.ToString();
            if (IsActive)
                lblIsActive.Text = "Yes";
            else lblIsActive.Text = "No";


            ctrlPersonInformation1.FillControl(PersonID);

        }
    }
}
