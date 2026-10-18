using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rad_sa_tektualnim_fajlovima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "Hello, World!";
            //if (!File.Exists("MojFajl.txt")) // ako fajl ne postoji
            //{
            //    File.WriteAllText("MojFajl.txt", text);
            //}
            //else
            //{
            //    string procitaniText = File.ReadAllText("MojFajl.txt");
            //    File.AppendAllText("MojFajl.txt", "dodajem ovo");
            //    Console.WriteLine(procitaniText);
            //}   

            //if (!File.Exists("KopijaMojFajl.txt"))
            //{
            //    File.Move("MojFajl.txt", "KopijaMojFajl.txt");
            //    string procitanaKopija = File.ReadAllText("KopijaMojFajl.txt");
            //    Console.WriteLine(procitanaKopija);
            //}

            //File.Delete(putanja); -> Brise fajl sa odredjenog patha (putanje)
            //File.Create(putanja); -> Kreira fajl na odredjenom pathu (putanju)
            //File.Exists(putanja); -> Proverava da li fajl postoji na odredjenoj destinaciji
            //File.ReadAllText(putanja); -> Cita sve sa fajla i vraca tekst kao string
            //File.WriteAllText(putanja,string); -> Kreira fajl na datoj putanji i upisuje dati string u njega
            //File.AppendAllText(putanja,string); -> Dodaje dati string na kraj postojeceg fajla (putanje)
            //File.Move(sourcePath,destPath); -> Premesta dati fajl na novu lokaciju (novu putanju)
            //File.Copy(sourcePath, destPath, bool overwrite); -> Kopira dati fajl na drugoj destinaciji uz proveru bool vrednosti da li fajl postoji

            //try
            //{
            List<string> list = new List<string>();
            list.Add("Zoran");
            list.Add("Goran");
            list.Add("Boban");

            string[] linijeZaUpis =
            {
                    "Mihajlo Stoiljkovic",
                    "mihajlostoiljkovic555@gmail.com",
                    "mikaadja"
                };

            //    if (File.Exists(@"C:\Imenik\podaci.txt"))
            //    {
            //        Console.WriteLine("Podatak postoji");                   
            //    }
            //    else
            //    {
            //        File.WriteAllLines(@"C:\Imenik\Podaci.txt", list);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("GRESKA,PROVERI DA LI SI KREIRAO DIREKTORIJUM!" + e);
            //}
            //string[] procitanFajl = File.ReadAllLines(@"C:\Imenik\Podaci.txt");

            //foreach(string linija in procitanFajl)
            //{
            //    Console.WriteLine(linija);
            //}

            //string[] strings = { "Mihajlo", "Stoiljkovic", "0616112466" };
            //File.AppendAllLines(@"C:\Imenik\Podaci.txt", strings);
            //File.Delete(@"C:\Imenik\Podaci.txt");

            
            

            if (!File.Exists(@"C:\Imenik\Podaci.txt"))
            {
                File.WriteAllLines(@"C:\Imenik\Podaci.txt", linijeZaUpis);
            }            
            else
            {
                string[] procitanFajl = File.ReadAllLines(@"C:\Imenik\Podaci.txt");
                foreach (var element in procitanFajl)
                {
                    Console.WriteLine(element);
                }               
            }
        }
        public static void AppendList()
        {
            List<string> ListTwo = new List<string>();
            ListTwo.Add("Zdravko");
            File.AppendAllLines(@"C:\Imenik\Podaci.txt", ListTwo);
        }
    }
}
