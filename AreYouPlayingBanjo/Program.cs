/* Crea una función que responda a la pregunta:
 * Are you playing banjo?
 * Si tu nombre empieza por "R" en mayúscula o minúscula tú estás
 * tocando el banjo.
 */

using System;

class Kata
{
    public static string AreYouPlayingBanjo(string name)
    {
        return name.ToLower()[0] == 'r' ? name + " plays banjo" :
            name + " does not play banjo";
    }
}

class Program
{
    public static void Main(string[] args)
    {
            Console.WriteLine("Ingresa tu nombre:");
            string? entrada = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Nombre no válido." +
                    " Ingresa otro nombre.");
                entrada = Console.ReadLine();
            }

                Console.WriteLine(Kata.AreYouPlayingBanjo(entrada));
    }
}