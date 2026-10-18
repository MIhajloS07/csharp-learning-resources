using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericke_klase
{
    interface IPrintable
    {
        void PrintInfo();
    }
    class GenerickaKlasa<T> where T : struct
    {
        //private T vrednost;
        public T VrednostSvojstva { get; set; }
        public GenerickaKlasa(T vrednost)
        {
            this.VrednostSvojstva = vrednost;
        }
        public void Prikazi()
        {
            Console.WriteLine("Vrednost: " + VrednostSvojstva);
        }
    }
    class GenerickaDruga<T1, T2>
        where T1 : class
        where T2 : struct
    {
        private T1 v1;
        private T2 v2;
        public GenerickaDruga(T1 v1, T2 v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
        public void PrikaziVrednosti() 
        {
            Console.WriteLine("{0}, {1}", v1, v2);
        }
    }
    class Box<T>
    {
        private T value;
        public void SetValue(T newValue)
        {
            this.value = newValue;
        }
        public T GetValue() => this.value;
    }
    class Container<T>
    {
        List<T> list = new List<T>();   
        public void Add(T item)
        {
            list.Add(item);
        }
        public void DisplayAll()
        {
            foreach (T item in list)
                Console.WriteLine(item);
        }
    }
    class Pair<T1, T2>
    {
        private T1 v1;
        private T2 v2;
        public Pair(T1 v1, T2 v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
        public void DisplayPair()
        {
            Console.WriteLine($"v1: {this.v1} v2: {this.v2}");
        }
    }
    class Calculator<T> where T : struct
    {
        public T Add(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return (T)(x + y);
        }
        public T Subtract(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return (T)(x - y);
        }
    }
    class Printer<T> where T : IPrintable
    {
        public void PrintItem(T item)
        {
            item.PrintInfo();
        }
    }
    class Repository<T> 
        where T : class, new()
    {
        public T CreateNew()
        {
            return new T();
        }
    }
    class User
    {
        public string Name { get; set; }
        public short Age { get; set; }
        public User(string name, short age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Korisnik: {Name}, Godine: {Age}");
        }
        public override string ToString()
        {
            // Ovo se koristi u Storage<T>.Find()
            return $"{Name}, {Age}";
        }
    }
    class Book : IPrintable
    {
        public string Author {  get; set; }
        public string Title { get; set; }
        public Book (string title, string author)
        {
            this.Author = author;
            this.Title = title;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Author: {Author}, Title: {Title}");
        }
    }
    class Storage<T>
    {
        List<T> list = new List<T>();     
        public void AddItem(T item)
        {
            list.Add(item); 
        }
        public bool Find<U>(U key)
        {
            foreach(T item in list)
            {
                if (item.ToString() == key.ToString())
                    return true;
            }
            return false;
        }
        public void DisplayAll()
        {
            Console.WriteLine("Collection:");
            foreach(T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
    abstract class Shape<T>
    {
        public string Color;
        public Shape(string color)
        {
            Color = color;
        }
        public abstract T Area(params T[] values);
    }
    class Circle : Shape<double>
    {
        public Circle(string color) : base(color) { }
        public override double Area(params double[] values)
        {
            double r = values[0];
            return Math.Round(Math.PI * Math.Pow(r, 2), 2);
        }
    }
    class Rectangle : Shape<int>
    {
        public Rectangle(string color) : base(color) { }
        public override int Area(params int[] values)
        {
            int a = values[0];   
            int b = values[1];
            return a * b;
        }
    }
    class Triangle : Shape<double> 
    {
        public Triangle(string color) : base(color) { }

        public override double Area(params double[] values)
        {
            double a = values[0];
            double h = values[1];
            return Math.Round(0.5 * a * h, 2);
        }
    }
    internal class Program
    {
        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0)
                return a;
            return b;
        }
        static string Swap<T>(ref T a, ref T b)
        {
            T temp = a; 
            a = b;
            b = temp;
            return $"a: {a}, b: {b}";
        }
        static void Main(string[] args)
        {
            //GenerickaKlasa<int> generickaInt = new GenerickaKlasa<int>(10);
            //GenerickaKlasa<string> generickaString = new GenerickaKlasa<string>("Zdravo");
            //generickaInt.Prikazi();
            //generickaString.Prikazi();
            //// Menjanje vrednosti pomocu svojstva VrednostSvojstva
            //generickaInt.VrednostSvojstva = 56;
            //generickaInt.Prikazi();
            //generickaInt.Prikazi();
            //GenerickaDruga<string, int> g1 = new GenerickaDruga<string, int>("string", 56);
            //g1.PrikaziVrednosti();
            //Box<int> box = new Box<int>();
            //box.SetValue(42);
            //Console.WriteLine(box.GetValue());
            //Container<string> container = new Container<string>();
            //container.Add("Hello");
            //container.Add("World");
            //container.Add("World");
            //Container<int> container = new Container<int>();
            //container.Add(1);
            //container.Add(2);
            //container.Add(3);
            //container.Add(4);
            //container.Add(5);
            //container.DisplayAll();
            //int a = 6; int b = 7;
            //Console.WriteLine(Swap(ref a, ref b));
            //Pair<int, string> pair = new Pair<int, string>(45, "Boban majmun");
            //pair.DisplayPair();
            //Console.WriteLine(Max(19, 10));
            //Repository<User> repository = new Repository<User>();
            //User newUser = repository.CreateNew();
            //newUser.Name = "Test";
            //newUser.Age = 18;
            //newUser.DisplayInfo();
            //Storage<User> userStorage = new Storage<User>();
            //userStorage.AddItem(new User("Mihajlo",18));
            //userStorage.AddItem(new User("Natasa",17));
            //userStorage.DisplayAll();
            //Console.WriteLine("Da li postoji korisnik 'Mihajlo, 17'? " + userStorage.Find("Mihajlo, 18"));
            //Console.WriteLine("Da li postoji korisnik 'Petar, 20'? " + userStorage.Find("Petar, 20"));
            //Circle c = new Circle("Blue");
            //Rectangle r = new Rectangle("Red");
            //Triangle t = new Triangle("Green");
            //Console.WriteLine($"Circle area is: {c.Area(5)}");
            //Console.WriteLine($"Rectangle area is: {r.Area(5,5)}");
            //Console.WriteLine($"Triangle area is: {r.Area(50,5)}");
        }
    }
}