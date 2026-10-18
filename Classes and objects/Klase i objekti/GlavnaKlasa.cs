using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Klase_i_objekti
{
    class GlavnaKlasa 
    {
        string x = "Ja sam string x";
        string y = "Ja sam string y";

        public void PrintX()
        {
            Console.WriteLine(x);
        }
        public void PrintY()
        {
            Console.WriteLine(y);
        }

    }
    public class Student
    {
        // telo klase - njena polja
        private string ime;
        private short godine;

        // Konstruktor
        public Student(string ime = "Mihajlo", short godine)
        {
            this.ime = ime;
            this.godine = godine;
        }

        // metoda
        public void Prikazi()
        {
            Console.WriteLine($"Student: {ime}, {godine}");
        }
    }

        static void Main(string[] args)
        {
            Student student = new Student("Nikola", 18);
            GlavnaKlasa program = new GlavnaKlasa(); // kreiranje istance klase GlavnaKlasa
            Console.WriteLine(program.x);
            Console.WriteLine(program.y);
            program.PrintX();
            program.PrintY();
            GlavnaKlasa programDva = new GlavnaKlasa();
            programDva.PrintX();
            programDva.PrintY();
            DrugiProgram drugiProgram = new DrugiProgram();
            drugiProgram.x = 40;
            Console.WriteLine(drugiProgram.x); // 40
            drugiProgram.y = 500;
            Console.WriteLine(drugiProgram.y);
            drugiProgram.printX();
            drugiProgram.printY();
        }

    internal class DrugiProgram
    {
        public int x;
        public int y;

        public void printX()
        {
            Console.WriteLine(x);
        } 
        public void printY()
        {
            Console.WriteLine(y);
        }
    }
}
