using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koriscenje_izuzetaka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi broj godina: ");
            try
            {
                int korisnickiUnos = int.Parse(Console.ReadLine());
                Console.WriteLine($"Broj godina: {korisnickiUnos}");
            }
            catch (FormatException e)
            {
                Console.WriteLine(":: Uneli ste broj u pogresnom formatu ::"); 
                Console.WriteLine("Detalji greske: " + e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Uneli ste broj koji je van opsega podatka");
                Console.WriteLine("Ceo broj mora biti u opsegu od -2147483648 do 2147483647.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Desila se greska: " + e);
            }
            finally
            {
                Console.WriteLine("Hvala sto ste koristili nasu app...");
            }
        }
    }
}
