/* 1. Pida al usuario una cantidad de minutos: Ingresar minutos.
 * 2. Calcule cuántos segundos son: Multiplicar los minutos ingresados por 60.
 * 3. Muestre el resultado: Salida en consola.
 */

Console.WriteLine("CONVERSOR DE MINUTOS EN SEGUNDOS\n");
Console.WriteLine("Ingrese los minutos que quieres transformar en segundos:");

int minutos;
int segundos;

string? entrada = Console.ReadLine();

while (!int.TryParse(entrada, out minutos) || minutos < 0)
{
    Console.WriteLine("Valor no válido. Introduce un número igual o mayor" +
        " que 0:");

    entrada = Console.ReadLine();
}

segundos = minutos * 60;

Console.WriteLine($"Son {segundos} segundos.");