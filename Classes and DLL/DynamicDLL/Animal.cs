using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDLL
{
    public class Animal
    {
        public string animalName;
        public int AnimalAge;
        public int AnimalId;

        public void SetAnimalName(string animalName)
        {
            this.animalName = animalName;
        }
        public void SetAnimalAge(int AnimalAge)
        {
            this.AnimalAge = AnimalAge;
        }
        public void SetAnimalId(int AnimalId)
        {
            this.AnimalId = AnimalId;
        }
        public string GetAnimalName()
        {
            return this.animalName;
        }
        public int GetAnimalAge()
        {
            return this.AnimalAge; 
        }
        public int GetAnimalId()
        {
            return this.AnimalId;
        }
        public void PrintAnimal()
        {
            Console.WriteLine($"Animal Id: {this.AnimalId} | Name: {this.animalName} | Age: {this.AnimalAge} years");
        }
    }
}
