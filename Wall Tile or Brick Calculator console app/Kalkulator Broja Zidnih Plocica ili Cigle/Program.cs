using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_Broja_Zidnih_Plocica_ili_Cigle
{
    internal class Program
    {

        static int BigSurface(int bw, int bh)
        {
            return (bw * bh); // povrsina kompletnog zida
        }

        static int SmallSurface(int sw, int sh)
        {
            return (sw * sh); // povrsina zidne ploce
        }

        static int ElementPerWall(int bw, int bh, int sw, int sh)
        {
            return (BigSurface(bw, bh) / SmallSurface(sw, sh)); //broj zidnih ploca po zidu
        }

        static int TotalElements(int bw, int bh, int sw, int sh, int nw)
        {
            return (ElementPerWall(bw, bh, sw, sh) * nw); //totalni broj zidnih ploac na svim zidovima
        }
        static void Main(string[] args)
        {
            int big_width, big_height; //Jedan kompletan zid
            int small_width, small_height; // zidna ploca
            int num_walls; //broj zidova

            bool trueInput = false; // boolean vrednost za ogranicavaje tacnog unosa
            do
            {
                // Unos elemenata od korisnika
                //-----------------------------------------------------
                Console.Write("Enter width of wall (cm): "); big_width = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter height of wall (cm): "); big_height = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter small width (cm): "); small_width = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter small height (cm): "); small_height = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number of walls: "); num_walls = Convert.ToInt32(Console.ReadLine());
                //-----------------------------------------------------

                if (small_width > big_width || small_height > big_height)
                {
                    Console.WriteLine("-------------------------------------------------------------------------");
                    Console.WriteLine("Invalid input of small height or width,try again!");
                    Console.WriteLine("Small height and width must be smaller than big height and width of wall!");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    trueInput = true;
                }

            } while (!trueInput);
            // Povrsine zida i zidne ploce
            //-----------------------------------------------------
            int big = BigSurface(big_width, big_height);
            int small = SmallSurface(small_width, small_height);
            //-----------------------------------------------------

            // Broj zidnih ploca po zidu
            //-----------------------------------------------------
            int element = ElementPerWall(big_width, big_height, small_width, small_height);
            //-----------------------------------------------------

            // Totalni broj zidnih ploca
            //-----------------------------------------------------
            int total = TotalElements(big_width, big_height, small_width, small_height, num_walls);
            //-----------------------------------------------------

            Console.WriteLine("----------------------------------");

            // Ispis totalnog broja zidnih ploca i broj zidnih ploca po zidu kao i broj zidova
            //-----------------------------------------------------
            Console.WriteLine($"Number of walls: {num_walls}");
            Console.WriteLine($"Number of elements per wall: {element}");
            Console.WriteLine($"Total number of elements: {total}");        
            //-----------------------------------------------------
        }
    }
}
