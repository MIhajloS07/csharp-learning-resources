using System;

namespace Nizovi_i_operacije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region Nizovi i operacije
                int[] niz;
                Niz.UnosNiza(out niz);
                Console.WriteLine("Uneti niz:");
                Niz.IspisNiza(niz);
                Console.WriteLine("Najmanji element niza: " + Niz.NajmanjiElementNiza(niz));
                Console.WriteLine("Najveci element niza: " + Niz.NajveciElementNiza(niz));
                Console.WriteLine("Drugi najveci element niza: " + Niz.DrugiNajveciElementNiza(niz));
                Console.WriteLine("Broj ponavljanja elementa 5: " + Niz.brojPonavljanjaElementa(niz, 5));
                Console.WriteLine("Suma elemenata niza: " + Niz.SumaElemenataNiza(niz));
                Console.WriteLine("Proizvod elemenata niza: " + Niz.ProizvodElemenataNiza(niz));
                Console.WriteLine("Najveci rastuci podniz: " + Niz.NajveciRastuciPodniz(niz));
                Console.WriteLine("Niz nakon sortiranja:");
                Niz.SortiranjeNiza(niz);
                Niz.IspisNiza(niz);
                Console.WriteLine("Niz nakon obrtanja:");
                Niz.ObrtanjeNiza(niz);
                Niz.IspisNiza(niz);
                Console.WriteLine("Prefiksni zbir niza:");
                Niz.PrefiksniZbir(niz);
                Console.WriteLine("Da li element 5 postoji u nizu? " + (Niz.LinearnaPretraga(niz, 5) ? "Da" : "Ne"));
                Console.WriteLine("Niz nakon bubble sort-a:");
                Niz.bubbleSort(niz);
                Niz.IspisNiza(niz);
                #endregion
                int[,] matrica;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Greška: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Došlo je do greške: " + ex.Message);
            }
        }
    }
}
