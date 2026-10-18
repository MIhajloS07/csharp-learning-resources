using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulacija_podataka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bankovni_Racun racun = new Bankovni_Racun();
            Console.WriteLine(racun.PrikaziBalans());
            racun.PrilivSredstava(50.0);
            Console.WriteLine(racun.PrikaziBalans());
        }
    }

    class Bankovni_Racun
    {
        private double balans;

        public void PrilivSredstava(double iznos)
        {
            balans += iznos;
        }

        public bool OdlivSredstava(double iznos)
        {
            if(iznos < balans)
            {
                balans -= iznos;
                return true;
            }
            return false;
        }
        public double PrikaziBalans()
        {
            return balans;
        }
    }
}
