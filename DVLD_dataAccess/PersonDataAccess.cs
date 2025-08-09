using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD_dataAccess
{
    public class clsPersonDataAccess
    {


        private static DataTable _GetPeople(SqlConnection connection,SqlCommand command)
        {
            DataTable dt = new DataTable();
            try
            {
               
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);



                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
    
        public static bool GetPersonByID( ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref string NationalNo, ref string Email,
          ref string Phone, ref string Address, ref string ImagePath, ref byte Gender, ref int NationalityCountryID, ref DateTime DateOfBirth)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM People WHERE PersonID = @PersonID";
           SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    NationalNo = (string)reader["NationalNo"];
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }
                   
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    Gender = (byte)reader["Gender"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                  

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static bool GetPersonByNationalNo(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref string NationalNo, ref string Email,
         ref string Phone, ref string Address, ref string ImagePath, ref byte Gender, ref int NationalityCountryID, ref DateTime DateOfBirth)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    NationalNo = (string)reader["NationalNo"];
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    Gender = (byte)reader["Gender"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];


                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }





        public static DataTable FilterPeopleByPersonID(string PersonID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM PeopleView WHERE CAST(PersonID AS VARCHAR(20)) LIKE '' + @PersonID + '%'";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@PersonID", PersonID);

            return _GetPeople(connection, command);
        }


        public static DataTable FilterPeopleByFirstName(string FirstName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM PeopleView WHERE FirstName LIKE '' + @FirstName + '%'";
            SqlCommand command = new SqlCommand(query, connection);

      
            command.Parameters.AddWithValue("@FirstName", FirstName);

            return _GetPeople(connection, command);
        }

      

        public static DataTable FilterPeopleBySecondName(string SecondName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM PeopleView WHERE SecondName LIKE '' + @SecondName + '%'";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@SecondName", SecondName);

            return _GetPeople(connection, command);
        }

        public static DataTable FilterPeopleByThirdName(string ThirdName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM PeopleView WHERE ThirdName  LIKE '' + @ThirdName + '%'";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ThirdName", ThirdName);

            return _GetPeople(connection, command);
        }

        public static DataTable FilterPeopleByLastName(string LastName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM PeopleView WHERE LastName LIKE '' + @LastName + '%'";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@LastName", LastName);

            return _GetPeople(connection, command);
        }
        public static DataTable FilterPeopleByNationalNo(string NationalNo)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM PeopleView WHERE NationalNo  LIKE '' + @NationalNo + '%'";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            return _GetPeople(connection, command);
        }

        public static DataTable FilterPeopleByEmail(string Email)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM PeopleView WHERE Email LIKE '' + @Email + '%'";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@Email", Email);

            return _GetPeople(connection, command);
        }

        public static DataTable FilterPeopleByPhone(string Phone)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM PeopleView WHERE Phone LIKE '' + @Phone + '%'";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@Phone", Phone);

            return _GetPeople(connection, command);
        }

        public static DataTable FilterPeopleByGender(string Gender)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM PeopleView WHERE Gender LIKE '' + @Gender + '%'";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@Gender", Gender);

            return _GetPeople(connection, command);
        }

        public static DataTable FilterPeopleByNationality(string Nationality)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM PeopleView WHERE Nationality LIKE '' + @Nationality + '%'";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@Nationality", Nationality);

            return _GetPeople(connection, command);
        }



        public static DataTable GetAllPeople()
        {
           

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM PeopleView";
            SqlCommand command = new SqlCommand(query, connection);

            return _GetPeople(connection, command);
        }

      


        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName,
            string NationalNo, DateTime DateOfBirth, byte Gender, string Address, string Phone,
            string Email, int NationalityCountryID, string ImagePath)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO People VALUES (@NationalNo,@FirstName,@SecondName ,@ThirdName,@LastName,@DateOfBirth,@Gender,
                           @Address,@Phone, @Email,@NationalityCountryID,@ImagePath);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
         
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return PersonID;
        }



        public static bool UpdatePerson(int PersonID,string FirstName, string SecondName, string ThirdName, string LastName,
            string NationalNo, DateTime DateOfBirth, byte Gender, string Address, string Phone,
            string Email, int NationalityCountryID, string ImagePath)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE People set NationalNo = @NationalNo,FirstName= @FirstName,SecondName= @SecondName ,
                          ThirdName= @ThirdName,LastName = @LastName,DateOfBirth=@DateOfBirth,Gender=@Gender,
                           Address=@Address,Phone=@Phone,Email= @Email,NationalityCountryID=@NationalityCountryID ,ImagePath=@ImagePath
                           WHERE PersonID=@PersonID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool DeletePersonByID(int PersonID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete People 
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }


        public static bool isPersonExistsByID(int PersonID)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static bool isPersonExistsByNationalNo(string NationalNo)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
    }
}
