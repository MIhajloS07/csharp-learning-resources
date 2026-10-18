using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericke_metode
{
    internal class Program
    {
        public static void IspisiParametar<T>(T parametar)
        {
            Console.WriteLine($"Parametar: {parametar}, tip podatka {typeof(T)}");
        }
        public static void IspisiNiz<T>(T[] niz)
        {
            foreach (T element in niz)
            {
                Console.Write($"{element} ");
            }
        }
        public static void Zameni<T>(ref T parametarJedan, ref T parametarDva)
        {
            //Console.WriteLine($"Pre zamene: {parametarJedan}, {parametarDva}");
            T temp = parametarJedan;
            parametarJedan = parametarDva;
            parametarDva = temp;
            //Console.WriteLine($"Posle zamene: {parametarJedan}, {parametarDva}");
        }
        public static bool DaLiSuJednaki<T>(T parametarJedan, T parametarDva)
        {
            return parametarDva.Equals(parametarJedan);
        }
        public static void SortirajRastuce<T>(T[] niz)
        {
            Array.Sort(niz);
            foreach (T element in niz)
            {
                Console.WriteLine(element);
            }
        }
        public static void SortirajOpadajuce<T>(T[] niz)
        {
            Array.Sort(niz); Array.Reverse(niz);
            foreach (T element in niz)
            {
                Console.WriteLine(element);
            }
        }
        public static void printArrays<T1, T2>(T1[] arrTOne, T2[] arrTTwo)
        {
            foreach (T1 element in arrTOne) { Console.WriteLine(element); }
            Console.WriteLine();
            foreach (T2 element in arrTTwo) { Console.WriteLine(element); }
        }
        public static void ispisVrednosti<T1, T2, T3>(T1 v1, T2 v2, T3 v3)
        {
            Console.WriteLine("{0},{1},{2}", v1, v2, v3);
        } 
        public static void SpojTriTipa<T1, T2, T3>(T1 podatakJedan, T2 podatakDva, T3 podatakTri)
        {
            Console.WriteLine($"{podatakJedan} {podatakDva} {podatakTri}");
        }
        public static string SpojiVrednosti(params object[] parametri)
        {
            return string.Join(", ", parametri);
        }
        static void Main(string[] args)
        {
            //int myInt = 4;
            //float myFloat = 6.86f;
            //string myString = "blabla";
            //IspisiParametar(myInt);
            //IspisiParametar(myFloat);
            //IspisiParametar(myString);
            //int[] niz = { 1, 2, 3 };
            //string[] strings = { "Sasa", "Igor", "Slavisa" };
            //IspisiNiz(niz);
            //Console.WriteLine();
            //IspisiNiz(strings);
            //Zameni(1, 2);
            //Console.WriteLine(DaLiSuJednaki(5,5));
            //int[] niz = { 1, 1, 9, 4, 3, 34, 5 };
            //char[] niska = { 'a', 'b', 'c', 'd' };
            //SortirajOpadajuce(niz);
            //Console.WriteLine();
            //SortirajRastuce(niz);
            //printArrays(niz, niska);
            //int a = 3; int b = 5;
            //string c = "osam", d = "sedam";
            //Zameni(ref a, ref b);
            //Zameni(ref c, ref d);
            //Console.WriteLine($"{a} {b}");
            //Console.WriteLine($"{c} {d}");
            //ispisVrednosti(3.4, Math.PI, Math.E);
            //ispisVrednosti(sizeof(double), !false, false);
            //SpojTriTipa(3.15, !true, sizeof(char));
            string res = SpojiVrednosti(1, 2.2, "tri", 'C', "Pozdrav!");
            Console.WriteLine(res);
        }
    }
}
