using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prilagodjeni_izuzeci
{
    //Prilagodjen izuzetak nasim potrebama -> kreiramo svoj izuzetak koji je nasledjen iz klase exception
    class NegativeNumberException : Exception
    {
        public NegativeNumberException() 
        {
        }
        public NegativeNumberException(string message) : base(message)
        {
        }
    }

    class MissingUserInputException : Exception
    {
        public MissingUserInputException(string message) : base(message) { }
    }

    internal class Program
    {
        //static int KvadratniKoren(int broj)
        //{
        //    if (broj < 0)
        //    {
        //        throw new NegativeNumberException(
        //            $"Nije dozvoljeno računati kvadratni koren negativnog broja, uneli ste : {broj}");
        //    }
        //    return (int)Math.Sqrt(broj);
        //}

        //static void Main()
        //{
        //    try
        //    {
        //        Console.WriteLine(KvadratniKoren(9));
        //    }
        //    catch (NegativeNumberException ex)
        //    {
        //        Console.WriteLine("Greška: " + ex.Message);
        //    }
        //}

        static void Main(string[] args)
        {
            Console.Write("Koliko imas godina (ceo broj): ");
            try
            {
                string num = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(num))
                {
                    throw new MissingUserInputException("Moras uneti broj godina!");
                }
                else
                {
                    int god = int.Parse(num);
                    Console.WriteLine("Ti imas " + god + " godina.");
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Broj je previse mali ili veliki za tip podatka");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Greska,uneti broj nije u ispravnom formatu");
                Console.WriteLine(e.Message);
            } 
            catch (Exception e)
            {
                Console.WriteLine("Greska: " + e.Message);
            }

        }
    }
}
