using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_klasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klasa Math je jedna od klasa System namespace-a koja pruza metode za rad brojevnih vrednosti sa raznim matematickim operacijama 

            ////pronalazenje maximalnog broja od 2 arguenta (vrednosti)
            Console.WriteLine(Math.Max(5, 10)); //10
            ////pronalazenje minimalnog broja od 2 arguenta (vrednosti)
            //Console.WriteLine(Math.Min(5, 10)); //5
            ////Abosultna vrednost argumenta (vrednosti)
            //Console.WriteLine(Math.Abs(-5)); //5
            ////Kvadratni koren argumenta (vrednosti)
            //Console.WriteLine(Math.Sqrt(64)); //8
            ////Stepenovanje prvog argumenta na drugi primer: 2^3 = 8
            //Console.WriteLine(Math.Pow(2, 3)); //8
            ////Zaokruzivanje argumenta (vrednosti) na najblizi celi broj
            //Console.WriteLine(Math.Round(3.49)); //3
            //Console.WriteLine(Math.Round(3.55)); //4
            ////Skracivanje broja na ceo broj (Zaokruzivanje nanize)
            //Console.WriteLine(Math.Floor(4.98)); //4
            ////Povecanje broja na sledeci ceo broj (Zaokruzivanje navise)
            //Console.WriteLine(Math.Ceiling(5.01)); // 6
            ////Brisanje decimalnog dela
            //Console.WriteLine(Math.Truncate(5.99)); // 5


            //mini zadatak
            var numberOne = 5.23m; //decimal num
            var numberTwo = 10.13m; //decimal num

            
            bool running = true;

            while (running)
            {
                Console.WriteLine("Enter option (1 - sum, 2 - abs, 3 - pow,0 - exit): ");
                byte option = Convert.ToByte(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Exiting program...");
                        running = false;
                        break;
                    case 1:
                        Console.WriteLine("Sum of two nums is: " + (numberOne + numberTwo));
                        break;
                    case 2:
                        Console.WriteLine("Abosulute value of number one: " + Math.Abs(numberOne) + ", and number two: " + Math.Abs(numberTwo));
                        break;
                    case 3:
                        Console.WriteLine("Power numberOne ^ numberTwo is: " + Math.Pow(Convert.ToInt32(numberOne), Convert.ToInt32(numberTwo)));
                        break;
                    default:
                        Console.WriteLine("Invalid enter...Try again!");
                        break;
                }
            }
            
        }
    }
}
