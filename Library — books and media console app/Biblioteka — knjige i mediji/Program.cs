using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using KLASE;

namespace Biblioteka___knjige_i_mediji
{ 
    internal class Program
    {
        public static void glavniMeni()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("|           MENI           |");
            Console.WriteLine("|                          |");
            Console.WriteLine("|      1.Dodaj DVD         |");
            Console.WriteLine("|      2.Dodaj Knjigu      |");
            Console.WriteLine("|      3.Dodaj Casopis     |");
            Console.WriteLine("|      4.Ispisi sve        |");
            Console.WriteLine("|      5.Izlaz APP         |");
            Console.WriteLine("|                          |");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            DVD[] DVD = new DVD[100];
            Knjiga[] KNJIGA = new Knjiga[100];
            Casopis[] CASOPIS = new Casopis[100];

            int brojDVD = 0, brojKnjiga = 0, brojCasopisa = 0;
            int izbor;
            bool running = true;
            string naslov, ISBN;
            int GodinaIzdavanja;
            try
            {
                do
                {
                    glavniMeni();
                    Console.Write(" -> Unesi izbor -> ");
                    izbor = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (izbor)
                    {
                        //DVD
                        case 1:                          
                            int TrajanjeMinuta;
                            string Reziser;
                            Console.Write("Unesi naslov: "); naslov = Console.ReadLine();
                            Console.Write("Unesi ISBN: "); ISBN = Console.ReadLine();
                            Console.Write("Unesi Rezisera: "); Reziser = Console.ReadLine();
                            Console.Write("Unesi Godinu izdanja: "); GodinaIzdavanja = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Unesi Trajanje(min): "); TrajanjeMinuta = Convert.ToInt32(Console.ReadLine());
                            DVD[brojDVD++] = new DVD(naslov, GodinaIzdavanja, ISBN, Reziser, TrajanjeMinuta);
                            break;
                        //KNJIGA
                        case 2:
                            string Autor;
                            int BrojStrana;
                            Console.Write("Unesi naslov: "); naslov = Console.ReadLine();
                            Console.Write("Unesi ISBN: "); ISBN = Console.ReadLine();
                            Console.Write("Unesi Autora: "); Autor = Console.ReadLine();
                            Console.Write("Unesi Godinu izdavanja: "); GodinaIzdavanja = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Unesi broj strana: "); BrojStrana = Convert.ToInt32(Console.ReadLine());
                            KNJIGA[brojKnjiga++] = new Knjiga(naslov, GodinaIzdavanja, ISBN, Autor, BrojStrana);
                            break;
                        //CASOPIS
                        case 3:
                            int brojIzdanja;
                            string MesecIzdanja;
                            Console.Write("Unesi naslov: "); naslov = Console.ReadLine();
                            Console.Write("Unesi ISBN: "); ISBN = Console.ReadLine();
                            Console.Write("Unesi Godinu izdavanja: "); GodinaIzdavanja = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Unesi Mesec izdavanja: "); MesecIzdanja = Console.ReadLine();
                            Console.Write("Unesi broj izdanja: "); brojIzdanja = Convert.ToInt32(Console.ReadLine());
                            CASOPIS[brojCasopisa++] = new Casopis(naslov, GodinaIzdavanja, ISBN, brojIzdanja, MesecIzdanja);
                            break;
                        //ISPIS
                        case 4:
                            //DVD
                            Console.WriteLine(" -- DVD --");
                            for(int i = 0; i < brojDVD; i++)
                            {
                                DVD[i].PrikaziDetalje();
                            }

                            Console.WriteLine();

                            Console.WriteLine(" -- Knjige --");
                            //Knjiga
                            for (int i = 0; i < brojKnjiga; i++)
                            {
                                KNJIGA[i].PrikaziDetalje();
                            }

                            Console.WriteLine();

                            Console.WriteLine(" -- Casopisi --");
                            //casopis
                            for (int i = 0; i < brojCasopisa; i++)
                            {
                                CASOPIS[i].PrikaziDetalje();
                            }
                            break;
                        //IZLAZ
                        case 5:
                            running = false;
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("Nepostojeci unos...");
                            Console.WriteLine();
                            break;
                    }
                } while (running);
            }
            catch (Exception e) 
            {
                Console.WriteLine("GRESKA: " + e);
            }
            finally
            {
                Console.WriteLine("Hvala sto ste koristili nasu app...");
            }
        }
    }
}
