using System;
using System.Data;
using System.Data.SqlClient;


namespace IntroToADO
{

    class SearchData
    {
        static SqlConnection connection;
        static SqlDataReader reader;
        static SqlDataAdapter sqlDataAdapter;
        static SqlCommand command;
        static DataSet ds;
        static string connectionString = "server=IND365;database=Day12DB;trusted_connection=true;";

        // Using Data Reader
        //public static void Main()
        //{
        //    try
        //    {
        //        connection = new SqlConnection(connectionString);
        //        command = new SqlCommand("select * from Products where PId=@id", connection);

        //        Console.Write("Enter ID: ");
        //        command.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));


        //        connection.Open();
        //        reader = command.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            Console.WriteLine("Data Found");
        //            while (reader.Read())
        //            {
        //                Console.WriteLine($"ID : {reader["PId"]}");
        //                Console.WriteLine($"Name : {reader["PName"]}");
        //                Console.WriteLine($"Price : {reader["PPrice"]}");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Data not found");
        //        }
        //    }
        //    catch (SqlException sqlEx)
        //    {
        //        Console.WriteLine(sqlEx.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();

        //    }
        //    Console.ReadKey();
        //}

        //Using Data Adapter
        public static void Main()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand("select * from Products where PName=@name", connection);

                Console.Write("Enter Name: ");
                command.Parameters.AddWithValue("@name", Console.ReadLine());

                sqlDataAdapter = new SqlDataAdapter(command);
                ds = new DataSet();

                connection.Open();
                sqlDataAdapter.Fill(ds);
                if (ds.Tables.Count>0)
                {
                    Console.WriteLine("Data Found");
                    int i = 0;
                    while (i < ds.Tables[0].Rows.Count)
                    {
                        Console.WriteLine($"ID : {ds.Tables[0].Rows[i]["PId"]}");
                        Console.WriteLine($"Name : {ds.Tables[0].Rows[i]["PName"]}");
                        Console.WriteLine($"Price : {ds.Tables[0].Rows[i]["PPrice"]}");
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("Data not found");
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();

            }
            Console.ReadKey();
        }
    }
}
