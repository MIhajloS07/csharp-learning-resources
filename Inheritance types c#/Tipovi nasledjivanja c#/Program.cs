using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using klase;

namespace Tipovi_nasledjivanja_c_
{
    internal class Program
    {
        static void Main(string[] args)
        { 
           //IzvedenaKlasa izv = new IzvedenaKlasa();
           //izv.prikaziBrojBazne();
           //izv.prikaziBrojIzvedene();
           //izv.saberiBrojeve();
           
            //IzvedenaKlasaJedan objJedan = new IzvedenaKlasaJedan();
            //objJedan.ispisBrojaBazna();
            //objJedan.ispisBrojaIzvedenaJedan();
            
            //IzvedenaKlasaDva objDva = new IzvedenaKlasaDva();
            //objDva.ispisBrojaBazna();
            //objDva.ispisBrojaIzvedenaJedan();
            //objDva.ZbirBrojaIzvedenih();

            //IzvedenaKlasaJedan objekatJedan = new IzvedenaKlasaJedan();
            //objekatJedan.PrikaziBazniBroj();
            //objekatJedan.prikaziIzvedeniBrojJedan();
            //objekatJedan.ZbirBrojevaIzvedenaJedan();

            //IzvedenaKlasaDva objekatDva = new IzvedenaKlasaDva();
            //objekatDva.PrikaziBazniBroj();
            //objekatDva.prikaziIzvedeniBrojDva();
            //objekatDva.ZbirBrojevaIzvedenaDva();

            Ucenik uc = new Ucenik();
            uc.BrojGodina = 15;
            uc.Ime = "Zoran";
            uc.Razred = 5;
            
            Radnik radnik = new Radnik();
            radnik.BrojGodina = 50;
            radnik.RadniStaz = 25;
            radnik.Ime = "Zlatan";

            Nastavnik nastavnik = new Nastavnik();
            nastavnik.Predmet = "Programiranje";
            nastavnik.RadniStaz = 15;
            nastavnik.BrojGodina = 40;
            nastavnik.Ime = "Mihajlo";

            Osoblje osoblje = new Osoblje();
            osoblje.Ime = "Zorica";
            osoblje.RadniStaz = 15;
            osoblje.BrojGodina = 50;
            osoblje.Posao = "Cistac";
        }
    }
}

namespace klase
{
    //jednostruko nasledjivanje -> jedna izvedena klasa nasledjuje osnovnu (baznu) klasu

    //public class BaznaKlasa
    //{
    //    protected int broj = 5;

    //    public void prikaziBrojBazne()
    //    {
    //        Console.WriteLine(broj);
    //    }
    //}
    //public class IzvedenaKlasa : BaznaKlasa
    //{
    //    private int nekiBroj = 7;

    //    public void prikaziBrojIzvedene()
    //    {
    //        Console.WriteLine(nekiBroj);
    //    }
    //    public void saberiBrojeve()
    //    {
    //        Console.WriteLine($"Zbir broja {broj} i {nekiBroj} je {broj + nekiBroj}");
    //    }
    //}


    //VISESTRUKO NASLEDJIVANJE NIJE PODRZANO U C# -> U PRINCIPU TO JE TIP NASLEDJIVANJA GDE IMAMO VISE BAZNIH KLASA KOJE NEKA IZVEDENA KLASA ISTOVREMENO NASLEDJUJE

    //viseslozno nasledjivanje -> jedna izvedena klasa je nasledjena iz druge izvedene klase koja je nasledjena iz bazne...

    //public class BaznaKlasa 
    //{
    //    protected int broj = 6;
    //    public void ispisBrojaBazna()
    //    {
    //        Console.WriteLine(broj);
    //    }
    //}
    //public class IzvedenaKlasaJedan : BaznaKlasa
    //{
    //    protected int brojNeki = 8;
    //    public void ispisBrojaIzvedenaJedan()
    //    {
    //        Console.WriteLine(brojNeki);
    //    }
    //}
    //public class IzvedenaKlasaDva : IzvedenaKlasaJedan
    //{
    //    protected int brojNekiDrugi = 90;

    //    public void ZbirBrojaIzvedenih()
    //    {
    //        Console.WriteLine($"Zbir broja {brojNeki} i {brojNekiDrugi} je {brojNeki + brojNekiDrugi}");
    //    }
    //}

    //hijarhisko nasledjivanje -> tip nasledjivanja gde vise izvedenih klasa su nasledjene od jedne bazne klase (jedna bazna klasa je bazna klasa za vise izvedenih klasi)
    //public class BaznaKlasa
    //{
    //    protected int BazniBroj = 5;
    //    public void PrikaziBazniBroj()
    //    {
    //        Console.WriteLine(BazniBroj);
    //    }
    //}
    //public class IzvedenaKlasaJedan : BaznaKlasa
    //{
    //    private int IzvedeniBrojJedan = 15;
    //    public void prikaziIzvedeniBrojJedan()
    //    {
    //        Console.WriteLine(IzvedeniBrojJedan);
    //    }
    //    public void ZbirBrojevaIzvedenaJedan()
    //    {
    //        Console.WriteLine($"Zbir broja {BazniBroj} i {IzvedeniBrojJedan} je {BazniBroj + IzvedeniBrojJedan}");
    //    }
    //}
    //public class IzvedenaKlasaDva : BaznaKlasa 
    //{
    //    private int IzvedeniBrojDva = 23;
    //    public void prikaziIzvedeniBrojDva()
    //    {
    //        Console.WriteLine(IzvedeniBrojDva);
    //    }
    //    public void ZbirBrojevaIzvedenaDva()
    //    {
    //        Console.WriteLine($"Zbir broja {BazniBroj} i {IzvedeniBrojDva} je {BazniBroj + IzvedeniBrojDva}");
    //    }

    //}

    public class Covek
    {
        protected string ime;
        protected int brojGodina;
        public string Ime { get { return ime; } set { ime = value; } }
        public int BrojGodina
        {
            get { return brojGodina; }
            set { brojGodina = value; }
        }
    }
    public class Ucenik : Covek
    {
        private int razred; // 1 - 8       
        public int Razred {  get { return razred; } set { razred = value; } }   
    }
    public class Radnik : Covek
    {
        protected int radniStaz;
        public int RadniStaz { get { return radniStaz; } set { radniStaz = value; } }       
    }
    public class Nastavnik : Radnik
    {
        private string predmet;
        public string Predmet { get { return predmet;   } set { predmet = value; } }    
    }
    public class Osoblje : Radnik
    {
        private string posao;
        public string Posao { get { return posao; } set { posao = value; } }    
    }
}
