using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchCwiczenia20250312.App.Cwiczenia;

public class Kalkulator
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Subtract(int x, int y)
    {
        return x - y;
    }

    public int Multiply(int x, int y) 
    { 
        return x * y; 
    }

    public int Divide(int x, int y) 
    {
        return x / y;
    }

    internal int[] Reverse(int[] tab)
    {
        int[] result = new int[tab.Length];
        for (int i = 0; i < tab.Length; i++)
        {
            result[tab.Length - (i + 1)] = tab[i];
        }

        return result;
    }

    public void BubbleSort(int[] d)
    {
        //Przebieg zgodny z algorytmem z https://eduinf.waw.pl/inf/alg/003_sort/0004.php

        // Ustalamy n jako długość tablicy.
        // Zgodnie ze specyfikacją: n – liczba elementów w zbiorze d
        int n = d.Length;

        // K01: Pętla po j od 1 do n-1
        // Ponieważ w C# indeksujemy od 0, ta pętla będzie przebiegać od 0 do n-2 włącznie.
        for (int j = 0; j < n - 1; j++)
        {
            // K02: Pętla po i od 1 do n-1
            // Również korygujemy o 0-indeksowanie: od 0 do n-2 włącznie.
            for (int i = 0; i < n - 1; i++)
            {
                // Jeśli element na pozycji i jest większy niż element na pozycji i+1,
                // należy zamienić je miejscami.
                if (d[i] > d[i + 1])
                {
                    // Zamiana d[i] ↔ d[i+1].
                    int temp = d[i];
                    d[i] = d[i + 1];
                    d[i + 1] = temp;
                }
            }
        }
        // K03: Zakończ (po wyjściu z obu pętli tablica jest posortowana).
    }
}
