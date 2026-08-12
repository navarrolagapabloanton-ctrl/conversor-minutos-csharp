/* decimal saldo = 1000;
 * 
 * CAJERO AUTOMÁTICO
 * 
 * 1. Consultar saldo: Mostrar el dinero disponible.
 * 
 * 2. Ingresar dinero:
 * 
 * - Pedir una cantidad.
 * - Comprobar que sea un número.
 * - No permitir 0 ni cantidades negativas.
 * - Sumarla al saldo.
 * 
 * 3. Retirar dinero:
 * 
 * - Pedir una cantidad.
 * - Validar que sea positiva.
 * - No permitir retirar más dinero del que tienes.
 * - Si es válida, restarla del saldo.
 * 
 * 4. Salir: Terminar el programa.
 * 5. Una opción distina del 1-4 debe dar error.
 */

decimal saldo = 1000;

while(true)
{
    MostrarMenu();

    string? entrada = Console.ReadLine();

    switch(entrada)
    {
        case "1":
            Console.WriteLine($"\nSaldo disponible: {saldo:F2}€.");
            break;

        case "2":
            Console.WriteLine("\n¿Cuánto dinero desea ingresar?: ");

            decimal dineroIngresado;

            entrada = Console.ReadLine();

            while(!decimal.TryParse(entrada, out dineroIngresado) ||
                dineroIngresado <= 0)
            {
                Console.WriteLine("No puedes ingresar esa cantidad." +
                    " Seleccione otra.");

                entrada = Console.ReadLine();
            }

            saldo += dineroIngresado;
            Console.WriteLine($"Nuevo saldo: {saldo:F2}.");
            break;

        case "3":
            Console.WriteLine("\n¿Cuánto dinero desea retirar?: ");

            decimal dineroRetirado;

            entrada = Console.ReadLine();

            while(!decimal.TryParse(entrada, out dineroRetirado) ||
                dineroRetirado <= 0 || dineroRetirado > saldo)
            {
                Console.WriteLine("No puedes retirar esa cantidad." +
                    " Seleccione otra.");

                entrada = Console.ReadLine();
            }

            saldo -= dineroRetirado;
            Console.WriteLine($"Nuevo saldo: {saldo:F2}.");
            break;

        case "4":
            Console.WriteLine("Saliendo...");
            return;

        default:
            Console.WriteLine("Valor no válido. Seleccione opción" +
                " 1, 2, 3 o 4.");
            break;
    }
}

static void MostrarMenu()
{
    Console.WriteLine("\nCAJERO AUTOMÁTICO\n");

    Console.WriteLine("1. Consultar saldo.");
    Console.WriteLine("2. Ingresar dinero.");
    Console.WriteLine("3. Retirar dinero.");
    Console.WriteLine("4. Salir.");
}