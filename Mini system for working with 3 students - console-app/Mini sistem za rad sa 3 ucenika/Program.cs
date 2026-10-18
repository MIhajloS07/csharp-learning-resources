
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_sistem_za_rad_sa_3_ucenika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] imena = new string[3];
            int[,] ocene = new int[3, 3];
            double najboljiProsek = 0;
            string najboljiUcenik = "";

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Unesi ime " + (i + 1) + ". ucenika: ");
                imena[i] = Console.ReadLine();

                for(int j = 0; j < 3; j++)
                {
                    Console.Write("Unesi " + (j + 1) + ". ocenu " + (i + 1) + ". ucenika: ");
                    ocene[i,j] = Convert.ToInt32(Console.ReadLine()); //convert u int i unos korisnika
                }
                Console.WriteLine("----------------------------");
                Console.WriteLine();
            }
            double prosek = 0;
            for (int i = 0; i < 3; i++) 
            {
                int zbir = 0;
                for(int j = 0; j < 3; j++)
                {
                    zbir += ocene[i,j];
                    
                }
                prosek = zbir / 3.0;

                Console.WriteLine($"Učenik: {imena[i]} - Prosek: {Math.Round(prosek, 2)}");

                if (prosek > najboljiProsek)
                {
                    najboljiProsek = prosek;
                    najboljiUcenik = imena[i];
                }
            }      
            Console.WriteLine($"\nNajbolji učenik je: {najboljiUcenik} sa prosekom {Math.Round(najboljiProsek, 2)}");
        }
    }
}
