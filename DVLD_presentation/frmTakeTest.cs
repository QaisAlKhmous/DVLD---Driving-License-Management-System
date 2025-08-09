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
    public partial class frmTakeTest : Form
    {

        private clsTestAppointments testAppointment;
        private int _TestAppointmentID;
        
        public frmTakeTest(int TestAppointmentID)
        {
            InitializeComponent();

           testAppointment = clsTestAppointments.Find(TestAppointmentID);
            _TestAppointmentID = TestAppointmentID;
        }

        public delegate void RefreshEventHandler();
        public RefreshEventHandler RefreshData;
        public RefreshEventHandler passtest;

        private void frmTakeTest_Load(object sender, EventArgs e)
        {

            clsLocalDrivingLicenseApplication LDApp = clsLocalDrivingLicenseApplication.Find(testAppointment.LocalDrivinglicenseApplicationID);
            clsLicenseClass LClass = clsLicenseClass.Find(LDApp.LicenseClassID);
            clsApplication app=clsApplication.Find(LDApp.ApplicationID);    
            clsPerson person=clsPerson.FindByID(app.ApplicationPersonID);
            DataTable appointments = clsTestAppointments.GetTestAppointments(1, LDApp.LocalDrivingLicenseApplicationID);
            appointments.DefaultView.RowFilter = "IsLocked=1";
            clsTestType test = clsTestType.Find(1);
            

            lblDLApp.Text=testAppointment.LocalDrivinglicenseApplicationID.ToString();
            lblClass.Text=LClass.ClassName.ToString();
            lblName.Text=person.FirstName+" "+person.SecondName+" "+person.ThirdName+" "+person.LastName;
            lblTrial.Text=appointments.Rows.Count.ToString();   
            lblDate.Text=testAppointment.AppointmentDate.ToString();    
            lblFees.Text=test.TestTypeFees.ToString();
            lblTest.Text = "Not Taken Yet";



        }

        private void TakeTest()
        {
            clsTest test = new clsTest();
            test.TestAppointmentID = _TestAppointmentID;
            if (rbPass.Checked)
            {
                test.TestResult = true;
            }
            else
            {
                test.TestResult = false;

            }
            test.Notes = txtNotes.Text;
            test.CreatedByUserID = clsGlobalSettings._LogedInUser.UserID;
            testAppointment.IsLocked = true;

            if (test.Save() && testAppointment.Save())
            {
                MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (rbPass.Checked)
                {
                    passtest?.Invoke();
                }
            }
            else
            {
                MessageBox.Show("Failed to Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TakeTest();
            RefreshData?.Invoke();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbTestType_Enter(object sender, EventArgs e)
        {

        }
    }
}
