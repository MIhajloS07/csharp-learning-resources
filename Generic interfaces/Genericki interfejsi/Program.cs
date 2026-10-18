using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericki_interfejsi
{
    public interface IPrikazi<T>
    {
        void Prikazi(T vrednost);
    }
    public interface IObradi<T>
    {
        void Obradi(T vrednost);    
    }
    public interface IPrikazObrada<T> : IPrikazi<T>, IObradi<T> { }
    class PrikazivacString : IPrikazi<string>
    {
        public void Prikazi(string vrednost)
        {
            Console.WriteLine("Prikazujem vrednost: " + vrednost);
        }
    }
    class PrikazivacGenericki<T> : IPrikazObrada<T>
    {
        public void Prikazi(T vrednost)
        {
            Console.WriteLine("Prikazujem vrednost: " + vrednost);
        }
        public void Obradi(T vrednost)
        {
            Console.WriteLine("Obradjujem vrednost: " + vrednost);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPrikazi<string> prikazi = new PrikazivacString();
            //prikazi.Prikazi("Mihajlo");
            IPrikazObrada<string> prikazi = new PrikazivacGenericki<string>();
            prikazi.Prikazi("Mihajlo");
            prikazi.Obradi("PC");

            List<Student> studenti = new List<Student>()
            {
                new Student("Mihajlo", 4.9),
                new Student("Nataša", 5.0),
                new Student("Petar", 4.7)
            };

            studenti.Sort(); // automatski koristi CompareTo iz klase Student

            Console.WriteLine("Sortirani studenti (po proseku):");
            foreach (var s in studenti)
            {
                Console.WriteLine(s);
            }
        }
    }
}
