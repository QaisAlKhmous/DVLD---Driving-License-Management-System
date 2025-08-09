using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_dataAccess;

namespace DVLD_businessLogic
{
    public class clsDriver
    {
        private enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsDriver()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;
            _Mode = enMode.AddNew;
        }

        private clsDriver(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
            _Mode = enMode.Update;
        }

        private bool _AddNewDriver()
        {
            this.DriverID = clsDriverDataAccess.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);
            return this.DriverID != -1;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    // Update logic (if needed)
                    return false;
            }

            return false;
        }

        public static clsDriver Find(int driverID)
        {
            int personID = -1;
            int createdByUserID = -1;
            DateTime createdDate = DateTime.MinValue;

            if (clsDriverDataAccess.GetDriverByID(driverID, ref personID, ref createdByUserID, ref createdDate))
            {
                return new clsDriver(driverID, personID, createdByUserID, createdDate);
            }
            else
            {
                return null;
            }
        }

        public static clsDriver FindByPersonID(int personID)
        {
            int driverID = -1;
            int createdByUserID = -1;
            DateTime createdDate = DateTime.MinValue;

            if (clsDriverDataAccess.GetDriverByPersonID(personID, ref driverID, ref createdByUserID, ref createdDate))
            {
                return new clsDriver(driverID, personID, createdByUserID, createdDate);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriverDataAccess.GetAllDrivers();
        }
    }
}
