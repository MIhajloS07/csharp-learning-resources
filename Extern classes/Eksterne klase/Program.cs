using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Custom_namespace;

namespace Eksterne_klase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExternalClass obj = new ExternalClass();
            obj.Print();
            Person person = new Person();
            person.SetName("Boban");
            person.SetYear(18);
            Console.WriteLine(person.GetName());
            Console.WriteLine(person.GetYear());
            person.PrintPerson();
            Console.WriteLine("--------------------");
            person.name = "Zlatan";
            Console.WriteLine(person.GetName());
            person.year = 26;
            Console.WriteLine(person.GetYear());


            //---------------------------------

            ExternalCopy externalObject = new ExternalCopy();
            externalObject.PrinterA();
        }
    }
}
