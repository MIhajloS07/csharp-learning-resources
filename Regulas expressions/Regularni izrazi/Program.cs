using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Regularni_izrazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Unesi tekst: ");
            //string text = Console.ReadLine();
            //string sablon = @"\d{3}/\d{3}-\d{4}";
            //Console.WriteLine(regexNadji(text, sablon));

            // Samo 4 cifre
            //Console.Write("Unesi tekst: ");
            //string text = Console.ReadLine();
            //string sablon = @"^\d{4}$";
            //Console.WriteLine(regexNadji(text, sablon));

            // Bar jedno veliko slovo
            //Console.Write("Unesi tekst: ");
            //string text = Console.ReadLine();
            //string sablon = @"[A-Z]";
            //Console.WriteLine(regexNadji(text, sablon));

            // Format datuma
            //Console.Write("Unesi tekst: ");
            //string text = Console.ReadLine();
            //string sablon = @"\d{2}.\d{2}.\d{4}";
            //Console.WriteLine(regexNadji(text, sablon));

            // Format registarske tablice
            //Console.Write("Unesi tekst: ");
            //string text = Console.ReadLine();
            //string sablon = @"^[A-Z]{2}-\d{3}-[A-Z]{2}$";
            //Console.WriteLine(regexNadji(text, sablon));

            // Unos mora da pocinje slovom
            //Console.Write("Unesi tekst: ");
            //string text = Console.ReadLine();
            //string sablon = @"^[a-zA-Z]";
            //Console.WriteLine(regexNadji(text, sablon));

            // Unos mora da se zavrsava brojem
            //Console.Write("Unesi tekst: ");
            //string text = Console.ReadLine();
            //string sablon = @"\d$";
            //Console.WriteLine(regexNadji(text, sablon));

            //Proveri da li se u tekstu nalazi rec admin
            //Console.Write("Unesi tekst: ");
            //string text = Console.ReadLine();
            //string sablon = @"admin";
            //Console.WriteLine(regexNadji(text, sablon));

            // Lozinka mora imati najmanje 6 karaktera i jednu cifru
            //Console.Write("Unesi tekst: ");
            //string text = Console.ReadLine();
            //string sablon = @"^(?=.*\d).{6,}$";
            //Console.WriteLine(regexNadji(text, sablon));

            // Telefon u formatu
            //Console.Write("Unesi tekst: ");
            //string text = Console.ReadLine();
            //string sablon = @"\d{3}/\d{3}-\d{4}";
            //Console.WriteLine(regexNadji(text, sablon));

            // Unos sme da sadrzi samo mala slova i brojeve
            //Console.Write("Unesi tekst: ");
            //string text = Console.ReadLine();
            //string sablon = @"^[a-z0-9]+$";
            //Console.WriteLine(regexNadji(text, sablon));

            //string text = "Danas je 28.05.2025. godine.";
            //string sablon = @"\d{2}.\d{2}.\d{4}";
            //Match m = Regex.Match(text, sablon);
            //if (m.Success)
            //{
            //    Console.WriteLine($"Pronadjen datum: {m.Value}");
            //    Console.WriteLine($"Pozicija: {m.Index}");
            //}

            // If we use one regex more than one time
            //Regex reg = new Regex(@"\d{4}");
            //string text = "Danas je 28.05.2025. godine.";
            //string sablon = @"\d{2}.\d{2}.\d{4}";
            //Match m =  reg.Match(text);
            //if (m.Success)
            //{
            //    Console.WriteLine($"Pronadjen datum: {m.Value}");
            //    Console.WriteLine($"Pronadjen indeks: {m.Index}");
            //}

            //string text = "Kontakt telefoni: 062-123-456, 063-789-012, 064-555-666";
            //string sablon = @"\d{3}-\d{3}-\d{3}";
            //MatchCollection collection = Regex.Matches(text, sablon);
            //foreach (Match match in collection) 
            //    Console.WriteLine(match.Value);

            //string tekst = "Moja e-mail adresa je mihajlostoiljkovic554@gmail.rs";
            //string sablon = @"\b[A-Za-z0-9._+%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";
            //string zamena = "[SAKRIVEN EMAIL]";
            //string rezultat = Regex.Replace(tekst, sablon, zamena);
            //Console.WriteLine(rezultat); // Moja e-mail adresa je [SAKRIVEN EMAIL]

            //string text = "Ime: Mihajlo, godina: 18, Ime: Nikola, godina: 17";
            //Match m = Regex.Match(text, @"Ime: (\w+), godina: (\d+)");
            //string ime = m.Groups[1].Value;
            //string godine = m.Groups[2].Value;
            //Console.WriteLine($"Ime: {ime}, broj godina: {godine}");

            //string text = "1,2,3";
            //Match m = Regex.Match(text, @"(\d,?)+");
            //foreach (Capture item in m.Groups[1].Captures)
            //    Console.WriteLine(item.Value); // 1, 2, 3

            Regex regex = new Regex(@"^ime:\s+\w+$", RegexOptions.IgnoreCase);
            bool valid = regex.IsMatch("ime: Jovan"); Console.WriteLine(valid);

        }
        public static string regexNadji(string text, string sablon) => Regex.IsMatch(text, sablon) ? "Nadjeno!" : "Nije nadjeno!";
    }
}
