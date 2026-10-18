using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogranicenje_za_tipske_parametre
{
    class Vozilo { }
    class Automobil : Vozilo { }
    class Bicikl { }
    class mojaKlasa
    {
        public void HelloWorld()
        {
            Console.WriteLine("Hello world!");
        }    
    }
    internal class Program
    {
        // Metoda koja vraca podrazmevane vrednosti za vrednosne tipove podatka
        public static void Podrazmevano<T>() where T : struct
        {
            Console.WriteLine(default(T));
        }
        // Metoda koja vraca ime tipa podatka za referentne tipove podatka
        public static void IspisiIme<T>(T objekat) where T : class
        {
            Console.WriteLine(objekat.GetType().Name);
        }
        public static T KreirajInstancu<T>() where T : new() 
        {
            return new T();
        }
        public static void Ispisi<T>(T objekat) where T : Vozilo
        {
            Console.WriteLine(objekat.GetType().Name);
        } 
        static void Main(string[] args)
        {
            try
            {
                // Vrednosni tipovi
                //Podrazmevano<int>();
                //Podrazmevano<short>();
                //Podrazmevano<long>();
                //Podrazmevano<bool>();
                //Podrazmevano<DateTime>();
                // Referentni tipovi
                //int[] arr = new int[] { 1, 2, 3, 4, 5 };
                //IspisiIme(arr);
                //IspisiIme("Ovo je string tip");
                //IspisiIme();
                //var objekat = KreirajInstancu<mojaKlasa>();
                //objekat.HelloWorld();
                Ispisi(new Vozilo());
                Ispisi(new Automobil());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Gresaka u tipu!");
                Console.WriteLine("Detalji greske: " + ex.Message);
            }
        }
    }
}
