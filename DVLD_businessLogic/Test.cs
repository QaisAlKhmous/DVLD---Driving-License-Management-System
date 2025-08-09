using DVLD_dataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace DVLD_businessLogic
{
    public class clsTest
    {

        enum enMode { AddNew=1,Update=2};
        enMode _Mode;

        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

       public clsTest()
        {

            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = "";
            CreatedByUserID = -1;
            _Mode = enMode.AddNew;
        }

        private clsTest( int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            _Mode = enMode.Update;
           
            TestAppointmentID = testAppointmentID;
            TestResult = testResult;
            Notes = notes;
            CreatedByUserID = createdByUserID;
        }

        private bool _AddNewTest()
        {
            this.TestID = clsTestDataAccess.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
            return this.TestID != -1;
        }


        static public bool isTestExists(int TestAppointmentID,bool TestResult)
        {
            return clsTestDataAccess.isTestExists(TestAppointmentID, TestResult);
        }


        public bool Save()
        {


            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {

                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return false;

            }


            return false;
        }

    }
}
