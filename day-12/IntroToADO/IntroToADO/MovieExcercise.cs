using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToADO
{
    class MovieExcercise
    {
        static SqlConnection connection;
        static SqlCommand command;
        static string connectionString = "server=IND365;database=OurExcercise7DB;trusted_connection=true;";
        static void Main2(string[] args)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand("insert into movies values (@id,@name,@starcast,@producer)", connection);

                Console.Write("Enter Moive ID: ");
                command.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));
                Console.Write("Enter Movie Name: ");
                command.Parameters.AddWithValue("@name", Console.ReadLine());
                Console.Write("Enter Star Cast: ");
                command.Parameters.AddWithValue("@starcast", Console.ReadLine());
                Console.Write("Enter Producer: ");
                command.Parameters.AddWithValue("@producer", Console.ReadLine());

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                Console.WriteLine("Record inserted");
            }
            catch (SqlException sqlEx)
            {
                switch(sqlEx.Number)
                {
                    
                    case 2601: Console.WriteLine("Enter a unique movie Name");
                        break;
                    case 2627:
                        Console.WriteLine("Enter a unique ID");
                        break;
                    default: Console.WriteLine("Server Error");
                        break;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
