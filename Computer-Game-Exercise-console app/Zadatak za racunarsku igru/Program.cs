using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_za_racunarsku_igru
{
    /*
        Milan i Dejan su rešili da unaprede moci svojih likova u njihovoj omilje
        noj racunarskoj igri. Milan je, zato, kupio k spellova po ceni od x zlatnika za spell,
        a Dejan je kupio n healthova po ceni od y zlatnika za health. Napisati C# program
        koji od korisnika ucitava brojeve k, x, n i y, i utvrdjuje ko je potrošio više zlatnika
        i za koliko. Ukoliko su Milan i Dejan potrošili istu kolicinu zlata na unapredjivanje
        svojih likova, program treba da ispiše “Isto”
    */

    internal class Program
    {
        static double IzracunajZlatnike(double moc,double brojZlatnika)
        {
            return moc * brojZlatnika;
        }

        static void Main(string[] args)
        {
            double k,x,n,y;

            Console.Write("Koliko je Milan kupio spellova: ");
            k = double.Parse(Console.ReadLine());
            Console.Write("Koliko Milan ima zlatnika: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Koliko je Dejan kupio healthova: ");
            n = double.Parse(Console.ReadLine());
            Console.Write("Koliko Dejan ima zlatnika: ");
            y = double.Parse(Console.ReadLine());

            double Milan = IzracunajZlatnike(k, x);
            double Dejan = IzracunajZlatnike(n, y);

            if(Milan > Dejan)
            {
                Console.WriteLine($"Milan je potrosio vecu sumu zlata od Dejana i to za {Milan - Dejan}");
            }
            else if (Milan < Dejan)
            {
                Console.WriteLine($"Dejan je potrosio vecu sumu zlata od Milana i to za {Dejan - Milan}");
            }
            else
            {
                Console.WriteLine("Isto");
            }
        }
    }
}
