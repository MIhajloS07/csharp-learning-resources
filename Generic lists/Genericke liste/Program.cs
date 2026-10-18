using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericke_liste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GENERICKA LISTA - LIFO - last in first out
            List<char> chars = new List<char> { 'a', 'b', 'v', 'g' };
            
            // Dodavanje elemenata
            chars.Add('d'); // Dodaje na kraj liste jedan element
            List<char> charsABC = new List<char> { 'e', 'f', 'g'};
            chars.AddRange(charsABC); // Dodaje na kraj liste podlistu
            
            // Uklanjanje elemenata
            chars.Remove('a'); // brise odredjeni element
            chars.RemoveAt(0); // brise sa prvog indeksa

            // Pristupanje elementima
            //Console.WriteLine(chars[1]);
            //Console.WriteLine(chars.Count);
            //if (chars.Contains('e'))
            //    Console.WriteLine(chars.IndexOf('e'));
            
            // Sortiranje liste
            chars.Sort();
            chars.Reverse();
            Array niz = chars.ToArray(); // Kreiranje niza tako sto elemente liste konvertujemo u array uz pomoc array klase


            // Ispis
            //foreach(char c in niz)
            //    { Console.WriteLine(c); }

            // Ispis koriscenjem metode
            //chars.ForEach(x => Console.WriteLine(x));


            // Primer
            List<Ucenik> ucenici = new List<Ucenik> {
                new Ucenik("Zoran", 3),
                new Ucenik("Bratislav", 1),
                new Ucenik("Tomislav", 4),
                new Ucenik("Vladislav", 2),
                new Ucenik("Miodrag", 1)
            };

            Console.WriteLine("Spisak ucenika: ");
            ucenici
                .ForEach(ucenik => Console.WriteLine(ucenik));
            Console.WriteLine("Spisak ucenika drugog razreda: ");
            ucenici
                .Where(ucenik => ucenik.Razred == 2)
                .ToList()
                .ForEach(ucenik => Console.WriteLine(ucenik.Ime));

        }
    }
}
