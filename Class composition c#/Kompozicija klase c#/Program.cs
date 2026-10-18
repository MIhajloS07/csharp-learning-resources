using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozicija_klase_c_
{
    class Adresa
    {
        public string Ulica {  get; set; }
        public string Grad { get; set; }    
        public int PostanskiBroj { get; set; }

        public Adresa(string ulica, string grad, int postanskiBroj)
        {
            Ulica = ulica;
            Grad = grad;
            PostanskiBroj = postanskiBroj;
        }

        public string PrikaziAdresu()
        {
            return $"Ulica: {Ulica} | Grad: {Grad} |  Poštanski broj: {PostanskiBroj}";
        }
    }

    class Osoba
    {
        public Adresa AdresaOsobe { get; set; }
        public string Ime { get; set; }
        public int Godine { get; set; }

        public Osoba (string ime,byte godine, Adresa adresa)
        {
            this.Ime = ime;
            this.Godine = godine;
            this.AdresaOsobe = adresa;
        }
        public void PrikaziPodatke()
        {
            Console.WriteLine($"Ime: {Ime} | Godine: {Godine} | Adresa: {AdresaOsobe.PrikaziAdresu()}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Adresa adresa1 = new Adresa("Nemanjina 10", "Beograd", 11000);
            Adresa adresa2 = new Adresa("Cara Dušana 5", "Novi Sad", 21000);

            // Kreiramo osobe sa adresama
            Osoba osoba1 = new Osoba("Milan", 25, adresa1);
            Osoba osoba2 = new Osoba("Ana", 30, adresa2);

            // Prikaz podataka
            osoba1.PrikaziPodatke();
            osoba2.PrikaziPodatke();
        }
    }
}
