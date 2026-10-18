using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje__Inheritance_
{
    // Bazna klasa
    class Osnovna
    {
        public int javnaProm = 15;
        protected string zasticenaProm = "Ja sam zasticeno polje";
        private float privatnaProm = 15.56f;

        public void ispisVrednosti()
        {
            Console.WriteLine(javnaProm);
            Console.WriteLine(zasticenaProm);
            Console.WriteLine(privatnaProm);
        }

        protected void ispisPrivatneProm()
        {
            Console.WriteLine(privatnaProm);
        }
    }
    // Izvedena klasa
    class Izvedena : Osnovna
    {
        public int Nekibroj = 13;

        public void ZbirBrojeva()
        {
            Console.WriteLine($"Zbir je: {Nekibroj + javnaProm}");
        }
        public void test()
        {
            ispisVrednosti();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Izvedena izvedena = new Izvedena();
            Console.WriteLine(izvedena.javnaProm);
            izvedena.test();
        }
    }
}
