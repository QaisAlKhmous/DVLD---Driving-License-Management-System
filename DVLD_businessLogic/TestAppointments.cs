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
    public class clsTestAppointments
    {

        private enum enMode { AddNew=1,Update=2 };
        enMode _Mode;

        public int TestAppointmentID {  get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivinglicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUser { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }


        private clsTestAppointments(int TestAppointmentID, int TestTypeID, int LocalDrivinglicenseApplicationID, DateTime AppointmentDate,
            decimal PaidFees, int CreatedByUser, bool IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivinglicenseApplicationID = LocalDrivinglicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUser = CreatedByUser;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            _Mode=enMode.Update;
        }

        public clsTestAppointments()
        {

            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivinglicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUser = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;
            _Mode =enMode.AddNew;
        }

        private bool AddNewAppointment()
        {
            this.TestAppointmentID = clsTestAppoinmentsDataAccess.AddNewTestAppointment(TestAppointmentID, this.TestTypeID, this.LocalDrivinglicenseApplicationID, this.AppointmentDate
                , this.PaidFees, this.CreatedByUser, this.IsLocked, this.RetakeTestApplicationID);

            return this.TestAppointmentID != -1;
        }

        private bool UpdateTestAppointment()
        {
            return clsTestAppoinmentsDataAccess.UpdateTestAppointment(TestAppointmentID, this.TestTypeID, this.LocalDrivinglicenseApplicationID, this.AppointmentDate
                , this.PaidFees, this.CreatedByUser, this.IsLocked, this.RetakeTestApplicationID);
        }

        public static clsTestAppointments Find(int TestAppointmentID)
        {
            int TestTypeID=-1, LocalDrivinglicenseApplicationID=-1, RetakeTestApplicationID=-1,CreatedByUser=-1;
            decimal PaidFees = -1;
            DateTime AppointmentDate=DateTime.Now;
            bool IsLocked = false;


            if (clsTestAppoinmentsDataAccess.GetTestAppointmentByID(TestAppointmentID, ref TestTypeID, ref LocalDrivinglicenseApplicationID, ref AppointmentDate,
                ref PaidFees, ref CreatedByUser, ref IsLocked, ref RetakeTestApplicationID))

                return new clsTestAppointments(TestAppointmentID, TestTypeID, LocalDrivinglicenseApplicationID, AppointmentDate, PaidFees, CreatedByUser,
                    IsLocked, RetakeTestApplicationID);
            else
                return null;
        }


        public static DataTable GetTestAppointments(int TestTypeID,int ApplicationID)
        {
            return clsTestAppoinmentsDataAccess.GetTestAppointments(TestTypeID, ApplicationID);
        }

        public static bool isAppointmentExists(int TestTypeID, int ApplicationID)
        {
            return clsTestAppoinmentsDataAccess.isAppointmentExists(TestTypeID, ApplicationID);
        }

        public static bool isActiveAppointmentExists(int TestTypeID,int ApplicationID)
        {
            return clsTestAppoinmentsDataAccess.isActiveAppointmentExists(TestTypeID,ApplicationID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (AddNewAppointment())
                    {

                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return UpdateTestAppointment();

            }


            return false;
        }

    }
}
