using DVLD_dataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_businessLogic
{
    public class clsInternationalLicense
    {
        private enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsInternationalLicense()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.MinValue;
            ExpirationDate = DateTime.MinValue;
            IsActive = true;
            CreatedByUserID = -1;
            _Mode = enMode.AddNew;
        }

        private clsInternationalLicense(int applicationID, int driverID, int issuedUsingLocalLicenseID,
                                        DateTime issueDate, DateTime expirationDate,
                                        bool isActive, int createdByUserID)
        {
            ApplicationID = applicationID;
            DriverID = driverID;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
            _Mode = enMode.Update;
        }

        private bool _AddNewLicense()
        {
            this.LicenseID = clsInternationalLicenseDataAccess.AddNewLicense(
                this.ApplicationID,
                this.DriverID,
                this.IssuedUsingLocalLicenseID,
                this.IssueDate,
                this.ExpirationDate,
                this.IsActive,
                this.CreatedByUserID
            );

            return this.LicenseID != -1;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    // No update logic implemented yet
                    return false;
            }
            return false;
        }

        public static bool IsActiveLicenseExists(int driverID)
        {
            return clsInternationalLicenseDataAccess.isActiveLicenseExists(driverID);
        }

        public static clsInternationalLicense FindActiveByDriverID(int driverID)
        {
            int licenseID = -1;
            int applicationID = -1;
            int issuedUsingLocalLicenseID = -1;
            DateTime issueDate = DateTime.MinValue;
            DateTime expirationDate = DateTime.MinValue;
            bool isActive = false;
            int createdByUserID = -1;

            if (clsInternationalLicenseDataAccess.GetActiveLicenseByDriverID(driverID, ref licenseID, ref applicationID,
                ref issuedUsingLocalLicenseID, ref issueDate, ref expirationDate, ref isActive, ref createdByUserID))
            {
                clsInternationalLicense license = new clsInternationalLicense(
                    applicationID, driverID, issuedUsingLocalLicenseID,
                    issueDate, expirationDate, isActive, createdByUserID);

                license.LicenseID = licenseID;
                return license;
            }

            return null;
        }

        public static clsInternationalLicense FindByLicenseID(int licenseID)
        {
            int applicationID = -1;
            int driverID = -1;
            int issuedUsingLocalLicenseID = -1;
            DateTime issueDate = DateTime.MinValue;
            DateTime expirationDate = DateTime.MinValue;
            bool isActive = false;
            int createdByUserID = -1;

            if (clsInternationalLicenseDataAccess.GetLicenseByLicenseID(licenseID, ref applicationID, ref driverID,
                ref issuedUsingLocalLicenseID, ref issueDate, ref expirationDate, ref isActive, ref createdByUserID))
            {
                clsInternationalLicense license = new clsInternationalLicense(applicationID, driverID, issuedUsingLocalLicenseID,
                    issueDate, expirationDate, isActive, createdByUserID);

                license.LicenseID = licenseID;
                return license;
            }

            return null;
        }

        public static DataTable GetLicenses(int licenseID)
        {
            return clsInternationalLicenseDataAccess.GetLicenses(licenseID);    
        }

        public static DataTable GetAllLicenses()
        {
            return clsInternationalLicenseDataAccess.GetAllLicenses();
        }

    }

}
