using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_genericka_kolekcija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashSet<string> hash = new HashSet<string>();
            //hash.Add("A");  
            //hash.Add("A");  // Duplicate 
            //hash.Add("B");  
            //hash.Add("B");  // Duplicate 
            //hash.Add("C");  
            //hash.Add("C");  // Duplicate 

            //foreach (var item in hash) 
            //    Console.WriteLine(item);
            //Console.WriteLine($"Total items in haskSet: {hash.Count}");

            //// Removing an element
            //hash.Remove("B");
            //if (hash.Contains("A"))
            //    Console.WriteLine("element A is in the hashSet!");
            //else
            //    Console.WriteLine("element A is not in the hashSet!");
            //foreach (var item in hash)
            //        Console.WriteLine(item);
            //Console.WriteLine($"Total items in haskSet: {hash.Count}");

            HashSet<int> skupA = new HashSet<int> { 1, 2, 3, 4};    
            HashSet<int> skupB = new HashSet<int> { 3, 4};
            // UNIJA
            //skupA.UnionWith(skupB); 
            //foreach(int element in skupA) 
            //    Console.WriteLine(element);

            Console.WriteLine("--------------------------");

            // PRESEK
            //skupA.IntersectWith(skupB);
            //foreach (int element in skupA)
            //    Console.WriteLine(element);

            Console.WriteLine("--------------------------");

            // SIMETRICNA RAZLIKA
            //skupA.SymmetricExceptWith(skupB);
            //foreach (int element in skupA)
            //    Console.WriteLine(element);

            Console.WriteLine("--------------------------");

            // RAZLIKA
            //skupA.ExceptWith(skupB);
            //foreach (int element in skupA) 
            //    Console.WriteLine(element);
            //skupB.ExceptWith(skupA);
            //foreach (int element in skupB)
            //    Console.WriteLine(element);\

            Console.WriteLine("--------------------------");

            // PODSKUP
            //bool podskupA = skupA.IsSubsetOf(skupB);
            //bool podskupB = skupB.IsSubsetOf(skupA);
            //Console.WriteLine($"Da li skupA podskup skupaB: {podskupA}");
            //Console.WriteLine($"Da li skupB podskup skupaA: {podskupB}");

            Console.WriteLine("--------------------------");

            // NADSKUP
            //bool nadskupA = skupA.IsSupersetOf(skupB);
            //bool nadskupB = skupB.IsSupersetOf(skupA);
            //Console.WriteLine($"Da li skupA nadskup skupaB: {nadskupA}");
            //Console.WriteLine($"Da li skupB nadskup skupaA: {nadskupB}");

        }
    }
}
