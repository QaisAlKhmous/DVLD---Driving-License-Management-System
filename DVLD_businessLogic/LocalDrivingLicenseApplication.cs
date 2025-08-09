using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_dataAccess;
using System.Data;

namespace DVLD_businessLogic
{
    public class clsLocalDrivingLicenseApplication
    {

        enum enMode { AddNew=1,Update=2}
        private enMode _Mode;
        public int LocalDrivingLicenseApplicationID {  get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID {  get; set; }  


        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;

            _Mode=enMode.Update;

        }

        public clsLocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID=-1;
            ApplicationID=-1;
            LicenseClassID=-1;

            _Mode=enMode.AddNew;
        }

        private bool _AddNewLDLApp()
        {
            this.LocalDrivingLicenseApplicationID=clsLocalDrivingLicenseApplicationDataAccess.AddLocalDrivingLicenseApplication(this.ApplicationID,this.LicenseClassID);

            return this.LocalDrivingLicenseApplicationID != -1;
        }


        private bool _UpdateLDLApp()
        {
            return clsLocalDrivingLicenseApplicationDataAccess.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
        }

        public static clsLocalDrivingLicenseApplication Find(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1,LicenseClassID=-1;

            if (clsLocalDrivingLicenseApplicationDataAccess.GetLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
            {
                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            }
            else return null;
        }


        public static DataTable GetAllLocalDrivingLiocenseApplications()
        {
            return clsLocalDrivingLicenseApplicationDataAccess.GetAllLocalDrivingLicenseApplications(); 
        }

        public static bool DoesPersonHaveAppForLicense(int PersonID,int LicenseClassID, int ApplicationStatus)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.doesPersonHaveAppsForLicense(PersonID, LicenseClassID, ApplicationStatus);  
        }

        public bool Save()
        {


            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLDLApp())
                    {

                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLDLApp();

            }


            return false;
        }


        public static bool DeleteApplication(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.DeleteApplication(LocalDrivingLicenseApplicationID);
        }

    }
}
