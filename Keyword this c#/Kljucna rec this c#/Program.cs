using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kljucna_rec_this_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Miki",17);
            Person p2 = new Person("Zoran", 16);
            Console.WriteLine(p2.grad);
        }
    }

    class Person
    {
        public string ime;
        public int godine;
        public string grad;
        public Person(string ime,int godine,string grad)
        {
            this.ime = ime;
            this.godine = godine;
            this.grad = grad;
        }

        public Person(string ime,int godine) : this(ime,godine,"Leskovac")
        {
        }
    }
}
