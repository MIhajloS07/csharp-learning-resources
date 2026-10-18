using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteracija_kroz_genericke_kolekcije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt = new List<int>();
            // Dodavanje elemenata u generickoj listi
            listInt.Add(1);
            listInt.Add(2);
            listInt.Add(3);
            listInt.Add(4);
            // Koriscenje LINQ upita
            var parni = listInt.Where(n => n % 2 == 0);
            var neparni = listInt.Where(n => n % 2 == 1);   
            // Koriscenje foreach petlje (ne koristi index, laka za implementaciju, bezbedna)
            foreach (var n in parni)
                Console.WriteLine(n);
            foreach (var n in neparni)
                Console.WriteLine(n);
            // Koriscenje enumeratora
            IEnumerator<int> enumerator = listInt.GetEnumerator();
            while (enumerator.MoveNext())
                Console.WriteLine(enumerator.Current);
        }
    }
}
