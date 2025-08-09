using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DVLD_dataAccess;

namespace DVLD_businessLogic
{
    public class clsApplicationType
    {

        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }


        private clsApplicationType(int ApplicationTypeID,string ApplicationTypeTitle, decimal ApplicationFees) 
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;

        }


        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypesDataAccess.GetAllApplicationTypes();  
        }

        public static clsApplicationType Find(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            decimal ApplicationFees = 0;

            if (clsApplicationTypesDataAccess.GetApplicationTypeByID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            else return null;
        }

        public bool Update()
        {

            return clsApplicationTypesDataAccess.UpdateApplicationType(this.ApplicationTypeID,this.ApplicationTypeTitle, this.ApplicationFees);
        }

    }
}
