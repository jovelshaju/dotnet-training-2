using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace IntroToADO
{
    class DataInsert
    {
        static SqlConnection connection;
        static SqlCommand command;
        static string connectionString = "server=IND365;database=Day12DB;trusted_connection=true;";
        static void Main2(string[] args)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                // command = new SqlCommand("SELECT * FROM Employee", connection);
                command = new SqlCommand("insert into Products values (@id,@name,@price,@mfgDate,@expDate)", connection);

                Console.Write("Enter ID: ");
                command.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));
                Console.Write("Enter Name: ");
                command.Parameters.AddWithValue("@name", Console.ReadLine());
                Console.Write("Enter Price: ");
                command.Parameters.AddWithValue("@price", double.Parse(Console.ReadLine()));
                Console.Write("Enter Mfg Date: ");
                command.Parameters.AddWithValue("@mfgDate", DateTime.Parse(Console.ReadLine()));
                Console.Write("Enter Exp date: ");
                command.Parameters.AddWithValue("@expDate", DateTime.Parse(Console.ReadLine()));
                
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                Console.WriteLine("Record inserted");
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }   
}
