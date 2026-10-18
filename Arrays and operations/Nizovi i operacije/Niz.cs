using System;

namespace Nizovi_i_operacije
{
    internal class Niz
    {
        public static int NajveciRastuciPodniz(int[] niz)
        {
            int maxDuzina = 1, trenutnaDuzina = 1;
            for (int i = 1; i < niz.Length; i++)
            {
                if (niz[i] > niz[i - 1]) trenutnaDuzina++;
                else trenutnaDuzina = 1;
                if (trenutnaDuzina > maxDuzina) maxDuzina = trenutnaDuzina;
            }
            return maxDuzina;
        }
        public static void bubbleSort(int[] niz)
        {
            int duzina = niz.Length;
            for (int i = 0; i < duzina - 1; i++)
                for (int j = 0; j < duzina - i - 1; j++)
                    if (niz[j] > niz[j + 1])
                    {
                        int temp = niz[j];
                        niz[j] = niz[j + 1];
                        niz[j + 1] = temp;
                    }
        }
        public static void PrefiksniZbir(int[] niz)
        {
            int[] pref = new int[niz.Length];
            pref[0] = niz[0];
            for (int i = 1; i < niz.Length; i++)
                pref[i] = pref[i - 1] + niz[i];
            for (int i = 0; i < pref.Length; i++)
                Console.Write($"{pref[i]} ");
            Console.WriteLine();
        }
        public static void ObrtanjeNiza(int[] niz)
        {
            int duzina = niz.Length;
            for (int i = 0; i < duzina / 2; i++)
            {
                int temp = niz[i];
                niz[i] = niz[duzina - 1 - i];
                niz[duzina - 1 - i] = temp;
            }
        }
        public static int ProizvodElemenataNiza(int[] niz)
        {
            int p = 1;
            foreach (var element in niz) p *= element;
            return p;
        }
        public static int SumaElemenataNiza(int[] niz)
        {
            int suma = 0;
            foreach (var element in niz) suma += element;
            return suma;
        }
        public static int brojPonavljanjaElementa(int[] niz, int element)
        {
            int brojac = 0;
            foreach (var el in niz)
                if (el == element) brojac++;
            return brojac;
        }
        public static bool LinearnaPretraga(int[] niz, int element)
        {
            foreach (var el in niz)
                if (el == element) return true;
            return false;
        }
        public static int DrugiNajveciElementNiza(int[] niz)
        {
            int max1 = int.MinValue, max2 = int.MinValue;
            foreach (var element in niz)
            {
                if (element > max1)
                {
                    max2 = max1;
                    max1 = element;
                }
                else if (element > max2 && element != max1) max2 = element;
            }
            if (max2 == int.MinValue)
                throw new InvalidOperationException("Niz nema drugi najveći element.");
            return max2;
        }
        public static int NajveciElementNiza(int[] niz)
        {
            int max = niz[0];
            foreach (var element in niz)
                if (element > max) max = element;
            return max;
        }
        public static int NajmanjiElementNiza(int[] niz)
        {
            int min = niz[0];
            foreach (var element in niz)
                if (element < min) min = element;
            return min;
        }
        public static void SortiranjeNiza(int[] niz) => Array.Sort(niz);
        public static void UnosNiza(out int[] niz)
        {
            Console.Write("Unesite dužinu niza: ");
            int duzina = int.Parse(Console.ReadLine());
            niz = new int[duzina];
            for (int i = 0; i < duzina; i++)
            {
                Console.Write($"Unesite element {i + 1}: ");
                niz[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void IspisNiza(int[] niz)
        {
            foreach (var element in niz)
                Console.Write($"{element} ");
            Console.WriteLine();
        }
    }
}
