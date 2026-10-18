using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using klase;

namespace Polimorfizam_c___Staticki_i_dinamicki_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dinamicki polimorfizam
            Oblik krug = new Krug(5.67);
            Console.WriteLine(Math.Round(krug.Povrsina(),2)); // 101
            Oblik pravougaonik = new Pravougaonik(4,5);
            Console.WriteLine(Math.Round(pravougaonik.Povrsina(), 2)); // 20

            //staticki polimorfizam
            Matematika mat = new Matematika();
            Console.WriteLine(mat.Povrsina(4,5));
        }
    }
}

namespace klase
{
    //dinamicki polimorfizam

    public class Oblik
    {
        public virtual double Povrsina()
        {
            return 0;
        }
    }
    public class Krug : Oblik
    {
        public double R {  get; set; } 
        public Krug(double r)
        {
            R = r;
        }
        public override double Povrsina()
        {
            return Math.Pow(R, 2) * Math.PI;
        }

    }
    public class Pravougaonik : Oblik
    {
        public double Sirina {  get; set; } 
        public double Duzina { get; set; }
        public Pravougaonik(double sirina, double duzina)
        {
            Sirina = sirina;
            Duzina = duzina;
        }
        public override double Povrsina()
        {
            return Sirina * Duzina;
        }
    }

    // Staticki polimorfizam

    public class Matematika
    {
        public double Povrsina(double r)
        {
            return Math.Pow(r,2) * Math.PI;
        }
        public double Povrsina(double sirina,double duzina)
        {
            return sirina * duzina;
        }
    }
}
