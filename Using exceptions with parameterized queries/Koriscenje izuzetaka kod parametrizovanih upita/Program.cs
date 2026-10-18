using System;
using System.Data;
using System.Data.SqlClient;

namespace Koriscenje_izuzetaka_kod_parametrizovanih_upita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite naziv grada: "); string city = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(city)) { Console.WriteLine("Obavezan je unos naziva grada."); return; }
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString)) 
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_GetCustomerByCity", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@City", SqlDbType.NVarChar, 15).Value = city;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (dt.Rows.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nema kupaca u ovom gradu.");
                        Console.ResetColor();
                        return;
                    }
                    Console.WriteLine("--- U zadatom gradu se nalaze sledeci kupci: ---");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    foreach (DataRow row in dt.Rows)
                        Console.WriteLine(row["CompanyName"].ToString());
                    Console.ResetColor();
                }
            }
            catch (SqlException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Došlo je do greške prilikom komunikacije sa bazom podataka.");
                Console.WriteLine($"Detalji greške: {ex.Message}");
                Console.WriteLine($"Broj greske: {ex.Number}");
                Console.WriteLine($"Server: {ex.Server}");
                Console.WriteLine($"Procedura: {ex.Procedure}");
                Console.WriteLine($"Linija greske: {ex.LineNumber}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Došlo je do neočekivane greške.");
                Console.WriteLine($"Detalji greške: {ex.Message}");
                Console.WriteLine($"Izvor greške: {ex.Source}");
                Console.ResetColor();
            }
        }
    }
}
