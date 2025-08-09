using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_dataAccess
{
    public class clsTestAppoinmentsDataAccess
    {



        public static bool GetTestAppointmentByID(int TestAppointmentID,ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate,
           ref decimal PaidFees, ref int CreatedByUser, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;


                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    CreatedByUser = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];

                    if (reader["RetakeTestApplicationID"] != DBNull.Value)
                    {
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                    }
                    else
                    {
                        RetakeTestApplicationID = -1;
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
                
               

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static DataTable GetTestAppointments(int TestTypeID,int LocalDrivingLicenseApplicationID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT TestAppointmentID AS AppointmentID,AppointmentDate,PaidFees,IsLocked FROM TestAppointments WHERE" +
                " TestTypeID=@TestTypeID AND LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


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





        public static bool isAppointmentExists(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID=@TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
           

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

        public static bool isActiveAppointmentExists(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID=@TestTypeID and IsLocked=0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


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

        public static int AddNewTestAppointment(int TestAppointmentID,int TestTypeID,int LocalDrivingLicenseApplicationID,DateTime AppointmentDate,
            decimal PaidFees,int CreatedByUser,bool IsLocked,int RetakeTestApplicationID)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO TestAppointments VALUES (@TestTypeID,@LocalDrivingLicenseApplicationID 
                          ,@AppointmentDate,@PaidFees,@CreatedByUser,@IsLocked,
                           @RetakeTestApplicationID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUser", CreatedByUser);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if(RetakeTestApplicationID!=-1)
            command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            else
                command.Parameters.AddWithValue("@RetakeTestApplicationID", System.DBNull.Value);


            

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



        public static bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate,
            decimal PaidFees, int CreatedByUser, bool IsLocked, int RetakeTestApplicationID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE TestAppointments set TestTypeID= @TestTypeID,LocalDrivingLicenseApplicationID= @LocalDrivingLicenseApplicationID ,
                          AppointmentDate= @AppointmentDate,PaidFees = @PaidFees,CreatedByUserID=@CreatedByUserID,IsLocked=@IsLocked,
                           RetakeTestApplicationID=@RetakeTestApplicationID
                           WHERE TestAppointmentID=@TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);



            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUser);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID != -1)
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            else
                command.Parameters.AddWithValue("@RetakeTestApplicationID", System.DBNull.Value);

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



    }
}
