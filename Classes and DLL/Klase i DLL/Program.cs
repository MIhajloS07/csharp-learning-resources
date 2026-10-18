using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicDLL;

namespace Klase_i_DLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(); // kreiranje instance klase Person
            Animal animal = new Animal(); // kreiranje instance klase Animal
            //---------------------------
            person.SetName("Danilo");
            person.SetId(1);
            person.SetAge(16);
            person.PrintPerson();
            //---------------------------
            animal.SetAnimalName("Mrvica");
            animal.SetAnimalId(2);
            animal.SetAnimalAge(3);
            animal.PrintAnimal();
        }
    }
}
