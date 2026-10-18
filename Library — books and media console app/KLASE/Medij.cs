using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLASE
{
    public class Medij
    {
        public string Naslov;
        protected int GodinaIzdavanja;
        private string ISBN;

        //konstruktor
        public Medij(string Naslov, int GodinaIzdavanja, string ISBN)
        {
            this.Naslov = Naslov;
            this.GodinaIzdavanja = GodinaIzdavanja;
            this.ISBN = ISBN;
        }
        public void PrikaziPodatke()
        {
            Console.Write($"Naslov: {this.Naslov} | Godina izdavanja: {this.GodinaIzdavanja} | ISBN: {this.ISBN} ");
        }
        protected void PromeniGodinu(int novaGodina) => GodinaIzdavanja = novaGodina;
    }
    public class Knjiga : Medij
    {
        public string Autor;
        public int BrojStrana;

        public Knjiga (string Naslov, int GodinaIzdavanja, string ISBN, string Autor, int BrojStrana) 
            : base (Naslov, GodinaIzdavanja, ISBN)
        {
            this.Autor = Autor;
            this.BrojStrana = BrojStrana;
        }

        public void PrikaziDetalje() 
        {
            // Poziv javne metode iz bazne klase "Medij"
            PrikaziPodatke();
            Console.WriteLine($"| Autor: {this.Autor} | Broj strana: {this.BrojStrana}");
            Console.WriteLine();
        }
    }
    public class Casopis : Medij
    {
        public int BrojIzdanja;
        public string MesecIzdanja;

        public Casopis (string Naslov, int GodinaIzdavanja, string ISBN, int BrojIzdanja, string MesecIzdanja) 
            : base(Naslov, GodinaIzdavanja, ISBN)
        {
            this.BrojIzdanja = BrojIzdanja;
            this.MesecIzdanja= MesecIzdanja;
        }

        public void PrikaziDetalje()
        {
            // Poziv javne metode iz bazne klase "Medij"
            PrikaziPodatke();
            Console.WriteLine($"| Broj izdanja: {this.BrojIzdanja} | Mesec izdanja: {this.MesecIzdanja}");
            Console.WriteLine();
        }
    }
    public class DVD : Medij
    {
        public string Reziser;
        public int TrajanjeMinuta;

        public DVD (string Naslov, int GodinaIzdavanja, string ISBN, string Reziser, int TrajanjeMinuta)
            : base(Naslov, GodinaIzdavanja, ISBN)
        {
            this.Reziser = Reziser;
            this.TrajanjeMinuta = TrajanjeMinuta;
        }

        public void PrikaziDetalje() 
        {
            // Poziv javne metode iz bazne klase "Medij"
            PrikaziPodatke();
            Console.WriteLine($"| Reziser: {this.Reziser} | Trajanje(min): {TrajanjeMinuta}");
            Console.WriteLine();
        }
    }
}
