using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_dataAccess
{
    public class clsLicenseDataAccess
    {

        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes,
            decimal PaidFees, bool IsActive,int IssueReason,int CreatedByUserID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO Licenses (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, " +
               "PaidFees, IsActive, IssueReason, CreatedByUserID) " +
               "VALUES (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, " +
               "@PaidFees, @IsActive, @IssueReason, @CreatedByUserID); " +
               "SELECT SCOPE_IDENTITY();";

            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result=command.ExecuteScalar();

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

        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes,
            decimal PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "UPDATE Licenses SET ApplicationID=@ApplicationID,DriverID=@DriverID, LicenseClass=@LicenseClass," +
                "IssueDate=@IssueDate,ExpirationDate=@ExpirationDate,Notes=@Notes,PaidFees=@PaidFees,IsActive=@IsActive,IssueReason=@IssueReason," +
                "CreatedByUserID=@CreatedByUserID WHERE LicenseID=@LicenseID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                 RowsAffected = command.ExecuteNonQuery();

                

            }
            catch(Exception ex) 

            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();
            }

            return RowsAffected>0;


        }

        public static bool GetLicenseByID(int licenseID,ref int applicationID, ref int driverID, ref int licenseClass,
                                  ref DateTime issueDate, ref DateTime expirationDate, ref string notes,
                                  ref decimal paidFees, ref bool isActive, ref int issueReason, ref int createdByUserID)
        {
            bool found = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";
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
                    licenseClass = (int)reader["LicenseClass"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";

                    paidFees = (decimal)reader["PaidFees"];
                    isActive = (bool)reader["IsActive"];
                    issueReason = (byte)reader["IssueReason"];
                    createdByUserID = (int)reader["CreatedByUserID"];

                    found = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Optional: log the exception
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return found;
        }

        public static bool GetLicenseByApplicationID(int applicationID, ref int licenseID, ref int driverID, ref int licenseClass,
                                             ref DateTime issueDate, ref DateTime expirationDate, ref string notes,
                                             ref decimal paidFees, ref bool isActive, ref int issueReason, ref int createdByUserID)
        {
            bool found = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT TOP 1 * FROM Licenses WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    licenseID = (int)reader["LicenseID"];
                    driverID = (int)reader["DriverID"];
                    licenseClass = (int)reader["LicenseClass"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                    paidFees = (decimal)reader["PaidFees"];
                    isActive = (bool)reader["IsActive"];
                    issueReason = (byte)reader["IssueReason"];
                    createdByUserID = (int)reader["CreatedByUserID"];

                    found = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Optional: Log or handle exception
            }
            finally
            {
                connection.Close();
            }

            return found;
        }

        public static bool isLicenseExistsByDriverID(int DriverID, int LicenseClass)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Licenses WHERE DriverID = @DriverID and LicenseClass=@LicenseClass";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);

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


        public static DataTable GetLicenses(int DriverID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query =
             "SELECT Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, " +
             "Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive " +
             "FROM Licenses " +
             "INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID " +
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
                //Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

    }
}
