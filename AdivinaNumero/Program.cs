/* 1. Generar aleatoriamente un número entre 1 y 10.
 * 2. Pedir al usuario que intente adivinarlo.
 * 3. Validad que haya introducido un entero.
 * 4. Si el número introducido es menor que el secreto:
 * "El número secreto es mayor".
 * 5. Si es mayor:
 * "El número secreto es menor".
 * 6. Volver a pedir números hasta acertarlo.
 * 7. Cuando acierte:
 * "¡Correcto! El número era "x".
 * 8. Mostrar además cuántos intentos ha necesitado.
 */

Console.WriteLine("\nADIVINA EL NÚMERO\n");

Random random = new Random();

int numeroSecreto = random.Next(1, 11);

// PRUEBA
Console.WriteLine(numeroSecreto);
// PRUEBA

Console.WriteLine("Ingrese un número entero del 1 al 10 para intentar" +
    " adivinar el número secreto: ");

int contadorIntentos = 0;
string? entrada = Console.ReadLine();
contadorIntentos++;
int numero;

while (!int.TryParse(entrada, out numero) || numero < 1 || numero > 10)
{
    Console.WriteLine("Valor no válido. Introduce un entero del 1 al 10");
    entrada = Console.ReadLine();
    contadorIntentos++;
}

do
{

} while (numero != numeroSecreto);

