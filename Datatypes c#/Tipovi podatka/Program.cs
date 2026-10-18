using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipovi_podatka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //celobrojne vrednosti -> celobrojni tipovi podatka
            int nekiInt = 56; // 4B
            long nekiLong = 3883489739893l; // L(l) moze i ne mora stojati na kraju kada stavaljamo long vrednost -> 8B
            short nekiShort = 32000; // -> 2B
            byte nekiByte = 100; // samo pozitivni brojevi -> 1B

            //floating point vrednosti (realni brojevi) -> floating point tipovi podatka
            float nekiFloat = 5.234f; // F(f) mora stojati na kraju kada stavljamo float vrednost -> 4B
            double nekiDouble = 7.8348345983d; // D(d) moze i ne mora stojati na kraju kada stavljamo double vrednost -> 8B
            decimal nekiDecimal = 1.34858893458934895m; // M(m) mora stojati na kraju decimal vrednosti -> 16B

            //Logicki tip podatka -> boolean (true/false)
            bool nekiBooleanFalse = false; // 0 -> 1B
            bool nekiBooleanTrue = true; // 1 -> 1B

            //Karakteri -> C# koristi unicode karaktere (UTF-16) pa tako svaki karakter zauzima 2B
            char nekiChar = 'A'; // Pisu se u single quottes odnosno u jednostrukim navodnicima -> 2B 

            //Tekstualni tipovi podatka -> string (niz karaktera) -> u C# je string klasa koja sadrzi razne metode za rad sa stringovima
            string nekiString = "Mihajlo"; // Pisu se u double quottes odnosno u dvostrukim navodnicima -> 2B po karakteru

            //Specificni brojevi
            //Specificno slovo E koje naglasava stepenovanje broja 10 -> Na primer: ako je ispred E(e) broj 2, to je kao 10 ^ 2
            float nekiDrugiFloat = 10e3f; // -> 10e3 = 10 * 10^3 = 10000

            //signed i unsigned tipovi
            sbyte signedByte = -120; // 1B -> -128 - 127 (signed byte -> imamo i pozitivne i negativne vrednosti)
            ushort unsignedShort = 32000; // 2B -> 0 - 65535 (unsigned short -> imamo samo pozitivne vrednosti ukljucujuci i 0)
            uint unsignedint = 2342; // 4B -> 0 - 4294....295 (unsigned int -> imamo samo pozitivne vrednosti ukljucujuci i 0)
            ulong unsignedlong = 345345; // 8B -> 0 - 1844...... (unsigned long -> imamo samo pozitivne vrednosti ukljucujuci i 0)

            //Konkatenacija stringova -> spajanje stringova 
            //Primer:
            Console.WriteLine("Ime: " + nekiString + " !");
            Console.WriteLine($"Ime: {nekiString} !");

            //Mozemo vrsiti i spajanje drugih vrednosti 
            //Primer za int:
            Console.WriteLine("Broj: " + nekiInt + nekiInt + " integer");

            //Vracanje tipa podatka u ispisu -> metoda getType()
            Console.WriteLine(); // prazna komanda -> ispis u novi red
            Console.WriteLine("Broj: " + nekiInt + " -> " + nekiInt.GetType());
            Console.WriteLine("Broj: " + nekiLong + " -> " + nekiLong.GetType());
            Console.WriteLine("Broj: " + nekiShort + " -> " + nekiShort.GetType());
            Console.WriteLine("Broj: " + nekiByte + " -> " + nekiByte.GetType());
            Console.WriteLine("Realni broj: " + nekiFloat + " -> " + nekiFloat.GetType());
            Console.WriteLine("Realni broj: " + nekiDrugiFloat + " -> " + nekiDrugiFloat.GetType());
            Console.WriteLine("Realni broj: " + nekiDouble + " -> " + nekiDouble.GetType());
            Console.WriteLine("Realni broj: " + nekiDecimal + " -> " + nekiDecimal.GetType());
            Console.WriteLine("Logicki tip: " + nekiBooleanFalse + " -> " + nekiBooleanFalse.GetType());
            Console.WriteLine("Logicki tip: " + nekiBooleanTrue + " -> " + nekiBooleanTrue.GetType());
            Console.WriteLine("Karakter: " + nekiChar + " -> " + nekiChar.GetType());
            Console.WriteLine("Rec: " + nekiString + " -> " + nekiString.GetType());

            //koriscenje sizeof() funkcije koja vraca velicinu tipa podatka u bajtima (B) -> npr System.Int32 -> 32bit -> 4B
            Console.WriteLine();
            Console.WriteLine("Velicina tipova u bajtima:");
            Console.WriteLine("Int -> " + sizeof(int) + "B"); 
            Console.WriteLine("short -> " + sizeof(short) + "B"); 
            Console.WriteLine("byte -> " + sizeof(byte) + "B"); 
            Console.WriteLine("Long -> " + sizeof(long) + "B"); 
            Console.WriteLine("Float -> " + sizeof(float) + "B"); 
            Console.WriteLine("Double -> " + sizeof(double) + "B"); 
            Console.WriteLine("Decimal -> " + sizeof(decimal) + "B"); 
            Console.WriteLine("Char -> " + sizeof(char) + "B" + " UNICODE CHARACTERS (UTF-16)"); 
            Console.WriteLine("Bool -> " + sizeof(bool) + "B" + " (nije uvek precizno definisano)");

            //koriscenje typeof() operatora koji vraca tip podatka -> npr int -> System.Int32
            Console.WriteLine($"Tip podatka je: {typeof(int)}");
            Console.WriteLine($"Tip podatka je: {typeof(short)}");
            Console.WriteLine($"Tip podatka je: {typeof(byte)}");
            Console.WriteLine($"Tip podatka je: {typeof(long)}");
            Console.WriteLine($"Tip podatka je: {typeof(float)}");
            Console.WriteLine($"Tip podatka je: {typeof(double)}");
            Console.WriteLine($"Tip podatka je: {typeof(char)}");
            Console.WriteLine($"Tip podatka je: {typeof(bool)}");

            //automatsko dodeljivanje tipa podatka kljucnom recju var
            var karakter = 'a'; // char
            var decimalnibroj = 23.45345m; // decimal

            Console.WriteLine(karakter.GetType()); //System.Char
            Console.WriteLine(decimalnibroj.GetType());//System.Decimal

            //promena boje pozadine u konzoli
            Console.BackgroundColor = ConsoleColor.Blue;
        }
    }
}
