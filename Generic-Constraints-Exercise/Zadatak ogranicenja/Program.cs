using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_ogranicenja
{
    interface IUkljuci
    {
        void Ukljuci();
    }
    interface IPrikaz
    {
        void Prikazi();
    }
    public class BaznaKlasa : IPrikaz
    {
        public string Ime { get; set; }
        public void Prikazi()
        {
            Console.WriteLine($"Osoba: {Ime}");
        }
    }
    public class Uredjaj
    {
        public string Naziv {  get; set; }
        public void PrikaziNaziv()
        {
            Console.WriteLine(this.Naziv);
        }
    }
    public class Senzor : Uredjaj, IUkljuci
    {
        public Senzor()
        {
            Naziv = "Senzor";
        }
        public void Ukljuci()
        {
            Console.WriteLine("Senzor ukljucen!");
        }
    }
    public class Motor : Uredjaj, IUkljuci
    {
        public Motor()
        {
            Naziv = "Motor";
        }
        public void Ukljuci()
        {
            Console.WriteLine("Motor ukljucen");
        }
    }
    internal class Program
    {
        public static void PokreniUredjaj<T>() 
            where T : Uredjaj, IUkljuci, new()
        {
            T uredjaj = new T();
            uredjaj.PrikaziNaziv();
            uredjaj.Ukljuci();
        }
        public static void Kopiraj<T>(T izvor, T cilj)
            where T : class
        {
            if (izvor == null || cilj == null) 
                Console.WriteLine("Nije moguće kopirati null vrednosti.");
            else
                Console.WriteLine($"Kopirani podaci iz {izvor} u {cilj}");
        }
        public static void NapraviInstancu<T>() where T : new()
        {
            T obj = new T();
            Console.WriteLine("Tip objekta: " + obj.GetType().Name);
        }
        public static void Aktiviraj<T>(T uredjaj) 
            where T : IUkljuci, new()
        {
            uredjaj.Ukljuci();
        }
        public static void Uporedi<T>(T a, T b) 
            where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0)
                Console.WriteLine($"a:{a} je vece od b:{b}");
            else if (b.CompareTo(a) > 0)
                Console.WriteLine($"b:{b} je vece od a:{a}");
            else
                Console.WriteLine($"a:{a} i b:{b} su jednaki");
        }
        public static void ProveriNull<T>(T objekat) 
            where T : class
        {
            if (objekat == null) 
                Console.WriteLine("Objekat ima null vrednost");
            else
                Console.WriteLine("Objekat nema null vrednost");
        }
        public static void Obradi<T>(string nazivOsobe) 
            where T : BaznaKlasa, IPrikaz, new()
        {
            T objekat = new T();
            objekat.Ime = nazivOsobe;
            objekat.Prikazi();
        }
        static void Main(string[] args)
        {
            //PokreniUredjaj<Senzor>();
            //PokreniUredjaj<Motor>();
            //string textJedan = "blabla";
            //string textDva = "dada";
            //Kopiraj(textJedan, textDva);
            //NapraviInstancu<Program>();
            //NapraviInstancu<List<int>>();
            //Uporedi(5, 8);
            //Uporedi("av", "va");
            //Uredjaj uredjaj = new Uredjaj();
            //ProveriNull(uredjaj);
            BaznaKlasa baznaKlasa = new BaznaKlasa();
            Obradi<BaznaKlasa>("Bicman");        
            Obradi<BaznaKlasa>("Dragan");        
            Obradi<BaznaKlasa>("Bosko");        
        }
    }
}
