using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukture_c_
{
    internal class Program
    {
        struct Tacka
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Tacka(int X,int Y)
            {
                this.X = X;
                this.Y = Y; 
            }
            public void PrikaziKoordinatu()
            {
                Console.WriteLine($"Koordinate su ({X},{Y})!");
            }

        }

        struct Covek
        {
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public int BrojGodina { get; set; }
            public void IspisCoveka()
            {
                Console.WriteLine($"Ime: {Ime} | Prezime: { Prezime } | Broj godina {BrojGodina}");
            }
        }

        static void Main(string[] args)
        {
            //Tacka t1 = new Tacka(5,10);
            //t1.PrikaziKoordinatu();
            Covek covek = new Covek();
            covek.BrojGodina = 10;
            covek.Ime = "Goran";    
            covek.Prezime = "Goranovic";
            covek.IspisCoveka();


        }
    }
}
