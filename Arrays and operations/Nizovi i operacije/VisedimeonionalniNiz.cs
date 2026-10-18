using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizovi_i_operacije
{
    internal class VisedimeonionalniNiz
    {
        public static void unosMatrice(int[,] matrica)
        {
            Console.Write("Unesite dimenzije matrice (broj redova i broj kolona):");
            int redovi = int.Parse(Console.ReadLine());
            int kolone = int.Parse(Console.ReadLine());
            for (int i = 0; i < redovi; i++)
            {
                for (int j = 0; j < kolone; j++)
                {
                    Console.Write($"Unesite element matrice [{i}][{j}]: ");
                    matrica[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
