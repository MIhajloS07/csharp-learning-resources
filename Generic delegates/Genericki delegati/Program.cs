using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericki_delegati
{
    internal class Program
    {
        // Action<T> -> uzima jedan parametar tipa T i ne vraca rezultat 
        // Predicate<T> -> uzima jedan parametar tipa T i vraca bool vrednost 
        // Func<T, TResult>  -> uzima jedan parametar tipa T i vraca rezultat TResult tipa 
        static Func<int, string> intUString = KonvertujIntUString;
        static Predicate<int> ProveraParnostiDelegat = DaLiJeParan;
        static Action<int> IspisVrednostiDelegat = Ispis;
        
        delegate T Dupliraj<T>(T parametar);
        static bool DaLiJeParan (int x) => x % 2 == 0;
        static void Ispis(int broj)
        {
            Console.WriteLine(broj);
        }
        static void IspisDrugi(int broj)
        {
            Console.WriteLine(broj);
        }
        static string KonvertujIntUString(int number) => number.ToString();
        static int Kvadriraj(int x) => x * x;
        static string Ponovi(string s) => s + s;
        static void Main(string[] args)
        {
            //Dupliraj<int> intDelegat = null;
            //Dupliraj<string> stringDelegat = null;
            //intDelegat += Kvadriraj;
            //stringDelegat += Ponovi;
            //Console.WriteLine(intDelegat(5));
            //Console.WriteLine(stringDelegat("Pozz"));
            int num = 122;
            // delegat intUString poziva metodu KonvertujIntUString koja konvertuje int u string:
            //Console.WriteLine(intUString(num));
            //Console.WriteLine(ProveraParnostiDelegat(num));
            IspisVrednostiDelegat += IspisDrugi;
            IspisVrednostiDelegat(num); //122 122
        }
    }
}
