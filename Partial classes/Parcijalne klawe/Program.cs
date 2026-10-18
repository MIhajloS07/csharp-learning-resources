using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trouglovi;

namespace Parcijalne_klase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pravougli trougao = new Pravougli(4,3);
            Console.WriteLine(trougao.Obim());
            Console.WriteLine(trougao.PoluObim());
            Console.WriteLine(trougao.Povrsina());

        }
    }
}
