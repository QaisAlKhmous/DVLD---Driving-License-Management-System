using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_dataAccess
{
    public class clsDriverDataAccess
    {
        public static int AddNewDriver(int personID, int createdByUserID, DateTime createdDate)
        {
            int driverID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate) " +
                           "VALUES (@PersonID, @CreatedByUserID, @CreatedDate); " +
                           "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            command.Parameters.AddWithValue("@CreatedDate", createdDate);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    driverID = insertedID;
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception if needed
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return driverID;
        }

        public static bool GetDriverByID(int driverID, ref int personID, ref int createdByUserID, ref DateTime createdDate)
        {
            bool found = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT PersonID, CreatedByUserID, CreatedDate FROM Drivers WHERE DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", driverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    personID = (int)reader["PersonID"];
                    createdByUserID = (int)reader["CreatedByUserID"];
                    createdDate = (DateTime)reader["CreatedDate"];

                    found = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle or log exception if needed
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return found;
        }

        public static bool GetDriverByPersonID(int personID, ref int driverID, ref int createdByUserID, ref DateTime createdDate)
        {
            bool found = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Drivers WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    driverID = (int)reader["DriverID"];
                    createdByUserID = (int)reader["CreatedByUserID"];
                    createdDate = (DateTime)reader["CreatedDate"];

                    found = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Optional: Log or handle the exception
            }
            finally
            {
                connection.Close();
            }

            return found;
        }



        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Drivers_View";
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
