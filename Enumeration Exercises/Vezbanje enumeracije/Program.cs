using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje_enumeracije
{
    internal class Program
    {
        enum StanjeServera : byte
        {
            Ukljucen,
            Iskljucen,
            StanjeMirovanja,
        }
        static void Main(string[] args)
        {
            StanjeServera server = StanjeServera.StanjeMirovanja;

            Console.Write("Postavi stanje servera (Ukljucen,Iskljucen,Mirovanje): ");
            string stanje = Console.ReadLine();
            stanje = stanje.Trim().ToLower();

            ProveriStanjeServera(stanje,server);

        }
        static void ProveriStanjeServera(string serverStanje,StanjeServera server)
        {
            if (serverStanje == "mirovanje")
            {
                Console.WriteLine("Stanje mirovanja...");
                server = StanjeServera.StanjeMirovanja;
            }
            else if (serverStanje == "ukljucen")
            {
                Console.WriteLine("Server ukljucen...");
                server = StanjeServera.Ukljucen;
            }
            else if (serverStanje == "iskljucen")
            {
                Console.WriteLine("Server iskljucen...");
                server = StanjeServera.Iskljucen;
            }
            else
            {
                Console.WriteLine("Nepoznato stanje servera...");
            }
        }
    }
}
