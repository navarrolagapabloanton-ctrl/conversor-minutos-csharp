/* 1. Pedir al usuario un número entero.
 * 2. Comprobar que realmente se ha escrito un entero.
 * 3. Indicar si el número es:
 * - Positivo.
 * - Negativo.
 * - Cero.
 * 4. Indicar también si es par o impar.
 */

Console.WriteLine("CLASIFICADOR DE NÚMEROS\n");

bool continuar = true;

do
{
    Console.WriteLine("Ingrese un número entero por favor: ");

    string? entrada = Console.ReadLine();
    int numero;

    while (!int.TryParse(entrada, out numero))
    {
        Console.WriteLine("Valor no válido. Introduce un número entero: ");
        entrada = Console.ReadLine();
    }

    MostrarSigno(numero);

    MostrarParidad(numero);

    Console.WriteLine("¿Quieres probar con otro número? S/N");

    string? confirmar = Console.ReadLine();

    continuar = confirmar == "S" || confirmar == "s";

} while (continuar);

//Método dice si es positivo, negativo o 0.
static void MostrarSigno(int numero)
{
    if (numero > 0)
    {
        Console.WriteLine("El número es positivo.");
    }
    else if (numero < 0)
    {
        Console.WriteLine("El número es negativo.");
    }
    else
    {
        Console.WriteLine("El número es 0.");
    }
}

//Método dice si es par o impar.
static void MostrarParidad(int numero)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("El número es par.");
    }
    else
    {
        Console.WriteLine("El número es impar.");
    }
}