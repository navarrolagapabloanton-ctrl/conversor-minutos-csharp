/* CARRITO DE COMPRA
 * 
 * 1. Añadir precio producto:
 * 
 * - Pedir el precio.
 * - Debe ser mayor que 0 y se añade a precios.
 * 
 * 2. Mostrar precio productos: Si está vacío, avisar.
 * 3. Mostrar ticket:
 * 
 * - Subtotal.
 * - IVA (21%).
 * - Total.
 * 
 * 4. Vaciar carrito: precios.Clear(); Elimina todos
 * elementos de la lista.
 * 5. Salir.
 */

List<decimal> precios = new List<decimal>();

while(true)
{
    MenuCarritoCompra();

    string? entrada = Console.ReadLine();

    switch(entrada)
    {
        case "1":
            AñadirPrecio(precios);
            break;

        case "2":
            MostrarPrecios(precios);
            break;

        case "3":
            if (precios.Count == 0)
            {
                Console.WriteLine("No hay ninguna compra efectuada.");
                break;
            }

            decimal subtotal = CalcularSubtotal(precios);
            decimal iva = CalcularIva(subtotal);
            decimal total = CalcularTotal(subtotal, iva);
            Console.WriteLine("\nTicket de la compra:\n");
            Console.WriteLine($"Subtotal: {subtotal:F2}€.");
            Console.WriteLine($"IVA: {iva:F2}€.");
            Console.WriteLine($"\nTotal: {total:F2}€.");
            break;

        case "4":
            VaciarCarrito(precios);
            break;

        case "5":
            return;

        default:
            Console.WriteLine("Opción no válida. Elige una" +
                " opción del 1 al 5.");
            break;
    }
}

static void MenuCarritoCompra()
{
    Console.WriteLine("\nCARRITO DE LA COMPRA\n");

    Console.WriteLine("1. Añadir precio producto.");
    Console.WriteLine("2. Mostrar precios productos.");
    Console.WriteLine("3. Mostrar ticket.");
    Console.WriteLine("4. Vaciar carrito.");
    Console.WriteLine("5. Salir.");
}

static void AñadirPrecio(List<decimal> precios)
{
    Console.WriteLine("\nIntroduce el precio del" +
    " producto.");

    string? entrada = Console.ReadLine();

    decimal precioProducto;

    while (!decimal.TryParse(entrada, out precioProducto) ||
        precioProducto <= 0)
    {
        Console.WriteLine("\nPrecio no válido. El precio" +
            " tiene que ser también mayor que 0.");
        entrada = Console.ReadLine();
    }

    precios.Add(precioProducto);
    Console.WriteLine("\nPrecio añadido correctamente.");
}

static void MostrarPrecios(List<decimal> precios)
{
    if(precios.Count == 0)
    {
        Console.WriteLine("\nNo hay ningún precio en el carrito.");
        return;
    }

    for(int i = 0; i < precios.Count; i++)
    {
        Console.WriteLine($"\nPrecio producto nº{i + 1}: " +
            $"{precios[i]:F2}€.");
    }
}

static void VaciarCarrito(List<decimal> precios)
{
    if (precios.Count == 0)
    {
        Console.WriteLine("\nEl carrito ya está vacío.");
        return;
    }

    precios.Clear();
    Console.WriteLine("\nCarrito vaciado.");
}

static decimal CalcularSubtotal(List<decimal> precios)
{
    decimal subtotal = 0;

    for (int i = 0; i < precios.Count; i++)
    {
        subtotal += precios[i];
    }

    return subtotal;
}

static decimal CalcularIva(decimal subtotal)
{
    return subtotal * 0.21m;
}

static decimal CalcularTotal(decimal subtotal, decimal iva)
{
    return subtotal + iva;
}