using System;
using System.Data;
using System.Data.SqlClient;


namespace SQLProc
{   
    // Executing stored procedure
    class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static string connectionString = "server=IND365;database=Day13DB;trusted_connection=true;";
        static void Main2(string[] args)
        {
            int id;
            string name;
            double price;
            DateTime mfgDate, expDate;
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand()
                {
                    CommandText = "usp_iProducts",
                    CommandType = CommandType.StoredProcedure,
                    Connection = con
                };

                Console.Write("Enter Product ID: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Enter Product Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Product Price: ");
                price = double.Parse(Console.ReadLine());
                Console.Write("Enter Product Mfg Date: ");
                mfgDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter Product Exp Date: ");
                expDate = DateTime.Parse(Console.ReadLine());

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@mfgdate", mfgDate);
                cmd.Parameters.AddWithValue("@expdate", expDate);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record inserted successfully");
            }
            catch (SqlException se)
            {
                Console.WriteLine("Server Error: "+se.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("App Error: "+ex.Message);
            }
            finally
            {
                con.Close();
                Console.WriteLine("Program Ended");
            }
            Console.ReadKey();
        }
    }
}
