/* Dados dos cadenas de strings que sólo incluyen letras de la
 * a a la z. Devuelve otra cadena ordenada alfabéticamente.
 * Procedentes de las dos cadenas.
 */

public class TwoToOne
{
    public static string Longest(string s1, string s2)
    {
        // Opción 1:

        string s3 = s1 + s2;
        string finalString = "";

        for (char c = 'a'; c <= 'z'; c++)
        {
            if (s3.Contains(c))
            {
                finalString += c;
            }
        }

        return finalString;


        // Opción 2:

        /*string s3 = s1 + s2;

        string finalString = "";

        string[] abc = {"a", "b", "c", "d", "e", "f", "g", "h",
        "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s",
        "t", "u", "v", "w", "x", "y", "z"};

        for (int i = 0; i < abc.Length; i++)
        {
            if (s3.Contains(abc[i]))
            {
                finalString += abc[i];
            }
        }

        return finalString;
        */
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine(TwoToOne.Longest("lallave", "dealfredo"));
    }
}