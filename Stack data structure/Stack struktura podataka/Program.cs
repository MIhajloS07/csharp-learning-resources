using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_struktura_podataka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack<int> stackInt = new Stack<int>();
            //stackInt.Push(10);  // Dno stack-a
            //stackInt.Push(20);
            //stackInt.Push(30);
            //stackInt.Push(40);
            //stackInt.Push(50);
            //stackInt.Push(60);  // Vrh stack-a

            //Console.WriteLine("Elementi na stack-u: ");
            //foreach (var item in stackInt)
            //    Console.WriteLine(item);

            //stackInt.Pop();
            //Console.WriteLine("Elementi na stack-u: ");
            //foreach (var item in stackInt)
            //    Console.WriteLine(item);
            UndoRedo undoredo = new UndoRedo();
            undoredo.DodajTekst("Zdravo, ");
            undoredo.DodajTekst("svete. ");
            undoredo.PrikaziTekst();

            undoredo.Undo();
            undoredo.PrikaziTekst();

            undoredo.DodajTekst("ucenici. ");
            undoredo.PrikaziTekst();

            undoredo.Undo();
            undoredo.PrikaziTekst();

            undoredo.Redo();
            undoredo.PrikaziTekst();


        }
    }
}
