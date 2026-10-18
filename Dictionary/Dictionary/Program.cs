using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> ocene = new Dictionary<string, int>();
            //ocene.Add("Paja", 3);
            //ocene.Add("Gaja", 4);
            //ocene.Add("Draja", 5);

            //Console.WriteLine("Ukupno je dato {0} ocena", ocene.Count);

            //if (ocene.Count > 0)
            //{
            //    if (ocene.ContainsKey("Gaja"))
            //        Console.WriteLine("Gaja je dobio ocenu {0}", ocene["Gaja"]);
            //    if (ocene.ContainsKey("Paja"))
            //        Console.WriteLine("Paja je dobio ocenu {0}", ocene["Paja"]);
            //    if (ocene.ContainsKey("Draja"))
            //        Console.WriteLine("Draja je dobio ocenu {0}", ocene["Draja"]);
            //}
            //else
            //    Console.WriteLine("Nema ni jednog elementa u recniku!");

            //ocene.Remove("Paja");

            //foreach (var element in ocene)
            //    Console.WriteLine("Ucenik {0} je dobio ocenu {1}", element.Key, element.Value);


            //ocene.Clear();

            SortedDictionary<string, int> ocene = new SortedDictionary<string, int>();
            ocene.Add("Paja", 3);
            ocene.Add("Gaja", 4);
            ocene.Add("Draja", 5);

            Console.WriteLine("Ukupno je dato {0} ocena", ocene.Count);

            if (ocene.Count > 0)
            {
                if (ocene.ContainsKey("Gaja"))
                    Console.WriteLine("Gaja je dobio ocenu {0}", ocene["Gaja"]);
                if (ocene.ContainsKey("Paja"))
                    Console.WriteLine("Paja je dobio ocenu {0}", ocene["Paja"]);
                if (ocene.ContainsKey("Draja"))
                    Console.WriteLine("Draja je dobio ocenu {0}", ocene["Draja"]);
            }
            else
                Console.WriteLine("Nema ni jednog elementa u recniku!");

            ocene.Remove("Paja");

            foreach (var element in ocene)
                Console.WriteLine("Ucenik {0} je dobio ocenu {1}", element.Key, element.Value);


            ocene.Clear();
        }
    }
}
