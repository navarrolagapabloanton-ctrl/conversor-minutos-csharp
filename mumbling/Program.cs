/* Dada una cadena de texto de la a-Z devuelve la primera letra
 * una vez, la segunda dos veces, la tercera 3 veces... .
 * La primera letra siempre en mayúscula.
 * Separados los bloques de cada letra por un guión ("-").
 */

public class Accumul
{
    public static string Accum(string s)
    {
        string accum = "";

        for(int i = 0; i < s.Length; i++)
        {
            accum += char.ToUpper(s[i]);

            for (int f = 1; f <= i; f++)
            {
                accum += char.ToLower(s[i]);
            }

            if (i < s.Length - 1)
            {
                accum += "-";
            }
        }

        return accum;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Accumul.Accum("Juanjo"));
    }
}