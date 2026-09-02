/* Devuelve el número (conteo) de vocales en la cadena
 * dada.
 * 
 * La cadena de entrada solo consistirá en letras
 * minúsculas y/o espacios.
 */

using System;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        foreach (char character in str)
        {
            if ("aeiou".Contains(character))
            {
                vowelCount++;
            }
        }

        return vowelCount;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un texto:");

        string? entrada = Console.ReadLine();

        while(string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("No puede estar el texto vacío.");
            entrada = Console.ReadLine();
        }

        Console.WriteLine(Kata.GetVowelCount(entrada));
    }
}