using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prenos_podataka_po_vrednosti_i_referenci
{
    internal class Program
    {
        static void Dekrement(int num) => num--; 
        static void Inkrement(ref int num) => num++;
        static void uvecanjeZaDva(out int num)
        {
            num = 2; num += 2; 
        }

        
        static void Main(string[] args)
        {
            //prenos parametara po vrednosti
            int x = 2;
            Dekrement(x);
            Console.WriteLine(x);
            //prenos parametara po referenci
            int y = 2;
            Inkrement(ref y);
            Console.WriteLine(y);
            //Kljucna rec out
            int z;
            uvecanjeZaDva(out z);
            Console.WriteLine(z);
        }
    }
}
