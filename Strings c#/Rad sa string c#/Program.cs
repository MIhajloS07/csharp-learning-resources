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
            //string password;

            //do
            //{
            //    Console.Write("Unesi lozinku: ");
            //    password = Convert.ToString(Console.ReadLine());
            //    password = password.Trim();
            //    if (password.Length >= 8)
            //    {
            //        Console.Write("Potvrdi lozinku: ");
            //        string confirm = Convert.ToString(Console.ReadLine());
            //        confirm = confirm.Trim();

            //        if (confirm == password)
            //        {
            //            Console.Write("Unesi mail adresu: ");
            //            string email = Convert.ToString(Console.ReadLine());

            //            if (email.Contains("@") && email.EndsWith(".com"))
            //            {
            //                Console.WriteLine("Lozinka tacno uneta!");
            //                Console.WriteLine($"lozinka: {confirm} mail adresa: {email}");
            //                Console.WriteLine("Email tacno unet!");

            //            }
            //            else
            //                Console.WriteLine("Email netacno unet!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Lozinka netacna!");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Lozinka koju si uneo mora imati 8 ili vise karaktera!");
            //    }
            //} while (password.Length < 8);

            //metode za rad sa stringovima
            string text = "Hello, World!";
            string velika = text.ToUpper();
            string mala = text.ToLower();
            string zameni = text.Replace('H', 'B');
            string sub = text.Substring(7, 5);
            string[] reci = text.Split(' ');
            string spojeni = string.Join(" ", reci);

            //formatiranje stringa
            string formatiran = string.Format("Text: {0}",text);

            //Konvertovanje datetime u string
            DateTime trenutno = DateTime.Now;
            string datumVreme = trenutno.ToString("dd-MM-yyyy HH:mm:ss");

            //uporedjivanje stringova
            bool poredi = string.Equals("hello", "HELLO"); // false
            bool porediString = string.Equals("hello", "HELLO" , StringComparison.OrdinalIgnoreCase); // true

            // 0 -> stringovi su isti
            // 1 -> prvi string veci od drugog (prema binarnom poretku) 
            // -1 -> prvi string manji od drugog (prema binarnom poretku)
            int porediInt = string.Compare("hello", "HELLO"); // -1
            int porediDrugiInt = string.Compare("HELLO", "HELLO"); // 0
            int porediTreciInt = string.Compare("HELLO","Hello"); // 1

            if(porediInt == -1)
            {
                Console.WriteLine("Prvi string je manji od drugog prema binarnom poretku");
            }
            
            

        }
    }
}
