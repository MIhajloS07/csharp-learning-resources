using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strukture_podataka_uvod_vezba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //LIFO
                Stack<int> stack = new Stack<int>();
                
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);

                //Console.WriteLine(stack.ToString);
                foreach (var stackItem in stack)
                {
                    Console.WriteLine(stackItem);
                }

                stack.Pop();
                stack.Pop();
                stack.Pop();
                stack.Pop();
                stack.Pop();

                Console.WriteLine("-------------------------------");

                foreach (var stackItem in stack)
                {
                    Console.WriteLine(stackItem);
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Greska: " + ex.Message);
            }
            finally 
            {
                Console.WriteLine("Hvala na koriscenju aplikacije"); 
            }
        }
    }
}
