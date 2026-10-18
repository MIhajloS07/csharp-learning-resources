using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad_sa_binarnim_fajlovima_c_
{
    internal class Program
    {
        const string putanja = @"D:\BinarniFajl";
        static void Upis()
        {
            
            using (var tok = File.Open(putanja, FileMode.Create))
            {
                using (var writer = new BinaryWriter(tok))
                {
                    writer.Write("Mihajlo Stoiljkovic");
                    writer.Write(true);
                    writer.Write(17);
                    writer.Write(5.00);
                }
            }
        }
        static void Prikaz()
        {
            string ime;
            bool redovan;
            int godine;
            double prosek;
            
            if (File.Exists(putanja))
            {
                using (var tok = File.Open(putanja, FileMode.Open))
                {
                    using (var reader = new BinaryReader(tok))
                    {
                        ime = reader.ReadString();
                        redovan = reader.ReadBoolean();
                        godine = reader.ReadInt32();
                        prosek = reader.ReadDouble();
                    }
                }
                Console.WriteLine($"{ime}\r\n{redovan}\r\n{godine}\r\n{prosek}");
            }
            else
            {
                Console.WriteLine($"Fajl na putanji {putanja} ne postoji");
            }
        }
        static void Main(string[] args)
        {
            Upis();
            Prikaz();
        }
    }
}
