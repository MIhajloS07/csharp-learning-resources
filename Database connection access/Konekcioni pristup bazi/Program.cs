using System.Data.SqlClient;
using System;
using System.Net.Http.Headers;
namespace Konekcioni_pristup_bazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connString = @"Data Source = LOCALHOST\SQLEXPRESS; Initial Catalog = NorthWind; Integrated Security = True; Encrypt = False";
                using (SqlConnection conn = new SqlConnection(connString))
                // Using blok se koristi da osigura da se objekat konekcije pravilno zatvori nakon upotrebe, cak i ako dođe do greške.
                {
                    conn.Open();
                    // Otvaranje konekcije prema bazi podataka. Ako konekcija ne uspe, biće bačen izuzetak koji ce biti uhvacen u catch bloku.
                    //Console.WriteLine("Uspesno konektovan na bazu!");
                    string query = "SELECT * FROM Customers"; // SQL upit koji se izvršava nad bazom podataka. Ovaj upit selektuje sve kolone iz tabele "Customers".
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // Kreiranje SqlCommand objekta koji predstavlja SQL upit koji će se izvršiti nad bazom podataka. Konstruktor prima SQL upit i konekciju kao argumente.
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    // Izvršavanje SQL upita i dobijanje SqlDataReader objekta koji omogućava čitanje rezultata upita. ExecuteReader() metoda se koristi za izvršavanje upita koji vraća rezultate (npr. SELECT).
                    {
                        while (reader.Read())
                        // Petlja koja se izvršava dok god ima redova za čitanje u SqlDataReader objektu. Read() metoda pomera pokazivač na sledeći red i vraća true ako postoji red, ili false ako nema više redova.
                        {
                            string customerId = reader["CustomerID"].ToString();
                            string companyName = reader["CompanyName"].ToString();
                            string phone = reader["Phone"].ToString();
                            Console.WriteLine($"CustomerID: {customerId}, CompanyName: {companyName}, phone: {phone}");
                            // Čitanje vrednosti iz trenutnog reda SqlDataReader objekta koristeći indeks ili naziv kolone. U ovom primeru, čitamo "CustomerID" i "CompanyName" kolone i ispisujemo ih na konzolu.
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Greska prilikom konekcije na bazu!");
                // Ako dođe do greške prilikom konekcije ili izvršavanja SQL upita, biće uhvaćen izuzetak i ispisana poruka o grešci na konzolu.
            }
        }
    }
}
