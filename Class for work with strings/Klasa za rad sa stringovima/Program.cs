using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_za_rad_sa_stringovima
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            string name = "Mihajlo";
            string surname = "Stoiljkovic";
            string text = string.Empty; // ""
            string nullStr = null;

            // Check with if statement
            if (string.IsNullOrEmpty(name))
                Console.WriteLine("String is null or empty");
            else
                Console.WriteLine(name);
            if (string.IsNullOrWhiteSpace(text))
                Console.WriteLine("Text is null or white space");
            else
                Console.WriteLine(text);
            char c = name[0]; // M 
            Console.WriteLine(c);
            // String concatenation
            string resV1 = name + " " + surname;
            Console.WriteLine(resV1);
            resV1 = string.Concat(name, " ", surname);
            Console.WriteLine(resV1);
            // String interpolation
            string inter = $"{name} {surname}";
            Console.WriteLine(inter);
            // Get string length
            int strlen = name.Length; 
            // Last index is -> name.Length - 1
            Console.WriteLine(strlen);
            // Substring
            string sub = name.Substring(2, 5);
            Console.WriteLine(sub);
            // Get index of
            int index = name.IndexOf('l');
            Console.WriteLine(index);   
            // Upper text
            string upperName = name.ToUpper();
            Console.WriteLine(upperName);
            // Lower text
            string lowerName = name.ToLower();
            Console.WriteLine(lowerName);
            // Replace text
            string replaced = name.Replace('j', 'i');
            Console.WriteLine(replaced);
            // Split to array of strings
            string[] words = name.Split('h');
            foreach (string word in words)
                Console.WriteLine(word);
            // Join strings
            string together = string.Join(" ", words);
            Console.WriteLine(together);
            return 0;
        }
    }
}
