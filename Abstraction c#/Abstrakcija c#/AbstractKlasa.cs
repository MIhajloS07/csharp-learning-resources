using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcija_c_
{
    abstract class AbstractKlasa
    {
        public abstract string Ime(string s);
        public void PrintIme(string s)
        {
            Console.WriteLine(s);
        }
    }
    class Nastavnik : AbstractKlasa 
    {
        public override string Ime(string s)
        {
            s = "Nastavnik: " + s;
            return s;
        }
    }
    class Ucenik : AbstractKlasa
    {
        public override string Ime(string s)
        {
            s = "Ucenik: " + s;
            return s;
        }
    } 
}
