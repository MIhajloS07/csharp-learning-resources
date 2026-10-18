using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Struktura_za_rad_sa_vremenom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan span = new TimeSpan(1, 30, 25); // 1h 30m 25s
            //TimeSpan th = TimeSpan.FromHours(1); 
            //TimeSpan tm = TimeSpan.FromMinutes(30); 
            //TimeSpan ts = TimeSpan.FromSeconds(25);

            //TimeSpan t1 = TimeSpan.FromMinutes(25);
            //TimeSpan t2 = TimeSpan.FromMinutes(45);
            //TimeSpan zbir = t1 + t2; Console.WriteLine(zbir);
            //if (t1 < t2) Console.WriteLine("Vreme t1 je manje od vremena t2");
            //else Console.WriteLine("Vreme t1 je vece od vremena t2");

            //DateTime pocetak = DateTime.Now;
            //DateTime kraj = pocetak.AddMinutes(25);

            //TimeSpan razlika = kraj - pocetak;
            //Console.WriteLine(razlika);

            //1.
            //int hours = int.Parse(Console.ReadLine());
            //int minutes = int.Parse(Console.ReadLine());
            //int seconds = int.Parse(Console.ReadLine());
            //TimeSpan span = new TimeSpan(hours, minutes, seconds);
            //Console.WriteLine($"Ukupno trajanje filma je: {span.Hours} sati {span.Minutes} minuta i {span.Seconds} sekundi");
            //2.
            //int minutesT1 = int.Parse(Console.ReadLine());
            //int minutesT2 = int.Parse(Console.ReadLine());
            //TimeSpan t1 = TimeSpan.FromMinutes(minutesT1);
            //TimeSpan t2 = TimeSpan.FromMinutes(minutesT2);
            //TimeSpan razlika = t1 - t2;
            //Console.WriteLine(razlika);
            //3.
            //TimeSpan span = new TimeSpan(5, 30, 0);
            //for(; ; )
            //{
            //    span = span.Add(TimeSpan.FromSeconds(1));
            //    Console.WriteLine(span.ToString());
            //    Thread.Sleep(1000);
            //}
            //4.
            //double duzinaPutaKm = double.Parse(Console.ReadLine());
            //double prosecnaBrzinaKm = double.Parse(Console.ReadLine());
            //if (prosecnaBrzinaKm <= 0)
            //{
            //    Console.WriteLine("Brzina mora biti veća od 0!");
            //    return;
            //}
            //double vreme = (double)duzinaPutaKm / (double)prosecnaBrzinaKm;
            //TimeSpan vremeSpan = TimeSpan.FromHours(vreme);
            //Console.WriteLine(
            //    $"{Math.Round(vremeSpan.TotalHours, 2)}sati, " +
            //    $"{Math.Round(vremeSpan.TotalMinutes, 2)}minuta, " +
            //    $"{Math.Round(vremeSpan.TotalSeconds, 2)}sekundi"
            //);
        }
    }
}
