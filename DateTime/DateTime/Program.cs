using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime d = new DateTime(2025, 12, 25);
            //Console.WriteLine(d.ToString());
            //DateTime d1 = DateTime.Now;
            //Console.WriteLine(d1.ToString());
            //DateTime d2 = DateTime.UtcNow;
            //Console.WriteLine(d2.ToString());
            //DateTime d3 = DateTime.Today;
            //Console.WriteLine(d3.ToString());
            //Console.WriteLine(d.DayOfYear);
            //Console.WriteLine(d.DayOfWeek);
            //Console.WriteLine(d.Day);
            //DateTime danas = DateTime.Today;
            //DateTime sutra = danas.AddDays(1);
            //DateTime zaSatVremena = danas.AddHours(1);
            //Console.WriteLine(zaSatVremena);
            DateTime pocetak = new DateTime(2025, 1, 1);
            //DateTime kraj = new DateTime(2025, 6, 22);
            //TimeSpan trajanje = kraj - pocetak;
            //Console.WriteLine(trajanje.Days + " dana");
            DateTime sada = DateTime.Now;
            if (sada > pocetak)
                Console.WriteLine($"Danasnji datum {sada.ToString(@"dd\:MM\:yyyy")}" +
                    $" je veci od datua {pocetak.ToString(@"dd\:MM\:yyyy")}");

        }
    }
}
