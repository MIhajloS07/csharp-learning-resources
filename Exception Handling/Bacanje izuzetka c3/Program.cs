using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacanje_izuzetka_cs
{
    internal class Program
    {
        //static void ValidacijaGodina(int god)
        //{
        //    if (god < 16 || god > 19)
        //    {
        //        throw new ArgumentException("Broj mora biti u opsegu od 16 do 19");              
        //    }
        //    Console.WriteLine("Uneti broj godina je validan.");
        //}
        static void Metoda1()
        {
            try
            {
                int broj = int.Parse("abc"); // FormatException
            }
            catch (FormatException ex)
            {
                // Prva obrada — lokalno logujemo grešku
                Console.WriteLine("Log: Greška u Metoda1 -> " + ex.Message);
                // Prosleđujemo izuzetak naviše
                throw;
            }
        }
        static void Main(string[] args)
        {
            //int godine = 13;
            //do
            //{              
            //    try
            //    {
            //        Console.Write("Unesi broj godina: "); godine = int.Parse(Console.ReadLine());
            //        ValidacijaGodina(godine);
            //        Console.WriteLine("Imas " + godine + " godina");
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine("GRESKA: broj je unet u pogresnom formatu");
            //        Console.WriteLine("Detalji greske: " + ex.Message);
            //    }
            //    catch (OverflowException ex)
            //    {
            //        Console.WriteLine("GRESKA: broj je previse mali ili previse veliki za dati tip podatka");
            //        Console.WriteLine("Detalji greske: " + ex.Message);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("GRESKA: " + e.Message);
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Kraj programa.");
            //    }
            //} while (godine != 0);

            try
            {
                Metoda1();
            }
            catch (FormatException ex)
            {
                // Druga obrada — globalno obaveštavamo korisnika
                Console.WriteLine("Greška prilikom obrade broja! Pokušajte ponovo.");
                Console.WriteLine("Detalji (za developera): " + ex.Message);
            }

        }
    }
}
