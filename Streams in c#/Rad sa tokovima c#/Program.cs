using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad_sa_tokovima_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string putanja = @"D:\Tokovi.txt";

            using (StreamWriter sw = new StreamWriter(putanja)) 
            {
                sw.WriteLine("Pozdrav");
            }

            using (StreamReader sr = new StreamReader(putanja))
            {
                string sadrzaj = sr.ReadToEnd();
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linija);
                }
            }
        }
    }
}
