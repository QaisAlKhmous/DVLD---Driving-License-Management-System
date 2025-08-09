using DVLD_dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_businessLogic
{
    public class clsApplication
    {

        enum enMode { AddNew=1,Update=2}
        enMode _Mode;

        public int ApplicationID { get; set; }
        public int ApplicationPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID {  get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        private clsApplication(int ApplicationID, int ApplicationPersonID, DateTime ApplicationDate, int ApplicationTypeID,
            byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicationPersonID = ApplicationPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            _Mode=enMode.Update;
        }


        public clsApplication()
        {

            ApplicationID = -1;  
            ApplicationPersonID = 0;
            ApplicationDate = DateTime.MinValue;
            ApplicationTypeID = -1;
            ApplicationStatus = 0;
            LastStatusDate = DateTime.MinValue;
            PaidFees = -1;
            CreatedByUserID = -1;


            _Mode=enMode.AddNew;
        }


        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationDataAccess.AddNewApplication(this.ApplicationPersonID, this.ApplicationDate,
                this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return this.ApplicationID != -1;
        }

        private bool _UpdateApplication()
        {
            return clsApplicationDataAccess.UpdateApplication(this.ApplicationID,this.ApplicationPersonID,this.ApplicationDate,
                this.ApplicationTypeID,this.ApplicationStatus,this.LastStatusDate,this.PaidFees,this.CreatedByUserID);
        }

        public static clsApplication Find(int ApplicationID)
        {
            int ApplicationPersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;
            DateTime ApplicationDate= DateTime.MinValue, LastStatusDate= DateTime.MinValue;
            byte ApplicationStatus = 0;
            decimal PaidFees = -1;

            if (clsApplicationDataAccess.GetApplication(ApplicationID, ref ApplicationPersonID, ref ApplicationDate, ref ApplicationTypeID,
                ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplication(ApplicationID, ApplicationPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus,
                    LastStatusDate, PaidFees, CreatedByUserID);
            }
            else return null;
        }


        public bool Save()
        {


            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {

                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplication();

            }


            return false;
        }
    }
}
