using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje_clanovi
{

    class BaznaKlasa
    {
        private int broj = 10;
        public class IzvedenaKlasa : BaznaKlasa
        {
            public int VratiBroj()
            {
                return broj;
            }

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BaznaKlasa.IzvedenaKlasa objekat = new BaznaKlasa.IzvedenaKlasa();
            Console.WriteLine(objekat.VratiBroj());
        }
    }
}
