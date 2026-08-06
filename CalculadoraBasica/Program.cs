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

int num1 = LeerNumeroEntero("Ingresa el primer número: ");

int num2 = LeerNumeroEntero("Ingresa el segundo número: ");

MostrarMenuOperaciones();

string? operacion = Console.ReadLine();
int resultado;

switch (operacion)
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

static int LeerNumeroEntero(string mensaje)
{
    Console.WriteLine(mensaje);

    string? entrada = Console.ReadLine();
    int numero;

    while(!int.TryParse(entrada, out numero))
    {
        Console.WriteLine("Valor no válido." +
            " Introduce un número entero.");
        entrada = Console.ReadLine();
    }

    return numero;
}

static void MostrarMenuOperaciones()
{
    Console.WriteLine("¿Qué operación desea realizar?" +
    " Elige símbolo: \n");
    Console.WriteLine("Sumar: + ");
    Console.WriteLine("Restar: - ");
    Console.WriteLine("Multiplicar: *");
    Console.WriteLine("Dividir: / ");
}