using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Konstruktora
{
    internal class Program
    {
        //CLANOVI KLASE PROGRAM
        int numberOne;
        int numberTwo;
        string textOne;
        string textTwo;
        char charOne;
        char charTwo;

        // OVERLOAD KONSTRUKTORA
        Program(int numberOne, int numberTwo) 
        {
            this.numberOne = numberOne;
            this.numberTwo = numberTwo;
        }
        Program(string textOne, string TextTwo)
        {
            this.textOne = textOne;
            this.textTwo = TextTwo;
        }
        Program(char charOne, char charTwo)
        {
            this.charOne = charOne;
            this.charTwo = charTwo;
        }
        Program(int numberOne, int numberTwo, string textOne, string textTwo, char charOne, char charTwo) 
        {
            this.numberOne = numberOne;
            this.numberTwo = numberTwo;
            this.textOne = textOne;
            this.textTwo = textTwo;
            this.charOne = charOne;
            this.charTwo = charTwo;
        }

        static void Main(string[] args)
        {
            Program objekatJedan = new Program(4,5);
            Program objekatDva = new Program("prvi","drugi");
            Program objekatTri = new Program('A','B');
            Program objekatCetiri = new Program(1, 2, "TekstJedan", "TekstDva", 'A', 'B');

            Console.WriteLine(objekatCetiri.numberTwo);

        }
    }
}
