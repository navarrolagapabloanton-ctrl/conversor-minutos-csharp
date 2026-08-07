/* 1. Pedir al usuario un número entero.
 * 2. Validad que realmente sea un entero.
 * 3. Mostrar su tabla de multiplicar desde el 1 hasta el 10.
 */

Console.WriteLine("\nTABLA DE MULTIPLICAR CUTRE\n");

int numero = LeerNumeroEntero("Introduce un número entero: ");

MostrarTablaMultiplicar(numero);

static int LeerNumeroEntero(string mensaje)
{
    Console.Write(mensaje);

    string? entrada = Console.ReadLine();
    int numero;

    while(!int.TryParse(entrada, out numero))
    {
        Console.WriteLine("Valor no válido. Introduce un número entero.");
        entrada = Console.ReadLine();
    }
    return numero;
}

static void MostrarTablaMultiplicar(int numero)
{
    Console.WriteLine($"\nTabla de multiplicar del número {numero}:\n");

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} * {i} = {numero * i}");
    }
}