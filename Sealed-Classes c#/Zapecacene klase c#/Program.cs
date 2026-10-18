using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapecacene_klase_c_
{
    internal class Program
    {
        class Osoba {
            public virtual void Metoda()
            {
                Console.WriteLine("Pozdrav iz Osoba");
            }
        }
        class Ucenik : Osoba {
            public sealed override void Metoda()
            {
                Console.WriteLine("Pozdrav iz Ucenik i to je to");
            }
        }
        class Vanredni : Ucenik {}

        sealed class Prekvalifikacija : Vanredni
        {
            
        }
        static void Main(string[] args)
        {
        }
    }
}
