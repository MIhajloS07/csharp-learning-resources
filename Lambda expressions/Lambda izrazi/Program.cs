using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> listString = new List<string> { "auto", "programiranje", "pas", "monitor", "java", "brate" };

            List<Osoba> osobe = new List<Osoba>
            {
                new Osoba { Ime = "Majmun", Godine = 19 },
                new Osoba { Ime = "Dragan", Godine = 17 },
                new Osoba { Ime = "Marko", Godine = 22 }
            };
            // LINQ
            var parniBrojevi = listInt.Where(x => x % 2 == 0);
            var uvecaniBrojevi = listInt.Select(x => x + 10);
            var stringoviVeciodPet = listString.Where(s => s.Length > 5);
            var sortiranaLista = osobe.OrderBy(o => o.Godine);
            var osobaNaSlovoM = osobe.First(o => o.Ime.StartsWith("M"));
            //Iteracija kroz listu koristeci IEnumerator<T>
            //IEnumerator<Osoba> enumerator = sortiranaLista.GetEnumerator();
            //while (enumerator.MoveNext())
            //    Console.WriteLine(enumerator.Current);
            //Iteracija kroz listu koristeci foreach petlju
            //foreach (var o in sortiranaLista)
            //    Console.WriteLine(o);
            Console.WriteLine(osobaNaSlovoM);
        }
    }
}

