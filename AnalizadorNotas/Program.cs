/* 1. Pedir al usuario 5 notas enteras, entre 0 y 10.
 * 2. Validar cada nota.
 * 3. Guardar las cinco notas.
 * 4. Mostrar todas las notas introducidas.
 * 5. Calcular y mostrar:
 *  - La suma de las notas.
 *  - La media.
 *  - La nota más alta.
 *  - La nota más baja.
 */

Console.WriteLine("\nANALIZADOR DE NOTAS\n");

Console.WriteLine("Ingrese 5 notas enteras del 0 al 10.");

int[] notas = new int[5];

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Ingresa la nota número {i + 1}: ");
    string? entrada = Console.ReadLine();

    while (!int.TryParse(entrada, out notas[i]) ||
        notas[i] < 0 || notas[i] > 10)
    {
        Console.WriteLine("Valor no válido. Introduce una" +
            " nota que sea un número entero.");
        entrada = Console.ReadLine();
    }
}

//CÁLCULO DE NOTA MAYOR Y NOTA MENOR

int notaMayor = notas[0];
int notaMenor = notas[0];

for (int i = 1; i < notas.Length; i++)
{
    if (notas[i] > notaMayor)
    {
        notaMayor = notas[i];
    }

    if (notas[i] < notaMenor)
    {
        notaMenor = notas[i];
    }
}

int sumaNotas = 0;

for (int i = 0; i < notas.Length; i++)
{
    sumaNotas += notas[i];
}

double mediaNotas = (double)sumaNotas / notas.Length;

Console.WriteLine($"Las notas introducidas son: " +
    $"{notas[0]}, {notas[1]}, {notas[2]}, {notas[3]}," +
    $" {notas[4]}.");

Console.WriteLine($"La suma de las notas es: {sumaNotas}.");

Console.WriteLine($"La media de las notas es: {mediaNotas}.");

Console.WriteLine($"La nota mayor es: {notaMayor}.");

Console.WriteLine($"La nota menor es: {notaMenor}.");