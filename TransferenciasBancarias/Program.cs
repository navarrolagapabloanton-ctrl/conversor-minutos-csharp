/*TRANSFERENCIAS BANCARIAS
 * 
 * 1. Mostrar cuentas.
 * 2. Transferir de Pablo a Laura:
 * 
 * - No permitir cantidades negativas ni superiores al saldo.
 * - No permitir transferencias de 0€.
 * 
 * 3. Transferir de Laura a Pablo.
 * 4. Ingresar dinero.
 * 5. Salir.
 */

CuentaBancaria cuentaPablo = new CuentaBancaria("Pablo Navarro",
    9000m);

CuentaBancaria cuentaLaura = new CuentaBancaria("Laura Laga",
    1500.55m);

while (true)
{
    MenuTransferenciaBancaria();

    Console.WriteLine("Seleccione una opción del 1 al 5.");

    string? entrada = Console.ReadLine();

    switch (entrada)
    {
        case "1":
            cuentaPablo.MostrarInformacion();
            cuentaLaura.MostrarInformacion();
            break;

        case "2":
            Console.WriteLine("\n¿Cuánto dinero quieres" +
                " transferir?");

            entrada = Console.ReadLine();

            decimal cantidadPablo;

            while(!decimal.TryParse(entrada, out
                cantidadPablo))
            {
                Console.WriteLine("\nLa cantidad a ingresar" +
                    " tiene que ser numérica.");
                entrada = Console.ReadLine();
            }

            cuentaPablo.Transferir(cuentaLaura, cantidadPablo);
            break;

        case "3":
            Console.WriteLine("\n¿Cuánto dinero quieres" +
                " transferir?");

            entrada = Console.ReadLine();

            decimal cantidadLaura;

            while (!decimal.TryParse(entrada, out
                cantidadLaura))
            {
                Console.WriteLine("\nLa cantidad a ingresar" +
                    " tiene que ser numérica.");
                entrada = Console.ReadLine();
            }

            cuentaPablo.Transferir(cuentaPablo, cantidadLaura);
            break;

        case "4":
            Console.WriteLine("\n¿A qué cuenta quieres ingresar el dinero?");
            Console.WriteLine("1. Pablo");
            Console.WriteLine("2. Laura");

            entrada = Console.ReadLine();

            CuentaBancaria cuentaElegida;

            if (entrada == "1")
            {
                cuentaElegida = cuentaPablo;
            }
            else if (entrada == "2")
            {
                cuentaElegida = cuentaLaura;
            }
            else
            {
                Console.WriteLine("\nCuenta no válida.");
                break;
            }

            Console.WriteLine("\n¿Cuánta cantidad desea ingresar?");

            decimal cantidad;

            entrada = Console.ReadLine();

            while (!decimal.TryParse(entrada, out cantidad))
            {
                Console.WriteLine("\nError. Introduce una cantidad numérica.");
                entrada = Console.ReadLine();
            }

            cuentaElegida.Ingresar(cantidad);
            break;

        case "5":
            Console.WriteLine("\nSaliendo...");
            return;

        default:
            Console.WriteLine("\nError, elige una opción del 1 al 5.");
            break;

    }
}

static void MenuTransferenciaBancaria()
{
    Console.WriteLine("\nTRANSFERENCIAS BANCARIAS");

    Console.WriteLine("1. Mostrar cuentas.");
    Console.WriteLine("2. Transferir de Pablo a Laura.");
    Console.WriteLine("3. Transferir de Laura a Pablo.");
    Console.WriteLine("4. Ingresar dinero.");
    Console.WriteLine("5. Salir.\n");
}

class CuentaBancaria
{
    public string Titular { get; set; }
    public decimal Saldo { get; set; }

    public CuentaBancaria(string titular, decimal saldoInicial)
    {
        Titular = titular;
        Saldo = saldoInicial;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"\nTitular: {Titular}.");
        Console.WriteLine($"Saldo: {Saldo}.");
    }

    public void Transferir(CuentaBancaria destino, decimal
        cantidad)
    {
        if (cantidad <= 0 || cantidad > Saldo)
        {
            Console.WriteLine("\nTransferencia no válida.");
            return;
        }

        Saldo -= cantidad;
        destino.Saldo += cantidad;

        Console.WriteLine($"\nTransferidos {cantidad:F2}" +
            $"€ a {destino.Titular}.");
    }

    public void Ingresar(decimal cantidad)
    {
        Saldo += cantidad;
        Console.WriteLine($"\nNuevo saldo: {Saldo:F2}€.");
    }
}