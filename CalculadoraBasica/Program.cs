/* 1. Pedir un número entero.
 * 2. Comprobar que sea válido.
 * 3. Pedir un segundo número entero.
 * 4. Comprobar que sea válido.
 * 5. Preguntar qué operación quiere realizar: +, -, *, /.
 * 6. Mostrar el resultado.
 * 7. Si intenta dvidir entre cero, monstrar un mensaje de
 * error.
 */

Console.WriteLine("CALCULADORA MUY BÁSICA\n");

Console.WriteLine("Ingresa un número: ");

string? entrada1 = Console.ReadLine();
int num1;

while (!int.TryParse(entrada1, out num1))
{
    Console.WriteLine("Valor no válido. Introduce un" +
        " número entero.");
    entrada1 = Console.ReadLine();
}

Console.WriteLine("Ingresa el segundo número: ");

string? entrada2 = Console.ReadLine();
int num2;

while (!int.TryParse(entrada2, out num2))
{
    Console.WriteLine("Valor no válido. Introduce un" +
        " número entero.");
    entrada2 = Console.ReadLine();
}

Console.WriteLine("¿Qué operación desea realizar?" +
    " Elije símbolo: \n");
Console.WriteLine("Sumar: + ");
Console.WriteLine("Restar: - ");
Console.WriteLine("Multiplicar: *");
Console.WriteLine("Dividir: / ");

string? entrada3 = Console.ReadLine();
int resultado;

switch (entrada3)
{
    case "+":
        resultado = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {resultado}");
        break;

    case "-":
        resultado = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {resultado}");
        break;

    case "*":
        resultado = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {resultado}");
        break;

    case "/":
        if (num2 == 0)
        {
            Console.WriteLine("No se puede dividir entre 0.");
        }
        else
        {
            resultado = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {resultado}");
        }
        break;

    default:
        Console.WriteLine("El símbolo de la operación" +
            " introducida no es válida.");
        break;
}