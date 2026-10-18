using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije_c_
{
    internal class Program
    {
        //enum StanjeServera { ukljucen = 1, onlajn = 1, iskljucen = 0, oflajn = 0, greska = 0 };
        //enum Nastava { sep = 9, okt, nov, dec, jan = 1, feb, mar, apr, maj, jun };
        //enum GodisnjeDoba
        //{
        //    Prolece,
        //    Leto,
        //    Jesen,
        //    Zima
        //}

        //enum Semafor : byte { crveno, zuto, zeleno }


        enum StatusPorudzbine : byte
        {
            Primljena,      //0
            UPripremi,      //1
            Poslata,        //2
            Dostavljena,    //3
            Otkazana        //4
        }

        static void Main(string[] args)
        {
            //StanjeServera server = StanjeServera.ukljucen;
            //StanjeServera serverDrugi = StanjeServera.oflajn;
            //Console.WriteLine(serverDrugi);
            //Semafor stanje;
            //string izbor; Console.WriteLine("Unesi stanje semafora (crveno,zuto ili zeleno): ");
            //izbor = Console.ReadLine();
            //izbor = izbor.ToLower(); // Konvertujemo u mala slova


            //    if (izbor == "crveno")
            //    {
            //        stanje = Semafor.crveno;
            //    }
            //    else if (izbor == "zuto")
            //    {
            //        stanje = Semafor.zuto;
            //    }
            //    else if (izbor == "zeleno")
            //    {
            //        stanje = Semafor.zeleno;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nepoznata vrednost!");
            //        return; // izlaz iz programa ako je unos pogrešan
            //    }


            //switch (stanje)
            //    {
            //        case Semafor.crveno:
            //            Console.WriteLine("Stani!");
            //            break;
            //        case Semafor.zuto:
            //            Console.WriteLine("Pripremi se!");
            //            break;
            //        case Semafor.zeleno:
            //            Console.WriteLine("Kreni!");
            //            break;
            //    }

            StatusPorudzbine status = StatusPorudzbine.Otkazana;
            
            switch (status)
            {
                case StatusPorudzbine.Otkazana:
                    Console.WriteLine("Porudzbina otkazana");
                    break;
                case StatusPorudzbine.Poslata:
                    Console.WriteLine("Porudzbina poslata");
                    break;
                case StatusPorudzbine.Primljena:
                    Console.WriteLine("Porudzbina primljena");
                    break;
                case StatusPorudzbine.UPripremi:
                    Console.WriteLine("Porudzbina u pripremi");
                    break;
                case StatusPorudzbine.Dostavljena:
                    Console.WriteLine("Porudzbina dostavljena");
                    break;
                default:
                    Console.WriteLine("Nepostojeci podatak");
                    break;
            }

            int broj = (int)status; //type casting
            Console.WriteLine(broj); //4
            broj--;
            Console.WriteLine(broj); //3



        }
    }
}
