using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_dataAccess
{
    public class clsApplicationTypesDataAccess
    {



        private static DataTable _GetApplicationTypes(SqlConnection connection, SqlCommand command)
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

        public static DataTable GetAllApplicationTypes()
        {
            
            


                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
                string query = "SELECT * FROM ApplicationTypes";
                SqlCommand command = new SqlCommand(query, connection);

                return _GetApplicationTypes(connection, command);
           
        }

        public static bool UpdateApplicationType(int ApplicationTypeID,string ApplicationTypeTitle,decimal ApplicationFees)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE ApplicationTypes set ApplicationTypeTitle=@ApplicationTypeTitle,
                              ApplicationFees=@ApplicationFees
                           WHERE ApplicationTypeID=@ApplicationTypeID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            
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





        public static bool GetApplicationTypeByID(int ApplicationTypeID,ref string ApplicationTypeTitle,ref decimal ApplicationFees)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = (decimal)reader["ApplicationFees"];
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





    }
}
