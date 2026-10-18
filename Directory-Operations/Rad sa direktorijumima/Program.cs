using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rad_sa_direktorijumima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var txtExtenzije = Directory.EnumerateDirectories(@"C:\");
            //foreach(string putanja in txtExtenzije)
            //{
            //    Console.WriteLine(putanja);
            //


            
            //if (!Directory.Exists(@"D:\Direktorijum"))
            //{
            //    Directory.CreateDirectory(@"D:\Direktorijum");
            //}
            //else
            //{
            //    Console.WriteLine("Direktorijum na zadatoj putanji vec postoji...");
            //}


            //if (!File.Exists(@"D:\Direktorijum\Pismo.txt"))
            //{
            //    File.WriteAllText(@"D:\Direktorijum\Pismo.txt", "Zdravo Svete!");
            //}
            //else
            //{
            //    Console.WriteLine("Fajl na zadatoj putanji vec postoji...");
            //}

            //var Direktorijum = Directory.EnumerateFiles(@"D:\Direktorijum", "*.txt");
            //foreach(var d in Direktorijum)
            //{
            //    Console.WriteLine(d);
            //}

            DirectoryInfo dir = new DirectoryInfo(@"D:\Imenik");

            if (!dir.Exists)
            {
                dir.Create();    
            }
            else 
            {
                Console.WriteLine($"Direktorijum {dir.FullName} vec postoji...");
            }

            Console.WriteLine(dir.CreationTime);
            Console.WriteLine(dir.Name);
            FileInfo file = new FileInfo(@"D:\Direktorijum\Dokument.docx"); 
            if (!file.Exists)
            {
                file.Create();
            }
            else
            {
                file.Attributes = FileAttributes.ReadOnly;                
                var fajlovi = Directory.EnumerateFiles(@"D:\Direktorijum");
                foreach (var fajl in fajlovi)
                {
                    Console.WriteLine(fajl);
                }
            }

            if (file.IsReadOnly)
            {
                Console.WriteLine($"Fajl {file.Name} je readonly");
            }
        }
    }
}
