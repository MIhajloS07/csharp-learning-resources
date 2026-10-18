using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericke_liste
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public byte Razred { get; set; }    
        public Ucenik(string ime, byte razred) 
        {
            this.Ime = ime;
            this.Razred = razred;
        }
        public override string ToString() => $"Ime: {Ime}, razred: {Razred}";
    }
}
