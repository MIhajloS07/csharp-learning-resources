using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Nizovi_i_petlje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////niz stringova
            //string[] fruits = { "Apple", "Orange", "Banana", "Strawberry" };

            //int[] niz = { 2, 4, 5, 3, 8, 1};

            //var sortiran = Array.Sort(niz);
            //Console.Write(sortiran);

            ////prolazak kroz niz stringova putem foreach petlje
            //foreach (var fruit in fruits)
            //{
            //    Console.Write(fruit);
            //    Console.WriteLine(" length:" + fruit.Length);
            //}

            ////prolazal kroz niz stringova putem for petlje (koristimo indekse)

            //for (int i = 0; i < fruits.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ". " + fruits[i]);
            //}


            ////niz brojeva
            //int[] numbers = { 1, 2, 3, 4, 5 };

            ////prolazak kroz niz brojeva putem foreach petlje 
            ////foreach(int num in numbers)
            ////{
            ////    Console.WriteLine(num); 
            ////}

            ////prolazak kroz niz brojeva putem for petlje
            ////for (int i = 0; i < numbers.Length; i++) { 
            ////    Console.WriteLine(numbers[i]);  
            ////}


            //Console.WriteLine("Unesi broj elemenata malih brojeva: ");
            //short brojE = Convert.ToInt16(Console.ReadLine());
            //short number;
            //short[] smallNums = new short[brojE];

            ////unos short brojeva
            //for (short i = 0; i < smallNums.Length; i++)
            //{
            //    Console.Write("Num: " + (i + 1) + ". ");
            //    number = Convert.ToInt16(Console.ReadLine());
            //    smallNums[i] = number;
            //}

            ////print short brojeva
            ////for (short i = 0; i < smallNums.Length; i++)
            ////{
            ////    Console.WriteLine(smallNums[i]);
            ////}


            //// bubble sort niza
            //for (int i = 0; i < smallNums.Length - 1; i++)
            //{
            //    for (int j = 0; j < smallNums.Length - 1 - i; j++)
            //    {
            //        if (smallNums[j] > smallNums[j + 1])
            //        {
            //            short temp = smallNums[j];
            //            smallNums[j] = smallNums[j + 1];
            //            smallNums[j + 1] = temp;
            //        }
            //    }
            //}

            ////ispis posle sortiranja niza (foreach petlja)
            //foreach(var nums in smallNums)
            //{
            //    Console.WriteLine(nums);    
            //}

            //Console.WriteLine();

            ////Slucaj 1: ispis neparnih brojeva pomocu for petlje
            //for (int i = 0; i < smallNums.Length; i++)
            //{
            //    if (smallNums[i] % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(smallNums[i]);
            //}

            ////Slucaj 2: ispis neparnih brojeva pomocu foreach petlje
            ////foreach (var nums in smallNums)
            ////{
            ////    if (nums % 2 == 0)
            ////    {
            ////        continue;
            ////    }
            ////    Console.WriteLine(nums);
            ////}

            //zadatak 1
            //int n; Console.Write("Unesi broj elemenata niza: "); n = Convert.ToInt32(Console.ReadLine());
            //int[] brojevi = new int[n];
            //int unos;
            ////unos brojeva
            //for (int i = 0; i < n; i++) 
            //{
            //    Console.Write($"{i + 1}. Broj:");
            //    unos = Convert.ToInt32(Console.ReadLine());
            //    brojevi[i] = unos;
            //}
            ////ispis brojeva pre manipulacije
            //foreach (var broj in brojevi) 
            //{
            //    Console.WriteLine(broj);
            //}

            ////najveci broj:
            //Console.WriteLine($"Najveci broj u nizu je: {brojevi.Max()}");
            ////najmanji broj:
            //Console.WriteLine($"Najmanji broj u nizu je: {brojevi.Min()}");
            ////Prosek brojeva:
            //Console.WriteLine($"Prosek svih brojeva u nizu je: {brojevi.Average()}");

            //zadatak 2

            //string najduzaRec = reci[0];

            //foreach (string rec in reci)
            //{
            //    if (rec.Length > najduzaRec.Length)
            //    {
            //        najduzaRec = rec;
            //    }
            //}

            //Console.WriteLine("Najduža reč: " + najduzaRec + " (dužina: " + najduzaRec.Length + ")");


            string[] reci = { "jabuka", "banana", "kivi", "ananas" };
            int[] brojevi = { 1, 2, 4, 357, 88 };
            //Array.Sort(reci);
            //foreach(var rec in reci)
            //{
            //    Console.WriteLine(rec);
            //}

            //foreach(var rec in reci)
            //{
            //    Console.WriteLine(rec); 
            //}
            
            Array.Sort(brojevi);
            //Array.Reverse(brojevi);

            foreach (int i in brojevi)
            {
                Console.WriteLine(i);
            }

            //for (int i = 0; i < brojevi.Length; i++)
            //{
            //    if (brojevi[i] % 2 == 0)
            //    {
            //        Console.WriteLine(brojevi.Sum());
            //        break;
            //    }
            //}

            //OrderBy(brojevi)
        }
    }
}
