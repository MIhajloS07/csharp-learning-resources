using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace linq
{
    class Zaposleni
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Pozicija { get; set; }
        public decimal Plata { get; set; }
        public string Projekat { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //{
            //    int[] brojevi = { 5, 1, 9, 2, 6 };

            //    var rastuceSort = brojevi.OrderBy(x => x);
            //    var opadajuceSort = brojevi.OrderByDescending(x => x);

            //    foreach (var a in rastuceSort)
            //    {
            //        Console.Write(a + " , ");
            //    }
            //    Console.WriteLine();
            //    foreach (var a in opadajuceSort)
            //    {
            //        Console.Write(a + " , ");
            //    }

            List<Zaposleni> zaposleni = new List<Zaposleni>
        {
            new Zaposleni { Id = 1, Ime = "Mihajlo", Pozicija = "Programer", Plata = 75000, Projekat = "WebApp" },
            new Zaposleni { Id = 2, Ime = "Ana", Pozicija = "Dizajner", Plata = 60000, Projekat = "WebApp" },
            new Zaposleni { Id = 3, Ime = "Marko", Pozicija = "Menadžer", Plata = 90000, Projekat = "ERP" },
            new Zaposleni { Id = 4, Ime = "Jelena", Pozicija = "Programer", Plata = 80000, Projekat = "ERP" },
            new Zaposleni { Id = 5, Ime = "Nikola", Pozicija = "Tester", Plata = 55000, Projekat = "CRM" }
        };

            // Selektujemo sva imena zaposlenih
            var imena = zaposleni.Select(z => z.Ime);

            Console.WriteLine("Imena zaposlenih: ");
            foreach (var ime in imena)
                Console.WriteLine(ime);
            Console.WriteLine();

            // Filtriramo zaposlene cija je pozicija => Programer
            var programeri = zaposleni.Where(z => z.Pozicija == "Programer");
            Console.WriteLine("Programeri: ");
            foreach (var z in programeri)
                Console.WriteLine($"{z.Ime} ({z.Plata} RSD)");
            Console.WriteLine();

            // Sortiramo plate zaposlenih po opadacujem poretku
            var sortiraniDes = zaposleni.OrderByDescending(z => z.Plata);
            Console.WriteLine("Sortirani zaposleni prema plati opadajuce");
            foreach (var z in sortiraniDes)
                Console.WriteLine($"{z.Ime} ( {z.Plata} RSD)");
            Console.WriteLine();

            // Sortiramo plate zaposlenih po opadacujem poretku
            var sortiraniBy = zaposleni.OrderBy(z => z.Plata);
            Console.WriteLine("Sortirani zaposleni prema plati rastuce");
            foreach (var z in sortiraniBy)
                Console.WriteLine($"{z.Ime} ( {z.Plata} RSD)");
            Console.WriteLine();

            // AGREGATNE FUNKCIJE
            // Prosecna plata zaposlenih
            var prosecnaPlata = zaposleni.Average(z => (double)z.Plata);
            Console.WriteLine("Prosecna plata zaposlenih je: " + prosecnaPlata);
            Console.WriteLine();

            // Radnik sa max platom
            var maxPlata = zaposleni.Max(z => (double)z.Plata);
            Console.WriteLine("Max plata je: " + maxPlata);

            // Radnik sa min platom
            var minPlata = zaposleni.Min(z => (double)z.Plata);
            Console.WriteLine("Min plata je: " + minPlata);
            Console.WriteLine();

            // Broj programera
            var brojProgramera = zaposleni.Count(z => z.Pozicija == "Programer");
            Console.WriteLine($"Broj programera: {brojProgramera}");
        }
    }
}
