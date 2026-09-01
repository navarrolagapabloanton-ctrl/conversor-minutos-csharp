/* Los cajeros automáticos sólo permiten códigos de 4 o 6 dígitos.
 * Si tiene el strig 4 o 6 dígitos es true, sino es false.
 * Si no hay dígitos, es false también.
 */

using System;
using System.Text.RegularExpressions;
public class Kata
{
    public static bool ValidatePin(string pin)
    {
        if (pin.Length == 4 || pin.Length == 6)
        {
            foreach (char character in pin)
            {
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }

            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un PIN.");

        string? entrada = Console.ReadLine();

        while(string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("Valor no válido. Introduce" +
                " otro valor.");
            entrada = Console.ReadLine();
        }

        Console.WriteLine(Kata.ValidatePin(entrada));
    }
}