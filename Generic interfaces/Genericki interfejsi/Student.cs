using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericki_interfejsi
{
    internal class Student : IComparable<Student>
    {
        public string Ime { get; set; }
        public double Prosek { get; set; }

        public Student(string ime, double prosek) 
        {
            Ime = ime;
            Prosek = prosek;
        }
        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            return this.Prosek.CompareTo(other.Prosek);
        }
        public override string ToString()
        {
            return $"{Ime} ({Prosek})";
        }
    }
}
