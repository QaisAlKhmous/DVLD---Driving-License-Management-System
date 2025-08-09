using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DVLD_dataAccess;

namespace DVLD_businessLogic
{
    public class clsUser
    {

        enum enMode { AddNew=1, Update=2 }
        private enMode _Mode;

        public clsPerson Person;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }


   

        private clsUser(int UserID,int PersonID,string UserName,string Password,bool isActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.isActive= isActive;
            Person = clsPerson.FindByID(PersonID);
            _Mode = enMode.Update;
        }
        public clsUser()
        {
            this.UserID=-1;
            this.PersonID=-1;
            this.UserName = "";
            this.Password = "";
            this.isActive= true;
            _Mode= enMode.AddNew;
        }



        private bool _AddNewUser()
        {
            this.UserID =clsUserDataAccess.AddNewUser(this.PersonID,this.UserName,clsSecurity.ComputeHash(this.Password),this.isActive);

            return UserID != -1;
        }

        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdatePerson(this.UserID,this.PersonID,this.UserName, clsSecurity.ComputeHash(this.Password), this.isActive);
        }



        public static clsUser Find(int UserID)
        {
            int PersonID = 0;
            string UserName = "", Password = "";
            bool IsActive = false;  

            if(clsUserDataAccess.GetUserByID(UserID,ref PersonID,ref UserName,ref Password,ref IsActive))
            {
                return new clsUser(UserID,PersonID,UserName,Password,IsActive);
            }
            else return null;
        }

        public static clsUser Find(string UserName)
        {
            int PersonID = -1,UserID=-1;
            string  Password = "";
            bool IsActive = false;

            if (clsUserDataAccess.GetUserByUserName(ref UserID, ref PersonID, UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else return null;
        }



        public static bool isUserExists(string Username,string Password)
        {
            return clsUserDataAccess.isUserExists(Username, Password);
        }

        public static bool isUserActive(string Username)
        {
            return clsUserDataAccess.isUserActive(Username);
        }


        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }


        public bool Save()
        {


            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }


            return false;
        }




        public static bool DeleteUser(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);
        }

        public bool CheckPassword(string password)
        {
            return clsSecurity.ComputeHash(password)==this.Password;
        }

    }
}
