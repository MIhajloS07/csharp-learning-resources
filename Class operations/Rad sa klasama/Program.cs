using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad_sa_klasama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trougao t1 = new Trougao();
            t1.a = 1.2;
            t1.b = 2.0;
            t1.c = 3.0;
            Console.WriteLine($"Obim: {t1.a + t1.b + t1.c}");

            Krug k1 = new Krug();
            k1.r = 5.34;
            Console.WriteLine("Obim kruga je: " + k1.Obim());
            Console.WriteLine(k1.O);
        }
    }

    class Trougao
    {
        public double a;
        public double b;
        public double c;
    }
    class Krug
    {
        public double r;
        public const double pi = Math.PI;
        public double O { get { return Math.Round(2 * r * pi, 2); } }
        public double Obim()
        {
            return Math.Round(2 * r * pi,2);
        }
    }
}
