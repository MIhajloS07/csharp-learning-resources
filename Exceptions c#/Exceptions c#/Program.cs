using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] ints = { 1, 2, 3, 4, 5 };

            //// Testira se odredjeni kod na greske
            //try
            //{
            //    Console.WriteLine(ints[15]);
            //}
            //// hvata gresku ukoliko je ima i vrsi neku obradu (u ovom slucaju ispis greske)
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            ////izvrsava se bilo da ima greske ili nema
            //finally 
            //{ 
            //    Console.WriteLine("Ja se izvrsavam bez obzira na gresku!");
            //}


            //Primer

            Console.Write("Unesi neki broj: ");

           
            try
            {
                int broj = int.Parse(Console.ReadLine());
                Console.WriteLine("Unet broj je: " + broj);
            }
            catch (FormatException)
            {
                Console.WriteLine("Doslo je do greske!");
            finally
            finally
            finally
            {
                Console.WriteLine("Izlaz iz aplikacije...");
            }
     
        }
    }
}
