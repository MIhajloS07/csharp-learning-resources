using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kompleksni k1 = new Kompleksni(3.0,4.0);
            //Kompleksni k2 = new Kompleksni(6.0,5.0);
            //Kompleksni zbir = k1 + k2;
            //Kompleksni razlika = k1 - k2;
            //zbir.Ispis();
            //razlika.Ispis();

            //Vektor2D v1 = new Vektor2D(4, 5);
            //Vektor2D v2 = new Vektor2D(2, 3);

            //Console.WriteLine(v1 + v2);   // (6,8)
            //Console.WriteLine(v1 - v2);   // (2,2)
            //Console.WriteLine(v1 * 2);    // (8,10)
            //Console.WriteLine(3 * v2);    // (6,9)
            //Console.WriteLine(++v1);      // (5,6)
            //Console.WriteLine(--v2);      // (1,2)
            //Console.WriteLine(v1 > v2);   // True
            //Console.WriteLine(v1 < v2);   // False
            //Console.WriteLine(v1 == v2);  // False
            //Console.WriteLine(v1 != v2);  // True

            Tacka t1 = new Tacka(3,5);
            Tacka t2 = new Tacka(6,4);

            Tacka zbir = t1 + t2;
            zbir.Print();
            Tacka razlika = t1 - t2;
            razlika.Print();
            Tacka inkrementT1 = ++t1;
            inkrementT1.Print();
            Tacka inkrementT2 = ++t2;
            inkrementT2.Print();
            Tacka DekrementT1 = --t1;
            DekrementT1.Print();
            Tacka DekrementT2 = --t2;
            DekrementT2.Print();
            Console.WriteLine(t1 > t2); //false
            Console.WriteLine(t1 < t2); //true
            Console.WriteLine(t1 == t2); //false
            Console.WriteLine(t1 != t2); //true
            Console.WriteLine(t1 != t2); //true
            




        }
    }

    class Kompleksni
    {
        public double Re { get; set; }
        public double Im { get; set; }
        
        public Kompleksni(double Re, double Im) 
        {
            this.Re = Re;
            this.Im = Im;
        }

        // Preopterecenje operatora +
        public static Kompleksni operator +(Kompleksni k1,Kompleksni k2)
        {
            return new Kompleksni(k1.Re + k2.Re, k1.Im + k2.Im);
        }
        public static Kompleksni operator -(Kompleksni k1,Kompleksni k2)
        {
            return new Kompleksni(k1.Re - k1.Re, k1.Im - k2.Im);
        }
        public static bool operator ==(Kompleksni k1, Kompleksni k2)
        {
            return k1.Re == k2.Re && k1.Im == k2.Im;
        }
        public static bool operator !=(Kompleksni k1, Kompleksni k2)
        {
            return !(k1 == k2);
        }

        public override bool Equals(object obj)
        {
            if(obj is Kompleksni k)
            {
                return this == k;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Re.GetHashCode() ^ Im.GetHashCode();
        }

        public void Ispis()
        {
            if (Im < 0)
            {
                Console.WriteLine($"{Re} - {Math.Abs(Im)}i");
            }
            else
            {
                Console.WriteLine($"{Re} + {Im}i");
            }
        }
    }
    class Vektor2D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Vektor2D(int x, int y)
        {
            X = x; Y = y;
        }

        //overload operatora
        public static Vektor2D operator +(Vektor2D v1, Vektor2D v2)
        {
            return new Vektor2D(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vektor2D operator -(Vektor2D v1, Vektor2D v2)
        {
            return new Vektor2D(v1.X - v2.X, v1.Y - v2.Y);
        }
        public static bool operator ==(Vektor2D v1, Vektor2D v2)
        {
            return v1.X == v2.X && v1.Y == v2.Y;
        }
        public static bool operator !=(Vektor2D v1, Vektor2D v2)
        {
            return !(v1 == v2);
        }
        public static Vektor2D operator *(Vektor2D v, int k)
        {
            return new Vektor2D(v.X * k, v.Y * k);
        }

        public static Vektor2D operator *(int k, Vektor2D v)
        {
            return new Vektor2D(v.X * k, v.Y * k);
        }

        public static Vektor2D operator ++(Vektor2D v)
        {
            return new Vektor2D(v.X + 1, v.Y + 1);
        }
        public static Vektor2D operator --(Vektor2D v)
        {
            return new Vektor2D(v.X - 1, v.Y - 1);
        }
        public static bool operator >(Vektor2D v1, Vektor2D v2)
        {
            return v1.Magnitude() > v2.Magnitude();
        }
        public static bool operator <(Vektor2D v1, Vektor2D v2)
        {
            return v1.Magnitude() < v2.Magnitude();
        }

        public override bool Equals(object obj)
        {
            if(obj is Vektor2D v)
            {
                return this == v;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        public void PrintVektor()
        {
            Console.WriteLine($"({X},{Y})");
        }
        public double Magnitude()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }
    class Tacka
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public Tacka(int x,int y)
        {
            X = x; Y = y;   
        }
        public static Tacka operator +(Tacka t1,Tacka t2)
        {
            return new Tacka(t1.X + t2.X,t1.Y + t2.Y);
        }
        public static Tacka operator -(Tacka t1, Tacka t2)
        {
            return new Tacka(t1.X - t2.X,t1.Y - t2.Y);
        }
        public static bool operator >(Tacka t1,Tacka t2)
        {
            return t1.Magnitude() > t2.Magnitude();
        }
        public static bool operator <(Tacka t1,Tacka t2)
        {
            return t1.Magnitude() < t2.Magnitude();
        }
        public static Tacka operator ++(Tacka t)
        {
            return new Tacka(t.X + 1, t.Y + 1);
        }
        public static Tacka operator --(Tacka t)
        {
            return new Tacka(t.X - 1, t.Y - 1);
        }
        public static bool operator ==(Tacka t1, Tacka t2)
        {
            return t1.X == t2.X && t1.Y == t2.Y;
        }
        public static bool operator !=(Tacka t1, Tacka t2)
        {
            return !(t1 == t2);
        }
        public override bool Equals(object obj)
        {
            if (obj is Tacka t)
            {
                return this == t;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
        public double Magnitude()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public void Print()
        {
            Console.WriteLine($"Tacka: ({X},{Y})");
        }
    }
}
