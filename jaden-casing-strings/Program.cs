/* Dada una frease. Devuelva cada palabra de esa frase empezando
 * con mayúscula.
 */

using System;

public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        string newString = "" + char.ToUpper(phrase[0]);

        for (int i = 1; i < phrase.Length; i++)
        {
            if (phrase[i] == ' ')
            {
                newString += " " + char.ToUpper(phrase[i + 1]);
                i++;
            }
            else
            {
                newString += phrase[i];
            }
        }

        return newString;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(JadenCase.ToJadenCase("most trees are" +
            " blue."));
    }

}