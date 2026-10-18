using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_c_
{
    internal class Program
    {
        //Metode nepovratnog tipa (void)
        static void Metoda()
        {
            Console.WriteLine("Ja volim programiranje");
        }

        static void PrintMetoda() 
        {
            Metoda();
            Metoda();
            Metoda();
            Metoda();
            Metoda();
        }

        //Metode povratnog tipa (return type)
        static double Kvadrat(double broj)
        {
            return broj * broj;
        }

        static double Kub(double broj)
        {
            return broj * broj * broj;
        }

        static string tekst(string text)
        {
            return text;
        }

        static string PretvoriUVelikaSlova(string text)
        {
            return text.ToUpper();
        }

        static void print(string nameOne,string nameTwo,string NameThree)
        {
            Console.WriteLine(nameOne); 
            Console.WriteLine(nameTwo);
            Console.WriteLine(NameThree);
        }
        //Main metoda
        static void Main(string[] args)
        {
            //for(int i = 0; i < 5; i++)
            //{
            //    Metoda();
            //}
            //PrintMetoda();

            //Console.WriteLine(Kvadrat(5)); //25
            //Console.WriteLine(Kub(5)); //125

            //string text = "Print string";
            //Console.WriteLine(tekst(text));
            //Console.WriteLine(PretvoriUVelikaSlova(text)); //upper case
            //Program program = new Program();
            //program.Metoda();
            //
            Metoda();
            print(NameThree: "Dragan", nameOne: "Mitar" , nameTwo: "Milovan");
        }
    }
}
