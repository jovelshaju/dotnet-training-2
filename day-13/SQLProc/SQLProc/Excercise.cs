using System;
using System.Data.SqlClient;
using System.Data;


namespace SQLProc
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime MfgDate { get; set; }
        public DateTime ExpDate { get; set; }

        public Product()
        {
            Console.Write("Enter Product ID: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Product Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            Price = double.Parse(Console.ReadLine());
            Console.Write("Enter Product Mfg Date: ");
            MfgDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Product Exp Date: ");
            ExpDate = DateTime.Parse(Console.ReadLine());
        }
    }
    class Excercise
    {
        
        public static void InsertData(SqlConnection con, SqlCommand com)
        {
            com.CommandText = "usp_iProducts";

            Product prod = new Product();

            cmd.Parameters.AddWithValue("@id", prod.Id);
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@price", prod.Price);
            cmd.Parameters.AddWithValue("@mfgdate", prod.MfgDate);
            cmd.Parameters.AddWithValue("@expdate", prod.ExpDate);

            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Record Inserted");
            con.Close();
        }

        public static void UpdateData(SqlConnection con, SqlCommand com)
        {
            com.CommandText = "usp_uProducts";

            Product prod = new Product();

            cmd.Parameters.AddWithValue("@id", prod.Id);
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@price", prod.Price);
            cmd.Parameters.AddWithValue("@mfgdate", prod.MfgDate);
            cmd.Parameters.AddWithValue("@expdate", prod.ExpDate);

            con.Open();
            int nor = cmd.ExecuteNonQuery();
            if (nor > 0)
            {
                Console.WriteLine("Record Updated");

            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
            con.Close();
        }

        public static void DeleteData(SqlConnection con, SqlCommand com)
        {
            com.CommandText = "usp_dProducts";

            Console.Write("Enter Prodcut ID: ");
            int id = int.Parse(Console.ReadLine());

            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            int nor = cmd.ExecuteNonQuery();
            if (nor > 0)
            {
                Console.WriteLine("Record deleted");

            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
            con.Close();
        }

        public static void SearchByID(SqlConnection con, SqlCommand com)
        {
            SqlDataReader reader;

            com.CommandText = "usp_sByIdProducts";

            Console.Write("Enter Prodcut ID: ");
            int id = int.Parse(Console.ReadLine());

            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Console.WriteLine("Data Found");
                while (reader.Read())
                {
                    Console.WriteLine($"ID : {reader["PId"]}");
                    Console.WriteLine($"Name : {reader["PName"]}");
                    Console.WriteLine($"Price : {reader["PPrice"]}");
                }
            }
            else
            {
                Console.WriteLine("Data not found");
            }
            con.Close();
        }

        static SqlConnection con;
        static SqlCommand cmd;
        static string connectionString = "server=IND365;database=Day13DB;trusted_connection=true;";

        static void Main(string[] args)
        {

            bool flag = true;

            try
            {
                

                while (flag)
                {
                    con = new SqlConnection(connectionString);
                    cmd = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        Connection = con
                    };

                    Console.WriteLine("\nChoose an option:");
                    Console.WriteLine("=================");
                    Console.WriteLine(" 1.Insert Data \n 2.Update Data \n 3.Delete Data \n 4.Search By Id \n 5.Exit");
                    Console.Write("Enter the option: ");
                    int k = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    
                    switch (k)
                    {
                        case 1:
                            InsertData(con,cmd);
                            break;
                        case 2:
                            UpdateData(con, cmd);
                            break;
                        case 3:
                            DeleteData(con, cmd);
                            break;
                        case 4:
                            SearchByID(con, cmd);
                            break;
                        case 5:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;


                    }
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("Server Error: " + se.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("App Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Ended");
            }
            Console.ReadKey();

        }
    }
}
