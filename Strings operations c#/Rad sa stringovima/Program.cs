using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad_sa_stringovima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string -> niz karaktera
            string password;

            do
            {
                Console.Write("Unesi lozinku: ");
                password = Convert.ToString(Console.ReadLine());
                password = password.Trim();
                
                if (password.Length >= 8)
                {
                    Console.Write("Potvrdi lozinku: ");
                    string confirm = Convert.ToString(Console.ReadLine());
                    confirm = confirm.Trim();

                    if (confirm == password)
                    {
                        Console.Write("Unesi mail adresu: ");
                        string email = Convert.ToString(Console.ReadLine());

                        if (email.Contains("@") && email.EndsWith(".com"))
                        {
                            Console.WriteLine("Lozinka tacno uneta!");
                            Console.WriteLine($"lozinka: {confirm} mail adresa: {email}");
                            Console.WriteLine("Email tacno unet!");
                        }
                        else
                            Console.WriteLine("Email netacno unet!");                      
                    }
                    else
                    {
                        Console.WriteLine("Lozinka netacna!");
                    }
                }
                else
                {
                    Console.WriteLine("Lozinka koju si uneo mora imati 8 ili vise karaktera!");
                }
            } while (password.Length < 8);

            string text = "Hello World";
            string velika = text.ToUpper();
            string mala = text.ToLower();
            string zameni = text.Replace('H', 'B');
            string sub = text.Substring(5, 7);
            Console.WriteLine(sub);

        }
    }
}
