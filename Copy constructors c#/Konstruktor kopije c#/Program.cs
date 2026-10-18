using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor_kopije_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Osoba o1 = new Osoba("Mihajlo",17);
            //Osoba o2 = new Osoba(o1);
            //Console.WriteLine(o2.ime);
            //Console.WriteLine(o2.godine);

            Adresa a1 = new Adresa("Sterijina 40", "Vrsac 26300");
            Osoba o1 = new Osoba("Velimir Radlovacki", 1976, a1);
            Osoba o2 = new Osoba(o1);
            Console.WriteLine(o1.imePrezime + ", " + o1.godinaRodjenja +
                ", " + o1.Adresa.ulicaBroj + ", " + o1.Adresa.mestoPttBroj);
            Console.WriteLine(o2.imePrezime + ", " + o2.godinaRodjenja +
                ", " + o2.Adresa.ulicaBroj + ", " + o2.Adresa.mestoPttBroj);
        }
    }

    // Shallow copy
    //class Osoba
    //{
    //    public string ime;
    //    public int godine;

    //    public Osoba(string Ime,int Godine)
    //    {
    //        this.ime = Ime;
    //        this.godine = Godine;   
    //    }
    //    public Osoba(Osoba osobaZaKopiranje)
    //    {
    //        ime = osobaZaKopiranje.ime;
    //        godine = osobaZaKopiranje.godine;
    //    }
    //}

    // Deep copy

    class Adresa
    {
        public string ulicaBroj;
        public string mestoPttBroj;

        public Adresa(string ulbr, string mptt)
        {
            ulicaBroj = ulbr;
            mestoPttBroj = mptt;
        }

        public Adresa(Adresa adresaZaKopiranje)
        {
            ulicaBroj = adresaZaKopiranje.ulicaBroj;
            mestoPttBroj = adresaZaKopiranje.mestoPttBroj;
        }
    }

    class Osoba
    {
        public string imePrezime;
        public int godinaRodjenja;
        public Adresa Adresa;

        public Osoba(string ime, int god, Adresa adr)
        {
            imePrezime = ime;
            godinaRodjenja = god;
            Adresa = adr;
        }

        public Osoba(Osoba osobaZaKopiranje)
        {
            imePrezime = osobaZaKopiranje.imePrezime;
            godinaRodjenja = osobaZaKopiranje.godinaRodjenja;
            Adresa = new Adresa(osobaZaKopiranje.Adresa);
        } 
    }
}
