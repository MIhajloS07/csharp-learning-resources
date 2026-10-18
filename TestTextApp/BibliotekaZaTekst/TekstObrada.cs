using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaZaTekst
{
    public class TekstObrada
    {
        private static string tekst;
        
        public static void SetTekst(string Tekst)
        {
            tekst = Tekst;
        }
        public static string GetTekst()
        {
            return tekst;
        }
        public static void LowerCaseString()
        {
            tekst = tekst.ToLower();
        }
        public static void UpperCaseString()
        {
            tekst = tekst.ToUpper();
        }
        public static void PrintString()
        {
            Console.WriteLine(tekst);
        }
        public static void ReverseString()
        {
            tekst = new string(tekst.Reverse().ToArray());
        }
        public static void TrimStartString() 
        {
            tekst = tekst.TrimStart();
        }
        public static void TrimEndString()
        {
            tekst = tekst.TrimEnd();
        }
        public static void TrimString()
        {
            tekst = tekst.Trim();
        }
        public static void CountWords()
        {
            int count = 0;
            for(int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine ($"Number of words: {count + 1}");
        }
    }
}
