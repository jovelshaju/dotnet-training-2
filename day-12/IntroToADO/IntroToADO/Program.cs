using System;
using System.Data;
using System.Data.SqlClient;

namespace IntroToADO
{
    class Program
    {
        static SqlConnection connection;
        static SqlCommand command;
        static SqlDataReader reader;
        static string connectionString = "server=IND365;database=OurExcercise7DB;trusted_connection=true;";
        static void Main2(string[] args)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                // command = new SqlCommand("SELECT * FROM Employee", connection);
                command = new SqlCommand("SELECT TOP 3 PId,PName,PPrice,MfgDate,ExpDate FROM Products order by PName desc", connection);
                connection.Open();
                reader = command.ExecuteReader(); //
                while (reader.Read())
                {
                    Console.WriteLine($"ID : {reader["PId"]}");
                    //Console.WriteLine($"Name : {reader["EFName"]} {reader["ELName"]}");
                    Console.WriteLine($"Name : {reader["PName"]}");
                    Console.WriteLine($"Price : {reader["PPrice"]}");
                    Console.WriteLine($"MfgDate : {reader["MfgDate"]}");
                    Console.WriteLine($"ExpDate : {reader["ExpDate"]}");



                }
                connection.Close();
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
