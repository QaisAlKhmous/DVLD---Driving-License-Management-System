using DVLD_dataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_businessLogic
{
    public class clsDetainedLicense
    {

        enum enMode { AddNew=1,Update=2};
        enMode _Mode;

        public int DetainID {  get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate {  get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }

       private clsDetainedLicense(int detainID, int licenseID, DateTime detainDate, decimal fineFees, int createdByUserID, 
           bool isReleased, DateTime releaseDate, int releasedByUserID, int releaseApplicationID)
        {
           
            DetainID = detainID;
            LicenseID = licenseID;
            DetainDate = detainDate;
            FineFees = fineFees;
            CreatedByUserID = createdByUserID;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseApplicationID = releaseApplicationID;
            _Mode=enMode.Update;
        }

        public clsDetainedLicense() 
        {

            DetainID = -1;
            LicenseID = -1;
            DetainDate = DateTime.MinValue;
            FineFees = -1;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = DateTime.MinValue;
            ReleasedByUserID = -1;
            ReleaseApplicationID = -1;
            _Mode =enMode.AddNew;
        }

        private bool _AddNewDetainedLicense()
        {
            this.DetainID = clsDetainedLicenseDataAccess.AddNewDetainedLicense(
                this.LicenseID,
                this.DetainDate,
                this.FineFees,
                this.CreatedByUserID,
                this.IsReleased,
                this.ReleaseDate,
                this.ReleasedByUserID,
                this.ReleaseApplicationID
            );

            return this.DetainID != -1;
        }

        private bool _UpdateDetainedLicense()
        {
            return clsDetainedLicenseDataAccess.UpdateDetainedLicense(
                this.DetainID,
                this.LicenseID,
                this.DetainDate,
                this.FineFees,
                this.CreatedByUserID,
                this.IsReleased,
                this.ReleaseDate,
                this.ReleasedByUserID,
                this.ReleaseApplicationID
            );
        }


        public static clsDetainedLicense Find(int detainID)
        {
            int licenseID = -1;
            DateTime detainDate = DateTime.MinValue;
            decimal fineFees = -1;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime releaseDate = DateTime.MinValue;
            int releasedByUserID = -1;
            int releaseApplicationID = -1;

            if (clsDetainedLicenseDataAccess.GetDetainedLicenseByID(detainID, ref licenseID, ref detainDate,
                ref fineFees, ref createdByUserID, ref isReleased, ref releaseDate,
                ref releasedByUserID, ref releaseApplicationID))
            {
                return new clsDetainedLicense(detainID, licenseID, detainDate, fineFees, createdByUserID,
                    isReleased, releaseDate, releasedByUserID, releaseApplicationID);
            }

            return null;
        }


        public static bool isLicenseDetained(int LicenseID)
        {
            return clsDetainedLicenseDataAccess.isDetainedLicenseExistsByLicensID(LicenseID);
        }


        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateDetainedLicense();
            }

            return false;
        }

        public static clsDetainedLicense FindByLicenseID_NotReleased(int licenseID)
        {
            int detainID = -1;
            DateTime detainDate = DateTime.MinValue;
            decimal fineFees = -1;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime releaseDate = DateTime.MinValue;
            int releasedByUserID = -1;
            int releaseApplicationID = -1;

            if (clsDetainedLicenseDataAccess.GetNotReleasedDetainedLicenseByLicenseID(licenseID, ref detainID, ref detainDate,
                ref fineFees, ref createdByUserID, ref isReleased, ref releaseDate, ref releasedByUserID, ref releaseApplicationID))
            {
                return new clsDetainedLicense(detainID, licenseID, detainDate, fineFees, createdByUserID,
                    isReleased, releaseDate, releasedByUserID, releaseApplicationID);
            }

            return null;
        }

        public bool Release()
        {

            clsApplication app=new clsApplication();
            app.ApplicationPersonID=clsDriver.Find(clsLicense.Find(this.LicenseID).DriverID).PersonID;
            app.ApplicationDate = DateTime.Now;
            app.LastStatusDate = DateTime.Now;
            app.ApplicationTypeID = 5;
            app.ApplicationStatus = 1;
            app.PaidFees=clsApplicationType.Find(5).ApplicationFees;
            app.CreatedByUserID=clsGlobalSettings._LogedInUser.UserID;

            app.Save(); 

            this.IsReleased = true;
            this.ReleaseDate = DateTime.Now;
            this.ReleaseApplicationID = app.ApplicationID;
            this.ReleasedByUserID=clsGlobalSettings._LogedInUser.UserID ;

          return this.Save();

           
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicenseDataAccess.GetAllDetainedLicenses();
        }

    }
}
