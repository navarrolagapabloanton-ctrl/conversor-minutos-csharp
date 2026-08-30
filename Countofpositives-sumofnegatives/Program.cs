/*Dado un array de enteros.
 * Devuelve un array donde el primer elemento es el recuento de 
 * números positivos y el segundo elemento es la suma de los números
 * negativos. 
 * 0 no es negativo ni positivo.
 * Si la entrada es un array vacío o null, devuelve un array vacío.
 * */

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[]? CountPositivesSumNegatives(int[] input)
    {
        int[] array = new int[2];
        int positiveCount = 0;
        int negativeSum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] > 0)
            {
                positiveCount++;
            }

            if (input[i] < 0)
            {
                negativeSum += input[i];
            }
        }

        array[0] = positiveCount;
        array[1] = negativeSum;

        for(int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{array[i]}");
        }

        if (input == null)
        {
            return null;
        }

        return array;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[] { 0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11,
            -12, -13, -14 };
        Kata.CountPositivesSumNegatives(array);
    }
}