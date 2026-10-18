using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatski_property
{
    internal class Student
    {
        // Automatski property
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student s = new Student();
                s.FirstName = Console.ReadLine();
                s.LastName = Console.ReadLine();
                s.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(s.FirstName);
                Console.WriteLine(s.LastName);
                Console.WriteLine(s.Id);
            } catch (Exception e)
            {
                Console.WriteLine("GRESKA: " + e);
            }
        }
    }
}
