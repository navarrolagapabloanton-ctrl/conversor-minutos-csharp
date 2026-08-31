/* Dos funciones para calcular el máximo y el mínimo de una lista.
 * Lista de enteros como entrada.
 * Una función devuelve el int mayor y en la otra el menor.
 */

class Kata
{
    public int Max(int[] list)
    {
        int max = list[0];

        for (int i = 1; i < list.Length; i++)
        {
            if (max < list[i])
            {
                max = list[i];
            }
        }

        Console.WriteLine($"Máximo: {max}.");

        return max;
    }

    public int Min(int[] list)
    {
        int min = list[0];

        for (int i = 1; i < list.Length; i++)
        {
            if (min > list[i])
            {
                min = list[i];
            }
        }

        Console.WriteLine($"Mínimo: {min}.");

        return min;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int[] list = { 5 };
        Kata kata = new Kata();
        kata.Max(list);
        kata.Min(list);
    }
}