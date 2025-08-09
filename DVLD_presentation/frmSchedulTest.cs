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
    public partial class frmSchedulTest : Form
    {

        enum enMode { AddNew=1,Update=2}
        private enMode _Mode;

        private int _LDLAppID;
        private int _TestAppointmentID;
        private int _TestTypeID;
        private bool _retake;
        private clsTestAppointments Appointment;
        public frmSchedulTest(int lDLAppID,int TestAppointmentID,int TestTypeID,bool retake)
        {
            InitializeComponent();
            _TestAppointmentID = TestAppointmentID;
            _TestTypeID = TestTypeID;
            _LDLAppID = lDLAppID;
            _retake = retake;
            if (TestAppointmentID == -1)
            {
               
                _Mode = enMode.AddNew;  
            }
            else
            {
                _Mode= enMode.Update;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTitle()
        {
            switch(_TestTypeID)
            {
                case 1: gbTestName.Text = "Vision Test"; break;
                case 2: gbTestName.Text = "Written Test"; break;
                case 3: gbTestName.Text = "Drive Test"; break;
            }
        }

        private void LoadForm()
        {

            UpdateTitle();
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);
            clsLicenseClass licenseClass = clsLicenseClass.Find(LDLApp.LicenseClassID);
            clsApplication App = clsApplication.Find(LDLApp.ApplicationID);
         
            clsPerson Applicant = clsPerson.FindByID(App.ApplicationPersonID);
            DataTable dt = clsTestAppointments.GetTestAppointments(_TestTypeID, _LDLAppID);


            lblClass.Text = licenseClass.ClassName.ToString();
            lblName.Text = Applicant.FirstName + " " + Applicant.SecondName + " " + Applicant.ThirdName + " " + Applicant.LastName;
            lblTrial.Text = dt.Rows.Count.ToString();
            lblAppID.Text = LDLApp.LocalDrivingLicenseApplicationID.ToString();

            if (_Mode == enMode.AddNew)
            {

                clsTestType testType = clsTestType.Find(_TestTypeID);

                Appointment = new clsTestAppointments();

              
              
                
               
                lblFees.Text = testType.TestTypeFees.ToString();
            }
            else
            {
                Appointment = clsTestAppointments.Find(_TestAppointmentID);
        


                dtpAppointmentDate.Value = Appointment.AppointmentDate;
                lblFees.Text=Appointment.PaidFees.ToString();
                if (Appointment.IsLocked)
                {
                    lbl2.Text = "person already sat for the test, appointment is locked!";
                    dtpAppointmentDate.Enabled = false;
                    btnSave.Enabled = false;    
                }

            }

            if(_retake)
            {
                gbRetakeTest.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblRAppFees.Text = clsApplicationType.Find(7).ApplicationFees.ToString();
                lblTotalFees.Text=(decimal.Parse(lblFees.Text)+ decimal.Parse(lblRAppFees.Text)).ToString();
            }

        }

      

        private void frmSchedulTest_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void addRetakeTestApplication()
        {
            clsApplication newapplication= new clsApplication();
            clsLocalDrivingLicenseApplication ldlapp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);
            clsApplication application=clsApplication.Find(ldlapp.ApplicationID);
            
            newapplication.ApplicationPersonID=application.ApplicationPersonID;
            newapplication.ApplicationDate=DateTime.Now;
            newapplication.ApplicationTypeID = 7;
            newapplication.ApplicationStatus = 1;
            newapplication.LastStatusDate = DateTime.Now;
            newapplication.PaidFees = decimal.Parse(lblRAppFees.Text);
            newapplication.CreatedByUserID=clsGlobalSettings._LogedInUser.UserID;

            newapplication.Save();

            Appointment.RetakeTestApplicationID= newapplication.ApplicationID;
        }

        private void SaveAppointment()
        {
           
            Appointment.TestTypeID=_TestTypeID;
            Appointment.LocalDrivinglicenseApplicationID= _LDLAppID;
            Appointment.AppointmentDate=dtpAppointmentDate.Value;
            Appointment.PaidFees = decimal.Parse(lblFees.Text);
            Appointment.CreatedByUser=clsGlobalSettings._LogedInUser.UserID;
            Appointment.IsLocked = false;

            if(_retake)
            {
                addRetakeTestApplication();
                lblRTAppID.Text=Appointment.RetakeTestApplicationID.ToString();
    
            }
            else
            {

            }


           if (Appointment.Save())
            {
                MessageBox.Show("Appointment Saved Successfully", "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Appointment Failed To Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAppointment();
        }

        private void lblTrial_Click(object sender, EventArgs e)
        {

        }
    }
}
