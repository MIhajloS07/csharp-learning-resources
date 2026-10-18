using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcija_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nastavnikIme = "Zoran Djindjic";
            string ucenikIme = "Goran Zdravkovic";
            Nastavnik nastavnik = new Nastavnik();
            Console.WriteLine(nastavnik.Ime(nastavnikIme));
            Ucenik ucenik = new Ucenik();
            Console.WriteLine(ucenik.Ime(ucenikIme));
            nastavnik.PrintIme(nastavnikIme);
            ucenik.PrintIme(ucenikIme);
        }
    }
}
