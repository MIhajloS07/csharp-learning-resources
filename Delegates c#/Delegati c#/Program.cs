using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Delegati_c_
{
    internal class Program
    {
        // Delegati
        public delegate int PerformCalculation(int x, int y);
        public delegate void DelegatInt(int parametar);
        public delegate void DelegatString(string text);
        public delegate int DelegatDvaInt(int parametarJedan, int parametarDva);   
        public delegate bool DelegatBool(int parametar);   
        public static int Saberi(int x, int y) => x + y;
        public static int Pomnozi(int x, int y) => x * y;
        public static void VelikaSlova(string text) => Console.WriteLine(text.ToUpper());
        public static void MalaSlova(string text) => Console.WriteLine(text.ToLower());
        public static void DuzinaTeksta(string text) => Console.WriteLine(text.Length);
        public static void Kvadrat(int broj) => Console.WriteLine($"Kvadrat broja {broj} je: {Pow(broj, 2)}");
        public static void Koren(int broj) => Console.WriteLine($"Koren broja {broj} je: {Sqrt(broj)}");
        public static bool DaLiJeParan(int x) => x % 2 == 0;
        public static bool DaLiJeVeciOdDeset(int x) => x > 10;
        public static void Filtriraj(List<int> lista, DelegatBool uslov)
        {
            foreach (var element in lista) 
            {
               if (uslov(element))
                {
                    Console.WriteLine(element.ToString());
                }
            }
        }
        static void Main(string[] args)
        {
            // Instanciranje delegata
            //PerformCalculation calc = null; // bude null
            //calc += Saberi; // doda mu se referenca na metodu add koja vraca int
            //Console.WriteLine(calc(5, 3));
            //DelegatInt delegat = null;
            //delegat += Kvadrat;
            //delegat += Koren;
            //delegat(16);
            //DelegatDvaInt delegat = null;
            //Console.Write("Opcija: "); byte opcija = Convert.ToByte(Console.ReadLine());
            //switch (opcija)
            //{
            //    case 1:
            //        delegat = Saberi;
            //        Console.WriteLine(delegat(5, 3));
            //        break;
            //    case 2:
            //        delegat = Pomnozi;
            //        Console.WriteLine(delegat(5, 3));
            //        break;
            //    default:
            //        Console.WriteLine("Greska!");
            //        break;
            //}
            //DelegatString delegat = null;
            //delegat += VelikaSlova;
            //delegat += MalaSlova;
            //delegat += DuzinaTeksta;
            //delegat("Neki str");
            List<int> brojevi = new List<int> { 3, 7, 12, 18, 25 };
            Console.WriteLine("Parni brojevi:");
            Filtriraj(brojevi, DaLiJeParan);
            Console.WriteLine("\nBrojevi veci od 10:");
            Filtriraj(brojevi, DaLiJeVeciOdDeset);
        }
    }
}