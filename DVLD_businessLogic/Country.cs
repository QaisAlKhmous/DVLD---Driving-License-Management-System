using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_dataAccess;

namespace DVLD_businessLogic
{
    public class clsCountry
    {

        public int CountryID { get; set; }
        public string CountryName { get; set; }

       private clsCountry(int CountryID,string CountryName) 
        {

            this.CountryID = CountryID; 
            this.CountryName = CountryName;
        }

        public static int GetCountryIDFromName(string CountryName)
        {
            return clsCountryDataAccess.GetCountryIDFromName(CountryName);    
        }

        public static clsCountry Find(int CountryID)
        {
            string CountryName = "";


            if(clsCountryDataAccess.GetCountry(CountryID,ref CountryName))
            {
                return new clsCountry(CountryID,CountryName);
            }
            else
            { return null; }
        }

        public static clsCountry Find(string CountryName)
        {
            int CountryID = 0;

            if(clsCountryDataAccess.GetCountry(ref CountryID,CountryName))
            {
                return new clsCountry(CountryID, CountryName);  
            }
            else { return null; }
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryDataAccess.GetAllCountries(); 
        }
    }
}
