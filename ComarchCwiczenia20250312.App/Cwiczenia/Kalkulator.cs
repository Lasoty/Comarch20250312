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
}
