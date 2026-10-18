using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Višenamenski_kalkulator_sa_menijem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //izborni meni
            Console.WriteLine("+-------------------------+");
            Console.WriteLine("|     INTERAKTIVNI MENI   |");
            Console.WriteLine("|                         |");
            Console.WriteLine("|   1.Sabiranje           |");
            Console.WriteLine("|   2.Oduzimanje          |");
            Console.WriteLine("|   3.Mnozenje            |");
            Console.WriteLine("|   4.Deljenje            |");
            Console.WriteLine("|   5.Koren broja         |");
            Console.WriteLine("|   6.Stepenovanje        |");
            Console.WriteLine("|   7.Izlaz               |");
            Console.WriteLine("|                         |");
            Console.WriteLine("+-------------------------+");

            //Kreiranje funkcionalnosti
            int izbor;
            bool running = true;
            while(running) { 
            try
            {
                do
                {
                    double brojJedan, brojDva;
                    Console.Write("Unesi izbor: "); izbor = Convert.ToInt32(Console.ReadLine());
                    switch (izbor)
                    {
                        case 1:
                            Console.Write("Unesi prvi broj: "); brojJedan = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Unesi drugi broj: "); brojDva = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine($"Zbir brojeva {brojJedan} i {brojDva} je: {brojJedan + brojDva}");
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.Write("Unesi prvi broj: "); brojJedan = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Unesi drugi broj: "); brojDva = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine($"Razlika brojeva {brojJedan} i {brojDva} je: {brojJedan - brojDva}");
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.Write("Unesi prvi broj: "); brojJedan = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Unesi drugi broj: "); brojDva = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine($"Mnozenje brojeva {brojJedan} i {brojDva} je: {brojJedan * brojDva}");
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.Write("Unesi prvi broj: "); brojJedan = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Unesi drugi broj: "); brojDva = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("-----------------------------");
                            if (brojDva == 0)
                            {
                                Console.WriteLine("Greška: Deljenje nulom nije dozvoljeno!");
                            }
                            else
                            {
                                Console.WriteLine($"Kolicnik brojeva {brojJedan} i {brojDva} je: {Math.Round(brojJedan / brojDva, 2)}");
                            }
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine();
                            break;
                        case 5:
                            Console.Write("Unesi broj: "); brojJedan = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine($"Kvadratni koren broja {brojJedan} je: {Math.Round(Math.Sqrt(brojJedan), 2)}");
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine();
                            break;
                        case 6:
                            Console.Write("Unesi prvi broj: "); brojJedan = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Unesi drugi broj: "); brojDva = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine($"Stepenovanje broja {brojJedan} ^ {brojDva} je: {Math.Pow(brojJedan, brojDva)}");
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine();
                            break;
                        case 7:
                            running = false;
                            break;
                            default:
                                Console.WriteLine("-----------------------------");
                                Console.WriteLine("Pogresan unos,probaj ponovo!");
                                Console.WriteLine("-----------------------------");
                                break;
                        }
                } while (izbor != 7);
            }
            catch (FormatException)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Unos nije validan broj!");
                Console.WriteLine("-----------------------------");
            }
        }
            Console.WriteLine();
            Console.WriteLine("Izlaz iz aplikacije... Hvala na koriscenju,posetite nas opet :)");

        }
    }
}
