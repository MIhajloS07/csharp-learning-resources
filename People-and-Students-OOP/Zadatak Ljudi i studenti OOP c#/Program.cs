using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_Ljudi_i_studenti_OOP_c_
{
    internal class Program
    {
        class Osoba
        {
            public string Ime;
            protected int Godine;
            private string JMBG;

            public Osoba(string Ime, int Godine, string JMBG)
            {
                this.Ime = Ime; 
                this.Godine = Godine; 
                this.JMBG = JMBG;
            }
            public void PrikaziPodatke()
            {
                Console.Write($"Ime: {this.Ime} | Godine: {this.Godine} | JMBG: {this.JMBG} ");
            }
            protected void PromeniGodine(int noveGodine)
            {
                Godine = noveGodine;
            }
        }

        class Student : Osoba
        {
            public string fakultet;
            public Student(string Ime, int Godine, string JMBG, string fakultet) 
                : base(Ime,Godine,JMBG)
            {
                this.fakultet = fakultet;
            }
            public void PrikaziPodatkeStudenta()
            {
                // Poziv metode iz osnovne klase "Osoba"
                PrikaziPodatke();
                Console.WriteLine($"| Fakultet: {this.fakultet} ");
            }

            public void TestPristupa() 
            {
                Console.WriteLine(Ime);
                Console.WriteLine(Godine);
            }
        }

        static void Main(string[] args)
        {
            Student student = new Student("Mihajlo",19,"Ovo je JMBG","ELFAK");
            student.TestPristupa();
            Console.WriteLine();
            // ---------------------------------------------------------------
            student.Ime = "Goran";
            student.TestPristupa();
        }
    }
}
