using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_dataAccess;

namespace DVLD_businessLogic
{
    public class clsLicenseClass
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }


        private clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength,
             decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }


        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassDataAccess.GetAllLicenseClasses();
        }


        public static clsLicenseClass Find(int LicenseClassID)
        {
            string ClassName = "", ClassDescription = "";
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
            decimal ClassFees = 0;

            if (clsLicenseClassDataAccess.GetLicenseClass(LicenseClassID, ref ClassName, ref ClassName, ref MinimumAllowedAge,
                ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }

            else return null;

        }
    }
}
