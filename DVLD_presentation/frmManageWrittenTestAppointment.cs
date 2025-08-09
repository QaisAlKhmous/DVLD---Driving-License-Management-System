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
    public partial class frmManageWrittenTestAppointment : Form
    {

        private int _LDLAppID;
        private int _NumOfPassedTests;
        private bool _pass;
        public frmManageWrittenTestAppointment(int LDLAppID,int NumOfPassedTests)
        {

            InitializeComponent();
            _LDLAppID = LDLAppID;
            _NumOfPassedTests = NumOfPassedTests;   
        }


        private void passTest()
        {
            _pass = true;
        }


        private void RefreshAppointments()
        {
            dgvTestAppointments.DataSource = clsTestAppointments.GetTestAppointments(2, _LDLAppID);
        }

        private void frmManageWrittenTestAppointment_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseAppInfo1.FillControl(_LDLAppID, _NumOfPassedTests);
            RefreshAppointments();
        }

        private void RegulerTest()
        {

            frmSchedulTest frm = new frmSchedulTest(_LDLAppID, -1, 2, false);
            frm.ShowDialog();
            RefreshAppointments();

        }
        private void RetakeTest()
        {
            frmSchedulTest frm = new frmSchedulTest(_LDLAppID, -1, 2, true);
            frm.ShowDialog();
            RefreshAppointments();
        }



        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (!clsTestAppointments.isAppointmentExists(2, _LDLAppID))
            {

                RegulerTest();

            }
            else
            {
                if (clsTestAppointments.isActiveAppointmentExists(2, _LDLAppID))
                {
                    MessageBox.Show("Person already have an active appointment for this test, cannot add a new appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (_pass)
                    {
                        MessageBox.Show("this person already passed this test, you can retake failed tests only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        RetakeTest();
                    }



                }


            }
        }

    

      

        private void takeTestToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int testAppointmentID = int.Parse(dgvTestAppointments.CurrentRow.Cells[0].Value.ToString());
            frmTakeTest frm = new frmTakeTest(testAppointmentID);
            frm.RefreshData += RefreshAppointments;
            frm.passtest += passTest;
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int testAppointmentID = int.Parse(dgvTestAppointments.CurrentRow.Cells[0].Value.ToString());
            frmSchedulTest frm = new frmSchedulTest(_LDLAppID, testAppointmentID, 2, false);
            frm.ShowDialog();
            RefreshAppointments();
        }
    }
}
