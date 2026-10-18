using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trouglovi
{
    public partial class Pravougli
    {
        public double Obim()
        {
            return Math.Round(this.a + this.b + this.c,2);
        }
        public double PoluObim()
        {
            return Math.Round((this.a + this.b + this.c) / 2, 2);
        }
        public double Povrsina()
        {
            return Math.Round((this.a * this.b) / 2,2);
        }
        partial void PrintObim()
        {
            Console.WriteLine("Obim: " + this.Obim());
        }
        partial void PrintPovrsina()
        {
            Console.WriteLine("Povrsina: " + this.Povrsina());
        }
    }
}
