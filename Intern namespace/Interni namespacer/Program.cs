using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CUSTOM = CustomInterni.CustomStorage;
using CustomInterniDva;
//using CustomInterni.CustomStorage;

namespace Interni_namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj = 50;
            Console.WriteLine(broj);


            //nadogradjeni Interni_namespace
            Storage.printText();

            // custom namespace
            //CustomInterni.CustomStorage.printNum();

            // Kako bi izbegli veliki ispis odnosno da stalno unosimo ime namespace.klasa.itd, uvezemo namespace na pocetku programa! 
            CUSTOM.printNum();


            //custom interna dva
            CustomStorageTwo.printNum();
        }
    }
}

//Vrsimo nadogradnju namespace-a (internim putem odnosno vrsimo nadogradnju unutar istog cs fajla)

namespace Interni_namespace
{
    class Storage
    {
        public static string text = "Ja sam string iz Storage klase...";

        public static void printText() => Console.WriteLine(text);
    }
}


// Kreiramo custom interni namespace

namespace CustomInterni
{
    class CustomStorage
    {
        public static int number = 5;
        public static void printNum() => Console.WriteLine(number);
    }
}   

namespace CustomInterniDva
{
    class CustomStorageTwo
    {
        public static int number = 7;
        public static void printNum() => Console.WriteLine(number);
    }
}

