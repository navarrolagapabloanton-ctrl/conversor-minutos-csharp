/*CUENTA BANCARIA
 * 1. Consultar cuenta.
 * 2. Ingresar dinero: No acepta cantidades <= 0.
 * 3. Retirar dinero: No acepta cantidades <= 0 ni superiores al saldo.
 * 4. Salir.
 */

CuentaBancaria cuentaPablo = new CuentaBancaria("Pablo Navarro",
    1000.75m);

while(true)
{
    MenuCuentaBancaria();

    Console.WriteLine("Seleccione una de las opciones del 1 al 4.");

    string? entrada = Console.ReadLine();

    switch(entrada)
    {
        case "1":
            cuentaPablo.MostrarInformacion();
            break;

        case "2":
            {
                Console.WriteLine("\nIngrese la cantidad de dinero" +
                    " a ingresar.");

                decimal cantidadIngresada;

                entrada = Console.ReadLine();

                while(!decimal.TryParse(entrada, 
                    out cantidadIngresada))
                {
                    Console.WriteLine("\nIngrese una cantidad" +
                        " numérica.");
                    entrada = Console.ReadLine();
                }

                cuentaPablo.Ingresar(cantidadIngresada);
                break;
            }

        case "3":
            {
                Console.WriteLine("\nIngrese la cantidad de dinero" +
                    " a retirar.");

                decimal cantidadRetirada;

                entrada = Console.ReadLine();

                while (!decimal.TryParse(entrada,
                    out cantidadRetirada))
                {
                    Console.WriteLine("\nIngrese una cantidad" +
                        " numérica.");
                    entrada = Console.ReadLine();
                }

                cuentaPablo.Retirar(cantidadRetirada);
                break;
            }

        case "4":
            Console.WriteLine("\nSaliendo...");
            return;

        default:
            Console.WriteLine("\nElige una de las opciones del 1 al" +
                " 4.");
            break;
    }
}

static void MenuCuentaBancaria()
{
    Console.WriteLine("\nCUENTA BANCARIA\n");

    Console.WriteLine("1. Consultar cuenta.");
    Console.WriteLine("2. Ingresar dinero.");
    Console.WriteLine("3. Retirar dinero.");
    Console.WriteLine("4. Salir.\n");

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

    public void Ingresar(decimal cantidad)
    {
        if (cantidad > 0)
        {
            Saldo += cantidad;
            Console.WriteLine($"\nNuevo saldo: {Saldo:F2}€.");
        }
        else
        {
            Console.WriteLine("\nCantidad ingresada incorrecta." +
                " Añade una cantidad mayor a 0.");
        }
    }

    public void Retirar(decimal cantidad)
    {
        if (cantidad > 0 && cantidad <= Saldo)
        {
            Saldo -= cantidad;
            Console.WriteLine($"\nNuevo saldo: {Saldo:F2}€.");
        }
        else
        {
            Console.WriteLine("\nCantidad ingresada incorrecta." +
                " Añade una cantidad mayor a 0 y menor" +
                " o igual a tu saldo.");
        }
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"\nTitular: {Titular}.");
        Console.WriteLine($"Saldo: {Saldo:F2}€.");
    }
}