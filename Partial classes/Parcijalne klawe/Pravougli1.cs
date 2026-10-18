using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trouglovi
{
    public partial class Pravougli
    {
        private double a;
        private double b;
        private double c;
        public Pravougli(double a, double b) 
        {
            this.a = a; 
            this.b = b;
            this.c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
        }
        partial void PrintObim();
        partial void PrintPovrsina();
    }
}
