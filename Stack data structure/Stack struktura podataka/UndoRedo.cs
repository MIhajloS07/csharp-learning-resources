using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_struktura_podataka
{
    internal class UndoRedo
    {
        private Stack<string> undoStack;
        private Stack<string> redoStack;
        private string trenutniStack;
        public UndoRedo()
        {
            undoStack = new Stack<string>();
            redoStack = new Stack<string>();
            trenutniStack = string.Empty;
        }
        public void DodajTekst(string noviTekst)
        {
            undoStack.Push(trenutniStack);
            trenutniStack += noviTekst;
            redoStack.Clear();
        }
        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(trenutniStack);
                trenutniStack = undoStack.Pop();
            }
            else
                Console.WriteLine("Nema operacija za undo");
        }
        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(trenutniStack);
                trenutniStack = redoStack.Pop();
            }
            else
                Console.WriteLine("Nema operacija za redo");
        }
        public void PrikaziTekst() => Console.WriteLine($"Trenutni tekst: {trenutniStack}");
    }
}
