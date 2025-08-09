using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_dataAccess
{
    public class clsDetainedLicenseDataAccess
    {

        public static bool isDetainedLicenseExistsByLicensID(int LicenseID)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM DetainedLicenses WHERE LicenseID = @LicenseID and IsReleased=0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

        public static bool GetDetainedLicenseByID(int detainID, ref int licenseID, ref DateTime detainDate,
    ref decimal fineFees, ref int createdByUserID, ref bool isReleased, ref DateTime releaseDate,
    ref int releasedByUserID, ref int releaseApplicationID)
        {
            bool found = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", detainID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    licenseID = (int)reader["LicenseID"];
                    detainDate = (DateTime)reader["DetainDate"];
                    fineFees = (decimal)reader["FineFees"];
                    createdByUserID = (int)reader["CreatedByUserID"];
                    isReleased = (bool)reader["IsReleased"];



                    if (reader["ReleaseDate"] != DBNull.Value)
                    {
                        releaseDate = (DateTime)reader["ReleaseDate"];
                    }
                    else
                    {
                        releaseDate = DateTime.MinValue;
                    }

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                    {
                        releasedByUserID = (int)reader["ReleasedByUserID"];
                    }
                    else
                    {
                        releasedByUserID = -1;
                    }

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                    {
                        releaseApplicationID = (int)reader["ReleaseApplicationID"];
                    }
                    else
                    {
                        releaseApplicationID = -1;
                    }

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



        public static int AddNewDetainedLicense(int licenseID, DateTime detainDate, decimal fineFees,
    int createdByUserID, bool isReleased, DateTime releaseDate,
    int releasedByUserID, int releaseApplicationID)
        {
            int detainID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO DetainedLicenses
                     (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                     VALUES
                     (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID);
                     SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);
            command.Parameters.AddWithValue("@DetainDate", detainDate);
            command.Parameters.AddWithValue("@FineFees", fineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            command.Parameters.AddWithValue("@IsReleased", isReleased);
       
            
           

            if (releaseDate != DateTime.MinValue && releaseDate != null)
                command.Parameters.AddWithValue("@ReleaseDate", releaseDate);
            else
                command.Parameters.AddWithValue("@ReleaseDate", System.DBNull.Value);

            if (releasedByUserID != -1)
                command.Parameters.AddWithValue("@ReleasedByUserID", releasedByUserID);
            else
                command.Parameters.AddWithValue("@ReleasedByUserID", System.DBNull.Value);

            if (releaseApplicationID != -1)
                command.Parameters.AddWithValue("@ReleaseApplicationID", releaseApplicationID);
            else
                command.Parameters.AddWithValue("@ReleaseApplicationID", System.DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    detainID = insertedID;
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return detainID;
        }


        public static bool UpdateDetainedLicense(int detainID, int licenseID, DateTime detainDate, decimal fineFees,
    int createdByUserID, bool isReleased, DateTime releaseDate,
    int releasedByUserID, int releaseApplicationID)
        {
            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE DetainedLicenses SET
                        LicenseID = @LicenseID,
                        DetainDate = @DetainDate,
                        FineFees = @FineFees,
                        CreatedByUserID = @CreatedByUserID,
                        IsReleased = @IsReleased,
                        ReleaseDate = @ReleaseDate,
                        ReleasedByUserID = @ReleasedByUserID,
                        ReleaseApplicationID = @ReleaseApplicationID
                     WHERE DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", detainID);
            command.Parameters.AddWithValue("@LicenseID", licenseID);
            command.Parameters.AddWithValue("@DetainDate", detainDate);
            command.Parameters.AddWithValue("@FineFees", fineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            command.Parameters.AddWithValue("@IsReleased", isReleased);




            if (releaseDate != DateTime.MinValue && releaseDate != null)
                command.Parameters.AddWithValue("@ReleaseDate", releaseDate);
            else
                command.Parameters.AddWithValue("@ReleaseDate", System.DBNull.Value);

            if (releasedByUserID != -1)
                command.Parameters.AddWithValue("@ReleasedByUserID", releasedByUserID);
            else
                command.Parameters.AddWithValue("@ReleasedByUserID", System.DBNull.Value);

            if (releaseApplicationID != -1)
                command.Parameters.AddWithValue("@ReleaseApplicationID", releaseApplicationID);
            else
                command.Parameters.AddWithValue("@ReleaseApplicationID", System.DBNull.Value);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isUpdated = (rowsAffected > 0);
            }
            catch(Exception ex)
            {
                    Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isUpdated;
        }

        public static bool GetNotReleasedDetainedLicenseByLicenseID(int licenseID, ref int detainID, ref DateTime detainDate,
    ref decimal fineFees, ref int createdByUserID, ref bool isReleased, ref DateTime releaseDate,
    ref int releasedByUserID, ref int releaseApplicationID)
        {
            bool found = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT TOP 1 * FROM DetainedLicenses 
                     WHERE LicenseID = @LicenseID AND IsReleased = 0 
                     ORDER BY DetainDate DESC";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    detainID = (int)reader["DetainID"];
                    detainDate = (DateTime)reader["DetainDate"];
                    fineFees = (decimal)reader["FineFees"];
                    createdByUserID = (int)reader["CreatedByUserID"];
                    isReleased = (bool)reader["IsReleased"];



                    if (reader["ReleaseDate"] != DBNull.Value)
                    {
                        releaseDate = (DateTime)reader["ReleaseDate"];
                    }
                    else
                    {
                        releaseDate = DateTime.MinValue;
                    }

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                    {
                        releasedByUserID = (int)reader["ReleasedByUserID"];
                    }
                    else
                    {
                        releasedByUserID = -1;
                    }

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                    {
                        releaseApplicationID = (int)reader["ReleaseApplicationID"];
                    }
                    else
                    {
                        releaseApplicationID = -1;
                    }

                    found = true;
                }

                reader.Close();
            }
            catch
            {
                // Optional: log
            }
            finally
            {
                connection.Close();
            }

            return found;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicenses";
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
