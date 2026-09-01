/* Implementa una función que acepte 3 valores int (a, b, c).
 * La función debería de devolver true si la suma de dos lados es
 * mayor que el tercer lado.
 */

public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer lado del triángulo:");
        int a = LeerNumero();
        Console.WriteLine("Ingrese el segundo lado del triángulo.");
        int b = LeerNumero();
        Console.WriteLine("Ingrese el tercer lado del triángulo.");
        int c = LeerNumero();

        Console.WriteLine(Triangle.IsTriangle(a, b, c));
    }

    public static int LeerNumero()
    {
        string? entrada = Console.ReadLine();

        int num;

        while(!int.TryParse(entrada, out num))
        {
            Console.WriteLine("Valor no válido. Introduce un" +
                " entero.");
            entrada = Console.ReadLine();
        }

        return num;
    }
}