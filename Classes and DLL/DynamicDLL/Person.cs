using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDLL
{
    public class Person
    {
        public string name;
        public int age;
        public int id;
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAge(int age)
        {
           this.age = age;  
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetAge()
        {
            return this.age;
        }
        public int GetId()
        {
            return this.id;
        }
        public void PrintPerson()
        {
            Console.WriteLine($"Id: {this.id} | Name: {this.name} | Age: {this.age} years");
        }
    }
}
