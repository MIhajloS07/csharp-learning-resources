using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje_genericki_interfejsi
{
    interface IPair<T1, T2>
    {
        T1 First { get; set; }
        T2 Second { get; set; }
    }
    class Pair<T1, T2> : IPair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPair<string, int> pair = new Pair<string, int>() { First = "Godina", Second = 2025 };
            //Console.WriteLine($"{pair.First}: {pair.Second}");
        }
    }
}
