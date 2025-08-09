using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DVLD_dataAccess;

namespace DVLD_businessLogic
{
    /// <summary>
    /// This class represents a person
    /// </summary>
    public class clsPerson
    {
        enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string NationalNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }

        public clsPerson()
        {
            PersonID = -1;
            FirstName = "";
            LastName = "";
            ThirdName = "";
            LastName = "";
            NationalNo = "";
            DateOfBirth = DateTime.MinValue;
            Gender = 0;
            Address = "";
            Phone = "";
            Email = "";
            NationalityCountryID = -1;
            ImagePath = "";
            Mode = enMode.AddNew;
        }

        private clsPerson(int personID, string FirstName, string SecondName, string ThirdName, string LastName,
            string NationalNum, DateTime DateOfBirth, byte Gender, string Address, string Phone,
            string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = personID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.LastName = LastName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNum;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            this.Mode = enMode.Update;

        }

        /// <summary>
        /// This function add a new person to the people table
        /// </summary>
        /// <returns>is person added</returns>
        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonDataAccess.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo, this.DateOfBirth,
                this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

            return PersonID != -1;
        }

        private bool _UpdatePerson()
        {
            return clsPersonDataAccess.UpdatePerson(this.PersonID,this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo, this.DateOfBirth,
               this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }


        public static clsPerson FindByID(int PersonID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Email = "",
               Phone = "", Address = "", ImagePath = "";
            byte Gender = 2;
            int NationalityCountryID = -1;

            DateTime DateOfBirth = DateTime.Now;


            if (clsPersonDataAccess.GetPersonByID(ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref NationalNo, ref Email,
              ref Phone, ref Address, ref ImagePath, ref Gender, ref NationalityCountryID, ref DateOfBirth))

                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName,
             NationalNo, DateOfBirth, Gender, Address, Phone,
             Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="NationalNo">represents the national number for a person</param>
        /// <returns>the person object</returns>
        public static clsPerson FindByNationalNo(string NationalNo)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "",
               Phone = "", Address = "", ImagePath = "";
            byte Gender = 2;
            int NationalityCountryID = -1,PersonID=-1;

            DateTime DateOfBirth = DateTime.Now;


            if (clsPersonDataAccess.GetPersonByNationalNo(ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref NationalNo, ref Email,
              ref Phone, ref Address, ref ImagePath, ref Gender, ref NationalityCountryID, ref DateOfBirth))

                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName,
             NationalNo, DateOfBirth, Gender, Address, Phone,
             Email, NationalityCountryID, ImagePath);
            else
                return null;
        }




        public static DataTable FilterPeopleByPersonID(string PersonID)
        {
            return clsPersonDataAccess.FilterPeopleByPersonID(PersonID);
        }

        public static DataTable FilterPeopleByFirstName(string FirstName)
        {
            return clsPersonDataAccess.FilterPeopleByFirstName(FirstName);
        }
        public static DataTable FilterPeopleBySecondName(string SecondName)
        {
            return clsPersonDataAccess.FilterPeopleBySecondName(SecondName);
        }
        public static DataTable FilterPeopleByThirdName(string ThirdName)
        {
            return clsPersonDataAccess.FilterPeopleByThirdName(ThirdName);
        }
        public static DataTable FilterPeopleByLastName(string LastName)
        {
            return clsPersonDataAccess.FilterPeopleByLastName(LastName);
        }
        public static DataTable FilterPeopleByNationalNo(string NationalNo)
        {
            return clsPersonDataAccess.FilterPeopleByNationalNo(NationalNo);
        }
        public static DataTable FilterPeopleByEmail(string Email)
        {
            return clsPersonDataAccess.FilterPeopleByEmail(Email);
        }
        public static DataTable FilterPeopleByPhone(string Phone)
        {
            return clsPersonDataAccess.FilterPeopleByPhone(Phone);
        }
        public static DataTable FilterPeopleByGender(string Gender)
        {
            return clsPersonDataAccess.FilterPeopleByGender(Gender);
        }
        public static DataTable FilterPeopleByNationality(string Nationality)
        {
            return clsPersonDataAccess.FilterPeopleByNationality(Nationality);
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonDataAccess.GetAllPeople();
        }
  


        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }


            return false;
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonDataAccess.DeletePersonByID(PersonID);  
        }

        public static bool isPersonExistsByID(int personID)
        {
            return clsPersonDataAccess.isPersonExistsByID(personID);
        }


        public static bool isPersonExistsByNationalNo(string NationalNo)
        {
            return clsPersonDataAccess.isPersonExistsByNationalNo(NationalNo);
        }
    }
}
