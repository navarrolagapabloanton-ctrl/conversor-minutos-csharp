using System;

public class Kata
{
    public static long FindNextSquare(long num)
    {
        long sqr = (long)Math.Sqrt(num);

        return sqr * sqr == num ? (sqr + 1) * (sqr + 1) : -1;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(@"- Ingresa un número.
- Se hará su raíz cuadrada.
- Si no tiene decimales, se calculará la potencia al cuadrado del
siguiente número.
- Si no el resultado será -1.");

        string? entrada = Console.ReadLine();

        long result;

        while (!long.TryParse(entrada, out result))
        {
            Console.WriteLine("Ingrese un número" +
                " entero.");
            entrada = Console.ReadLine();
        }

        Console.WriteLine(Kata.FindNextSquare(result));
    }
}