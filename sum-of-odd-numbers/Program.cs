/* Dado un triángulo de números impares consecutivos:
 * Calcular la suma de la fila n.
 * Empieza la fila en el índice 1.
 */

using System;

public static class Kata
{
    public static long RowSumOddNumbers(long n)
    {
        long sum = 0;
        long init = n * (n - 1) + 1;

        for (long i = 0; i < n; i++)
        {
            sum += init + (2 * i);
        }

        return sum;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Kata.RowSumOddNumbers(4));
    }
}

