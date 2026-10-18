using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitski_operatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint a = 7;
            uint b = a << 1; //pomeranje jednog bita ulevo
            uint c = a >> 1; //pomeranje jednog bita udesno
            uint d = ~a;
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            
        }
    }
}
