using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eksterne_klase;

namespace Eksterne_klase
{
    public class ExternalClass
    {
        public int x = 5;
        public int y = 10;
        public void Print() 
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("Printing...");           
        }
    }
}

namespace Custom_namespace
{
    public class Person
    {
        public string name;
        public int year;

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetYear()
        {
            return this.year;
        }
        public void PrintPerson()
        {
            Console.WriteLine($"{this.name} {this.year}");
        }
    }
    public class ExternalCopy
    {
        public void PrinterA()
        {
            ExternalClass objectClass = new ExternalClass();
            objectClass.x = 100;
            objectClass.y = 50;
            objectClass.Print();
        }             
    }
}
