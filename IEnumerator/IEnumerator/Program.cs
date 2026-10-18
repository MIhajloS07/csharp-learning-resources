using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> list = new List<int>() { 1,2,3,4,5 };
                IEnumerator<int> enumerator = list.GetEnumerator();
                while (enumerator.MoveNext())
                    Console.WriteLine(enumerator.Current);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
