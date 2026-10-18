using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogranicenja_2
{
    interface IIspis
    {
        void Ispisi();
    }
    public interface IStruja
    {
        void IspisiVelicinu();
    }
    public class Napon : IStruja
    {
        public void IspisiVelicinu()
        {
            Console.WriteLine("Volt [V]");
        }
    }
    public class Struja : IStruja 
    {
        public void IspisiVelicinu()
        {
            Console.WriteLine("Amper [A]");
        }
    }
    public class Automobil : IIspis
    {
        public void Ispisi()
        {
            Console.WriteLine("Automobil");
        }
    }
    public class Bicikl
    {
        public void Ispisi()
        {
            Console.WriteLine("Bicikl");
        }
    }
    internal class Program
    {
        public static void IspisiTip<T>(T objekat) where T : IIspis
        {
            Console.WriteLine(objekat.GetType().Name);
        }
        public static void KojaJeVelicina<T, U>(T velicina) where T : U
        {
            if (velicina is IStruja s)
            {
                s.IspisiVelicinu();
            }
        }
        static void Main(string[] args)
        {
            //IspisiTip(new Automobil());
            //Greska //IspisiTip(new Bicikl());
            Napon napon = new Napon();
            KojaJeVelicina<Napon, IStruja>(napon);
            Struja struja = new Struja();
            KojaJeVelicina<Struja, IStruja>(struja);
        }
    }
}
