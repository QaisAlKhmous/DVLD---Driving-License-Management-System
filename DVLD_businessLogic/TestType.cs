using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DVLD_dataAccess;

namespace DVLD_businessLogic
{
    public class clsTestType
    {


        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }
        private clsTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees) 
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
        
        }


        public static DataTable GetAllTestTypes()
        {
            return clsTestTypeDataAccess.GetAllTestTypes(); 
        }

        public static clsTestType Find(int TestTypeID)
        {
            string TestTypeTitle = "", TestTypeDescription = "";
            decimal TestTypeFees = 0;

            if (clsTestTypeDataAccess.GetTestType(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
            {
                return new clsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);

            }
            else
                return null;
        }


        public bool Update()
        {
            return clsTestTypeDataAccess.UpdateTestType(this.TestTypeID,this.TestTypeTitle, this.TestTypeDescription,this.TestTypeFees);
        }
    }
}
