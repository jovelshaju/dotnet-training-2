using System;
using System.Data;
using System.Data.SqlClient;

// Data Adapter
namespace IntroToADO
{
    public class Demo2
    {
        static SqlConnection sqlConnection;
        static SqlCommand sqlCommand;
        static SqlDataAdapter sqlDataAdapter;
        static DataSet ds;
        static string connectionString = "server=IND385;database=Day12DB;trusted_connection=true;";
        public static void Main2(string[] args)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand("SELECT * FROM Employee", sqlConnection);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            ds = new DataSet();
            sqlConnection.Open();
            sqlDataAdapter.Fill(ds);
            Console.WriteLine("Employees");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Console.WriteLine(ds.Tables[0].Rows[i]["EId"]);
                Console.WriteLine(ds.Tables[0].Rows[i]["EFName"]);
                Console.WriteLine(ds.Tables[0].Rows[i]["ELName"]);

            }
            sqlConnection.Close();
        }
    }
}