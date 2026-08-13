/* REGISTRO DE GASTOS
 * 
 * 1. Añadir gasto: 

- Pedir una cantidad.
_ Validar que sea un número mayor que 0.
- Añadirla a la lista.

 * 2. Mostrar gastos.
 * 3. Mostrar estadísticas:
 * 
 * - Total gastado.
 * - Media.
 * - Gasto más alto.
 * - Gasto más bajo.
 * 
 * 4. Eliminar gasto.
 * 5. Salir.
 */

List<decimal> gastos = new List<decimal>();

while(true)
{
    MenuGastos();

    string? entrada = Console.ReadLine();
    Console.WriteLine("");

    switch(entrada)
    {
        case "1":
            Console.WriteLine("Introduce el gasto: ");
            decimal gasto;

            entrada = Console.ReadLine();

            while(!decimal.TryParse(entrada, out gasto) ||
                gasto <= 0)
            {
                Console.WriteLine("Valor no válido. Introduce" +
                    " un gasto mayor que 0.");
                entrada = Console.ReadLine();
            }

            gastos.Add(gasto);
            Console.WriteLine("Introducido gasto.");
            break;

        case "2":
            if(gastos.Count == 0)
            {
                Console.WriteLine("No hay gastos registrados.");
                break;
            }

            for(int i = 0; i < gastos.Count; i++)
            {
                Console.WriteLine($"Gasto nº{i + 1}: {gastos[i]}€.");
            }
            break;

        case "3":
            if(gastos.Count == 0)
            {
                Console.WriteLine("No hay gastos registrados.");
                break;
            }

            decimal totalGastado = 0;
            decimal gastadoMayor = gastos[0];
            decimal gastadoMenor = gastos[0];

            // Cálculo de total gastado, gasto mayor y gasto menor.
            for(int i = 0; i < gastos.Count; i++)
            {
                totalGastado += gastos[i];

                if(gastadoMayor < gastos[i])
                {
                    gastadoMayor = gastos[i];
                }

                if (gastadoMenor > gastos[i])
                {
                    gastadoMenor = gastos[i];
                }
            }

            // Cálculo de la media.
            decimal mediaGastado = totalGastado / gastos.Count;

            Console.WriteLine($"\nTotal gastado: {totalGastado:F2}.");
            Console.WriteLine($"Media gastada: {mediaGastado:F2}.");
            Console.WriteLine($"Gasto mayor: {gastadoMayor:F2}.");
            Console.WriteLine($"Gasto menor: {gastadoMenor:F2}.");

            break;

        case "4":
            if (gastos.Count == 0)
            {
                Console.WriteLine("No hay gastos registrados.");
                break;
            }

            Console.WriteLine("Elige el número del gasto a eliminar: ");

            for (int i = 0; i < gastos.Count; i++)
            {
                Console.WriteLine($"Gasto nº{i + 1}: {gastos[i]}€.");
            }

            entrada = Console.ReadLine();

            int numeroGasto;

            while (!int.TryParse(entrada, out numeroGasto) ||
                numeroGasto < 1 || numeroGasto > gastos.Count)
            {
                Console.WriteLine("\nValor no válido. Introduce" +
                    " el número del gasto a eliminar.");
                entrada = Console.ReadLine();
            }

            gastos.RemoveAt(numeroGasto - 1);

            Console.WriteLine("Eliminado gasto.");
            break;

        case "5":
            Console.WriteLine("Saliendo...");
            return;

        default:
            Console.WriteLine("Valor no válido. Seleccione una" +
                " opción del 1 al 5.");
            break;
    }
}

static void MenuGastos()
{
    Console.WriteLine("\nREGISTRO DE GASTOS\n");

    Console.WriteLine("1. Añadir gasto.");
    Console.WriteLine("2. Mostrar gastos.");
    Console.WriteLine("3. Mostrar estadísticas.");
    Console.WriteLine("4. Eliminar gasto.");
    Console.WriteLine("5. Salir.\n");
}