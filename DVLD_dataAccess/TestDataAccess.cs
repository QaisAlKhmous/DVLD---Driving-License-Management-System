using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_dataAccess
{
    public class clsTestDataAccess
    {


        static public int AddNewTest(int TestAppointmentID,bool TestResult,string Notes,int CreatedByUserID)
        {

            int TestID = -1;

            SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID) " +
               "VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID); " +
               "SELECT SCOPE_IDENTITY();";


            SqlCommand command =new SqlCommand(query, connection);

           
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result=command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestID = insertedID;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {

                connection.Close();
            }

            return TestID;

        }

        static public bool isTestExists(int TestAppointmentID, bool TestResult)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Tests WHERE TestAppointmentID=@TestAppointmentID and TestResult=@TestResult";

            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);

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
