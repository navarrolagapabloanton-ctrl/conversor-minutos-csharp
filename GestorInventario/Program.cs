/* GESTOR DE INVENTARIO
 * 
 * 1. Añadir producto:
 * 
 * - Pedir un string y un int > 0.
 * - Si el string no existe, se añade la cantidad int.
 * - Si el string ya existe, se le añade la cantidad int.
 * 
 * 2. Mostrar inventario: Con foreach.
 * 3. Buscar producto: Pedir el nombre y mostrar nombre y unidades.
 * 4. Modificar stock:
 * 
 * - No es lo mismo que añadir productos, sino modificar el stock.
 * 
 * 5. Eliminar producto: Si no existe, avisar.
 * 6. Salir.
 */

Dictionary<string, int> inventario = new Dictionary<string, int>();

while (true)
{
    MenuGestionInventario();

    string? entrada = Console.ReadLine();

    switch (entrada)
    {
        case "1":
            AñadirProducto(inventario);
            break;

        case "2":
            MostrarInventario(inventario);
            break;

        case "3":
            BuscarProducto(inventario);
            break;

        case "4":
            ModificarStock(inventario);
            break;

        case "5":
            EliminarProducto(inventario);
            break;

        case "6":
            Console.WriteLine("Saliendo...");
            return;

        default:
            Console.WriteLine("Introduce una de las opciones del" +
                " 1 al 6 del menú.");
            break;

    }
}

static void AñadirProducto(Dictionary<string, int> inventario)
{
    Console.WriteLine("\nIntroduce el nombre del producto: ");

    string? entrada = Console.ReadLine();

    while (string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("\nEl nombre del producto no puede" +
            " estar vacío.");
        entrada = Console.ReadLine();
    }

    string producto = entrada;

    Console.WriteLine("\nIntroduce la cantidad de producto " +
        " a añadir.");

    entrada = Console.ReadLine();

    int cantidadProducto;

    while (!int.TryParse(entrada, out cantidadProducto) ||
        cantidadProducto <= 0)
    {
        Console.WriteLine("\nIntroduce un número entero mayor" +
            " que 0.");
        entrada = Console.ReadLine();
    }

    if (inventario.ContainsKey(producto))
    {
        inventario[producto] += cantidadProducto;
    }
    else
    {
        inventario.Add(producto, cantidadProducto);
    }

    Console.WriteLine("\nProducto y stock añadido correctamente.");
}

static void MostrarInventario(Dictionary<string, int> inventario)
{
    if (inventario.Count == 0)
    {
        Console.WriteLine("\nNo hay productos para buscar.");
        return;
    }

    foreach (KeyValuePair<string, int> producto in inventario)
    {
        Console.WriteLine($"{producto.Key}: {producto.Value}.");
    }
}

static void BuscarProducto(Dictionary<string, int> inventario)
{
    if (inventario.Count == 0)
    {
        Console.WriteLine("\nNo hay productos para buscar.");
        return;
    }

    Console.WriteLine("\nEscribe el producto a buscar: ");

    string? entrada = Console.ReadLine();

    while(string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("\nNo puede estar la búsqueda vacía.");
        entrada = Console.ReadLine();
    }

    bool existe = false;

    foreach (KeyValuePair<string, int> producto in inventario)
    {
        if (producto.Key.Contains(entrada))
        {
            Console.WriteLine($"{producto.Key}: {producto.Value}.");
            existe = true;
        }
    }

    if (!existe)
    {
        Console.WriteLine("\nBúsqueda sin resultados.");
    }
}

static void ModificarStock(Dictionary<string, int> inventario)
{
    if (inventario.Count == 0)
    {
        Console.WriteLine("\nNo hay productos para modificar" +
            " stock.");
        return;
    }

    Console.WriteLine("\nIntroduce el producto para modificar" +
        " su stock.");

    string? entrada = Console.ReadLine();

    while(string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("\nNo puede estar el nombre del" +
            " producto vacío.");
        entrada = Console.ReadLine();
    }

    string producto = entrada;

    if(!inventario.ContainsKey(producto))
    {
        Console.WriteLine("\nEse producto no existe.");
        return;
    }

    Console.WriteLine($"\nStock actual de {producto} : {inventario[producto]}.");
    Console.WriteLine("\nIntroduce el nuevo stock del producto.");

    entrada = Console.ReadLine();

    int nuevaCantidad;

    while(!int.TryParse(entrada, out nuevaCantidad) || 
        nuevaCantidad < 0)
    {
        Console.WriteLine("\nIntroduce una cantidad mayor o" +
            " igual que 0.");
        entrada = Console.ReadLine();
    }

    inventario[producto] = nuevaCantidad;

    Console.WriteLine($"\n{producto}: {nuevaCantidad}.");
}

static void EliminarProducto(Dictionary<string, int> inventario)
{
    if (inventario.Count == 0)
    {
        Console.WriteLine("\nInventario vacío.");
        return;
    }

    Console.WriteLine("\nIngrese el nombre del producto a" +
        " eliminar: ");

    string? entrada = Console.ReadLine();

    while(string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("\nEl nombre del producto no puede" +
            " estar vacío.");
        entrada = Console.ReadLine();
    }

    if(inventario.ContainsKey(entrada))
    {
        inventario.Remove(entrada);
        Console.WriteLine("\nProducto y stock eliminado" +
            " correctamente.");
    }
    else
    {
        Console.WriteLine("\nEse producto no existe.");
    }
}

static void MenuGestionInventario()
{
    Console.WriteLine("\nGESTOR DE INVENTARIO\n");

    Console.WriteLine("\n1. Añadir producto.");
    Console.WriteLine("2. Mostrar inventario.");
    Console.WriteLine("3. Buscar producto.");
    Console.WriteLine("4. Modificar stock.");
    Console.WriteLine("5. Eliminar producto.");
    Console.WriteLine("6. Salir.");
}