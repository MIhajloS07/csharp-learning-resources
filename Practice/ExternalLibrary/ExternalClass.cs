using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalLibrary
{
    public class ExternalClass
    {
        public string name;
        public string surname;
        public int age;
        public int id;
        public static string color;
        public ExternalClass(int id, string name, string surname, int age) 
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        
        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public void SetAge(int age)
        {
            this.age = age;
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
        public string GetSurname()
        {
            return this.surname;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {this.id}| Name: {this.name}| Surname: {this.surname}| Age: {this.age}");
        }
        public static void SetBackgroundColor(string color)
        {
            color = color.Trim().ToLower();

            if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (color == "white") 
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            else if (color == "blue")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.WriteLine("Color not found...");
            }
        }
    }
}
