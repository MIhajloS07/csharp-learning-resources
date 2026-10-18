using System;
using System.Configuration;
using System.Data.SqlClient;

namespace konekcioni_string_MSSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string connStr = @"Data Source=LOCALHOST\\SQLEXPRESS;
            //                   Initial Catalog=NorthWind;
            //                   Integrated Security=True;
            //                   Encrypt=False";
            try
            {
                string conStr = ConfigurationManager.ConnectionStrings["MihajloBaza"].ConnectionString;
            }
            catch (NullReferenceException ex) { Console.WriteLine(ex.Message); }
            catch (SqlException ex) { Console.WriteLine($"SQL ERROR: {ex.Message}"); }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
    }
}
