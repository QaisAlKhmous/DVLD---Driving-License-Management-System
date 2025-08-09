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
    public partial class frmAddLocalDrivingLicenseApp : Form
    {


        enum enMode { AddNew=1,Update=2};
        enMode _Mode;

        private int _LDLAppID;
        private clsApplication _Application;
        private clsLocalDrivingLicenseApplication _LDLApp;

        public delegate void HandleDelegate();
        public HandleDelegate RefreshData;
        

        public frmAddLocalDrivingLicenseApp(int DLAppID)
        {
            InitializeComponent();
            _LDLAppID = DLAppID;
            if (_LDLAppID == -1)
            {
                _Mode= enMode.AddNew;
            }else _Mode= enMode.Update;

        }

        private void btnNextTab_Click(object sender, EventArgs e)
        {
            tcNewLocalLicenseApp.SelectedIndex = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FillComboBox()
        {
          DataTable dt=clsLicenseClass.GetAllLicenseClasses();

            foreach (DataRow dr in dt.Rows)
            {
                cbLicenseClasses.Items.Add(dr["ClassName"].ToString());
            }
        }


        private void _Load()
        {
            clsApplicationType LDL = clsApplicationType.Find(1);// ID=1 --->> Local Driving License


            lblAppDate.Text = DateTime.Now.ToString("d");
            lblCreatedByUser.Text = clsGlobalSettings._LogedInUser.UserName.ToString();
            lblAppFees.Text = LDL.ApplicationFees.ToString();


            if (_Mode== enMode.Update)
            {
                _LDLApp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);
                _Application = clsApplication.Find(_LDLApp.ApplicationID);
                lblNewUpdateDLApp.Text = "Update Local Driving License Application";
                lblDLAppID.Text= _LDLAppID.ToString();
                ctrlPersonDetailsWithFilter1.PersonID=_Application.ApplicationPersonID;
                ctrlPersonDetailsWithFilter1.DisableFindBy(_Application.ApplicationPersonID);
                ctrlPersonDetailsWithFilter1.FindPerson(_Application.ApplicationPersonID);  
                return;
            }

            _Application=new clsApplication();
            _LDLApp = new clsLocalDrivingLicenseApplication();


        }

        private void frmLocalDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            _FillComboBox();

            _Load();
        }

        private void _AddNewLDLApp()
        {
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationPersonID=ctrlPersonDetailsWithFilter1.PersonID;
            _Application.ApplicationStatus = 1;
            _Application.ApplicationTypeID = 1;
            _Application.LastStatusDate = DateTime.Now;
            _Application.PaidFees=Convert.ToDecimal(lblAppFees.Text.ToString());
            _Application.CreatedByUserID = clsGlobalSettings._LogedInUser.UserID;
            if (_Application.Save())
            {
                _LDLApp.ApplicationID = _Application.ApplicationID;
                _LDLApp.LicenseClassID=cbLicenseClasses.SelectedIndex+1;  

                if(_LDLApp.Save())
                {
                    MessageBox.Show("Application Saved Successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    lblNewUpdateDLApp.Text = "Update Local Driving License Application";
                    lblDLAppID.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();
                    _Mode = enMode.Update;
                }
            }

        }


        private void _UpdateLDLApp()
        {
            
          
                
                _LDLApp.LicenseClassID = cbLicenseClasses.SelectedIndex + 1;

                if (_LDLApp.Save())
                {
                    MessageBox.Show("Application Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    lblDLAppID.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();
                }else
            {
                MessageBox.Show("failed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
                if (clsLocalDrivingLicenseApplication.DoesPersonHaveAppForLicense(ctrlPersonDetailsWithFilter1.PersonID, cbLicenseClasses.SelectedIndex + 1, 1))
                {

                    MessageBox.Show("Person Can't have More Than One Application For Same Class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    if (clsLocalDrivingLicenseApplication.DoesPersonHaveAppForLicense(ctrlPersonDetailsWithFilter1.PersonID, cbLicenseClasses.SelectedIndex + 1, 3))
                    {
                        MessageBox.Show("Person already have a driving license with the same applied class, choose a different class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                    if(_Mode==enMode.AddNew)
                        _AddNewLDLApp();
                    else _UpdateLDLApp();


                       

                    }


                }
         

            RefreshData?.Invoke();
        }
    }
}
