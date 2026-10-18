using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi
{
    public class Osoba
    {
        public string Ime { get; set; }
        public int Godine { get; set; }
        public override string ToString()
        {
            return $"Ime: {Ime}, Godine: {Godine}";
        }
    }
}
