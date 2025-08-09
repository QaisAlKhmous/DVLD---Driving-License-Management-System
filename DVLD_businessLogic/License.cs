using DVLD_dataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_businessLogic
{
    public class clsLicense
    {
        private enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public clsLicense()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClass = -1;
            IssueDate = DateTime.MinValue;
            ExpirationDate = DateTime.MinValue;
            Notes = "";
            PaidFees = -1;
            IsActive = true;
            IssueReason = -1;
            CreatedByUserID = -1;
            _Mode = enMode.AddNew;
        }

        private clsLicense(int licenseID,int applicationID, int driverID, int licenseClass, DateTime issueDate, DateTime expirationDate,
                           string notes, decimal paidFees, bool isActive, int issueReason, int createdByUserID)
        {
            _Mode = enMode.Update;
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClass = licenseClass;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
        }

        private bool _AddNewLicense()
        {
            this.LicenseID = clsLicenseDataAccess.AddNewLicense(
                this.ApplicationID,
                this.DriverID,
                this.LicenseClass,
                this.IssueDate,
                this.ExpirationDate,
                this.Notes,
                this.PaidFees,
                this.IsActive,
                this.IssueReason,
                this.CreatedByUserID);

            return this.LicenseID != -1;
        }

        private bool _UpdateLicense()
        {
           return clsLicenseDataAccess.UpdateLicense(
                this.LicenseID,
                this.ApplicationID,
                this.DriverID,
                this.LicenseClass,
                this.IssueDate,
                this.ExpirationDate,
                this.Notes,
                this.PaidFees,
                this.IsActive,
                this.IssueReason,
                this.CreatedByUserID);

       
        }



        public static clsLicense Find(int licenseID)
        {

            int applicationID = -1;
            int driverID = -1;
            int licenseClass = -1;
            DateTime issueDate = DateTime.MinValue;
            DateTime expirationDate = DateTime.MinValue;
            string notes = "";
            decimal paidFees = -1;
            bool isActive = false;
            int issueReason = -1;
            int createdByUserID = -1;

            if (clsLicenseDataAccess.GetLicenseByID(licenseID, ref applicationID, ref driverID, ref licenseClass, ref issueDate,
                                                    ref expirationDate, ref notes, ref paidFees, ref isActive,
                                                    ref issueReason, ref createdByUserID))
            {
                clsLicense license = new clsLicense(licenseID, applicationID, driverID, licenseClass, issueDate, expirationDate,
                                                    notes, paidFees, isActive, issueReason, createdByUserID);
                license.LicenseID = licenseID;
                return license;
            }
            else
            {
                return null;
            }
        }
        public static clsLicense FindByApplicationID(int applicationID)
        {
            int licenseID = -1;
            int driverID = -1;
            int licenseClass = -1;
            DateTime issueDate = DateTime.MinValue;
            DateTime expirationDate = DateTime.MinValue;
            string notes = "";
            decimal paidFees = -1;
            bool isActive = false;
            int issueReason = -1;
            int createdByUserID = -1;

            if (clsLicenseDataAccess.GetLicenseByApplicationID(applicationID, ref licenseID, ref driverID, ref licenseClass,
                                                               ref issueDate, ref expirationDate, ref notes, ref paidFees,
                                                               ref isActive, ref issueReason, ref createdByUserID))
            {
               return new clsLicense(licenseID, applicationID, driverID, licenseClass, issueDate, expirationDate,
                                                    notes, paidFees, isActive, issueReason, createdByUserID);
                
            }
            else
            {
                return null;
            }
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
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    
                    return _UpdateLicense();
            }

            return false;
        }


        public static bool isLicenseExistsByDriverID(int DriverID,int LicenseClass)
        {
            return clsLicenseDataAccess.isLicenseExistsByDriverID(DriverID, LicenseClass);
        }

        public static DataTable GetLicenses(int DriverID)
        {
            return clsLicenseDataAccess.GetLicenses(DriverID);  
        }

       public clsLicense ReplaceLicense(int ApplicationTypeID,string Notes)
        {
            clsApplication newApplication=new clsApplication();
           clsDriver driver=clsDriver.Find(this.DriverID);
            clsApplicationType apptype=clsApplicationType.Find(ApplicationTypeID);  
            newApplication.ApplicationPersonID=driver.PersonID;
            newApplication.ApplicationDate=DateTime.Now;
            newApplication.ApplicationTypeID = ApplicationTypeID;
            newApplication.ApplicationStatus = 1;
            newApplication.LastStatusDate = DateTime.Now;
            newApplication.PaidFees = apptype.ApplicationFees;
            newApplication.CreatedByUserID = clsGlobalSettings._LogedInUser.UserID;

            newApplication.Save();  


            clsLicense newLicense=new clsLicense();
           
            clsLicenseClass lclass=clsLicenseClass.Find(3);
            
            newLicense.ApplicationID=newApplication.ApplicationID;
            newLicense.DriverID=this.DriverID;
            newLicense.LicenseClass = this.LicenseClass;
            newLicense.IssueDate = DateTime.Now;
            newLicense.ExpirationDate = DateTime.Now;
            newLicense.Notes = Notes;
            newLicense.PaidFees=lclass.ClassFees;
            newLicense.IsActive = true;
            if(ApplicationTypeID==3)
            newLicense.IssueReason=4;
            else newLicense.IssueReason=3;
            
            newLicense.CreatedByUserID=clsGlobalSettings._LogedInUser.UserID;   

            newLicense.Save();

           this.IsActive=false;
            this.Save();

            return newLicense;


        }

        public clsDetainedLicense Detain(decimal FineFees)
        {
            clsDetainedLicense detainedLicense = new clsDetainedLicense();
            detainedLicense.LicenseID=this.LicenseID;
            detainedLicense.DetainDate=DateTime.Now;
            detainedLicense.FineFees=FineFees;
            detainedLicense.CreatedByUserID=clsGlobalSettings._LogedInUser.UserID ;
            detainedLicense.IsReleased = false;
             detainedLicense.Save();

            return detainedLicense;

        }
    }

}
