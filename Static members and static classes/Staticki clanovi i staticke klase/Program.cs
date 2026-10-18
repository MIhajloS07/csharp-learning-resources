using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticki_clanovi_i_staticke_klase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klasa obj = new klasa();
            
            Console.WriteLine(klasa.brojac); //5
            klasa.PovecajBroj();
            Console.WriteLine(klasa.brojac); //6
        }
    }
    class klasa
    {
        public static int brojac;

        static klasa()
        {
            brojac = 0;
        }

        public static void PovecajBroj()
        {
            brojac++;
        }
    }
}
