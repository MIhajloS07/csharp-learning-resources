using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotekaZaTekst;

namespace TestTextApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TekstObrada.SetTekst(" Ja sam neki tekst ovde");
            TekstObrada.TrimString();
            TekstObrada.TrimEndString();
            TekstObrada.LowerCaseString();
            TekstObrada.CountWords();
            TekstObrada.PrintString();
        }
    }
}
