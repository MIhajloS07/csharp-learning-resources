using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadjacavanje_metoda_c_
{
    class BaznaKlasa
    {
        public virtual void Metoda()
        {
            Console.WriteLine("Bazna");
        }
    }
    class IzvedenaKlasa : BaznaKlasa
    {
        public override void Metoda()
        {
            //base.Metoda();
            Console.WriteLine("Izvedena");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //IzvedenaKlasa objI = new IzvedenaKlasa();
            //objI.Metoda();
            //BaznaKlasa objB = new BaznaKlasa();
            //objB.Metoda();

            //Objekat bazne klase referencira objekat izbedene klase 
            BaznaKlasa baz = new IzvedenaKlasa();
            baz.Metoda(); // -> "izvedena"
        }
    }
}
