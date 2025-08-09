using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_dataAccess
{
    public class clsInternationalLicenseDataAccess
    {

        public static bool isActiveLicenseExists(int DriverID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM InternationalLicenses WHERE DriverID = @DriverID and IsActive=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
     

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

        public static int AddNewLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate,bool IsActive, int CreatedByUserID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, " +
               "IsActive, CreatedByUserID) " +
               "VALUES (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, " +
               "@IsActive, @CreatedByUserID); " +
               "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID); // <-- Add this
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return LicenseID;


        }


        public static bool GetActiveLicenseByDriverID(int driverID, ref int licenseID, ref int applicationID,
    ref int issuedUsingLocalLicenseID, ref DateTime issueDate, ref DateTime expirationDate,
    ref bool isActive, ref int createdByUserID)
        {
            bool found = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT TOP 1 * FROM InternationalLicenses " +
                           "WHERE DriverID = @DriverID AND IsActive = 1 ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", driverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    licenseID = (int)reader["InternationalLicenseID"];
                    applicationID = (int)reader["ApplicationID"];
                    issuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    isActive = (bool)reader["IsActive"];
                    createdByUserID = (int)reader["CreatedByUserID"];

                    found = true;
                }

                reader.Close();
            }
            catch
            {
                // optional: log or handle
            }
            finally
            {
                connection.Close();
            }

            return found;
        }


        public static bool GetLicenseByLicenseID(int licenseID, ref int applicationID, ref int driverID,
    ref int issuedUsingLocalLicenseID, ref DateTime issueDate, ref DateTime expirationDate,
    ref bool isActive, ref int createdByUserID)
        {
            bool found = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    applicationID = (int)reader["ApplicationID"];
                    driverID = (int)reader["DriverID"];
                    issuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    isActive = (bool)reader["IsActive"];
                    createdByUserID = (int)reader["CreatedByUserID"];

                    found = true;
                }

                reader.Close();
            }
            catch
            {
                // Optional: log error
            }
            finally
            {
                connection.Close();
            }

            return found;
        }


        public static DataTable GetLicenses(int DriverID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query =
             "SELECT InternationalLicenseID, ApplicationID, " +
             "IssueDate, ExpirationDate, IsActive " +
             "FROM InternationalLicenses " +
             "WHERE DriverID = @DriverID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

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
                Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static DataTable GetAllLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query =
             "SELECT InternationalLicenseID, ApplicationID,DriverID ,IssuedUsingLocalLicenseID,"+
             "IssueDate, ExpirationDate, IsActive " +
             "FROM InternationalLicenses ";


            SqlCommand command = new SqlCommand(query, connection);
           

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
                Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


    }
}
