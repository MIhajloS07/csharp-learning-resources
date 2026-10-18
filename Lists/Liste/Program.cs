using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ucenici = new List<string>();

            //Metode za rad sa listama

            //Dodavanje elemenata u listi
            ucenici.Add("Zoran");
            ucenici.Add("Goran");
            ucenici.Add("Boban");

            //Umetanje elementa u listi prema zadatom indeksu
            ucenici.Insert(0,"Dragan"); // dodaje string na prvom mestu [0]

            //Uklanjanje elementa iz liste
            //ucenici.Remove("Zoran");

            //Uklanjanje elementa iz liste prema indeksu
            //ucenici.RemoveAt(0); // Brise prema zadatom indeksu

            //Sortiranje liste
            ucenici.Sort();

            //Duzina zadate liste
            Console.WriteLine(ucenici.Count);
            Console.WriteLine();

            //Pristupanje elementima u listi
            Console.WriteLine(ucenici[0]);
            Console.WriteLine(ucenici[1]);
            Console.WriteLine(ucenici[2]);
            ucenici[0] = "Gogi";
            Console.WriteLine(ucenici[0]);


            //Brisanje svih elemenata sa liste
            //ucenici.Clear();

            //Ispis svih elemenata u listi
            for (int i = 0; i < ucenici.Count; i++)
            {
                Console.WriteLine(ucenici[i]);
            }

            //foreach (string s in ucenici)
            //{
            //    Console.WriteLine(s);
            //}

            //Provera da li lista sadrzi zadati element
            string ime = "Luka";
            if (ucenici.Contains(ime)) // Metoda Contains nam vraca bool vrednost i koristi se u ispitnim tokovima
            {
                Console.WriteLine($"Lista sadrzi vrednost: {ime}");
            }
            else
            {
                Console.WriteLine($"Lista ne sadrzi vrednost: {ime}");
            }

            List<string> podlista = ucenici.GetRange(0,3); //kreiranje podliste koriscenjem metode GetRange(index,brojElemenata)
            foreach(var element in podlista)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();

            string[] nizUcenika = ucenici.ToArray(); // kopiramo listu ucenici u niz tipa string

            foreach (var element in nizUcenika) { Console.WriteLine(element); }






        }
    }
}
