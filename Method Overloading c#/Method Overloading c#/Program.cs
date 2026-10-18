using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_c_
{
    internal class Program
    {
        static void IstaMetoda(int x, int y)
        {
            Console.WriteLine(x + y); 
        }

        static void IstaMetoda(string x, string y)
        {
            Console.WriteLine(x + " " + y);
        }

        static void IstaMetoda(char x, char y)
        {
            Console.WriteLine(x + ' ' + y);
        }

        static void Main(string[] args)
        {
            IstaMetoda(2, 3);
            IstaMetoda("Milovan", "Spasic");
            IstaMetoda('A', 'B');
        }
    }
}
