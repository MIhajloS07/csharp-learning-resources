using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_i_Set_metode
{

    class Storage
    {
        private string _name;
        private int _number;
        private char _char;
        private byte _byte;
        public short _short;
        public long _long;

        // Svojstva -> Properties
        public string Name { get { return _name; } set { _name = value; } }
        public int Number { get { return _number; } set { _number = value; } }
        public char Char { get { return _char; } set { _char = value; } }
        public byte Byte { get { return _byte; } set { _byte = value; } }
        public short Short { get { return _short; } set { _short = value; } }
        public long Long { get; set; }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage();
            storage.Name = "test";  
            Console.WriteLine(storage.Name);
            storage.Number = 1;
            Console.WriteLine(storage.Number);
            storage.Char = 'a';
            Console.WriteLine(storage.Char);
            storage.Byte = 5;
            Console.WriteLine(storage.Byte);    
            storage.Short = 6;
            Console.WriteLine(storage.Short);
            storage.Long = 7;
            Console.WriteLine(storage.Long);
            Console.WriteLine(storage._short);

        }
    }
}
