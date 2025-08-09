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
    public partial class ctrlLocalDrivingLicenseAppInfo : UserControl
    {
        public ctrlLocalDrivingLicenseAppInfo()
        {
            InitializeComponent();
        }


        public void FillControl(int LDLAppID,int NumOfPassedTests)
        {
            clsLocalDrivingLicenseApplication LDLApp=clsLocalDrivingLicenseApplication.Find(LDLAppID);  
            clsLicenseClass licenseClass=clsLicenseClass.Find(LDLApp.LicenseClassID);
          
            lblAppID.Text=LDLApp.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClass.Text=licenseClass.ClassName;
            lblPassedTests.Text=NumOfPassedTests.ToString() + "/3";

            ctrlApplicationBasicInfo1.FillControl(LDLApp.ApplicationID);

        }

      
    }
}
