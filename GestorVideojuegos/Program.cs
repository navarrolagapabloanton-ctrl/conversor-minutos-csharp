/* GESTOR DE VIDEOJUEGOS
 * 
 * 1. Añadir videojuego:
 * 
 * - Pedir nombre.
 * - No permitir vacío.
 * - Guardarlo en la lista.
 * 
 * 2. Mostrar videojuegos:
 * 
 * - Si no hay ninguno, avisar.
 * - Si hay, mostrarlos numerados.
 * - Mostrar el total de videojuegos.
 * 
 * 3. Buscar videojuego:
 * 
 * - Pedir un texto.
 * - Mostrar todos los videojuegos que contengan ese texto.
 * - No distinguir mayúsculas/minúsculas.
 * 
 * 4. Eliminar videojuego:
 * 
 * - Mostrar la lista.
 * - Pedir número.
 * - Validar que exista.
 * - Eliminarlo.
 * 
 * 5. Salir.
 */

List<string> videojuegos = new List<string>();

while (true)
{
    MostrarMenu();

    string? entrada = Console.ReadLine();
    Console.WriteLine("");

    switch(entrada)
    {
        case "1":
            AñadirVideojuegos(videojuegos);
            break;

        case "2":
            MostrarVideojuegos(videojuegos);
            break;

        case "3":
            BuscarVideojuego(videojuegos);
            break;

        case "4":
            EliminarVideojuego(videojuegos);
            break;

        case "5":
            Console.WriteLine("Saliendo...");
            return;

        default:
            Console.WriteLine("Introduce una de las opciones del" +
                " menú del 1 al 5.");
            break;
    }
    
}

static void MostrarMenu()
{
    Console.WriteLine("\nGESTOR DE VIDEOJUEGOS\n");

    Console.WriteLine("1. Añadir videojuego.");
    Console.WriteLine("2. Mostrar videojuegos.");
    Console.WriteLine("3. Buscar videojuego.");
    Console.WriteLine("4. Eliminar videojuego.");
    Console.WriteLine("5. Salir.\n");
}

static void AñadirVideojuegos(List<string> videojuegos)
{
    Console.WriteLine("\nIntroduce el nombre del videojuego" +
        " a añadir: \n");

    string? entrada = Console.ReadLine();

    while(string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("\nNo puedes introducir el" +
            " nombre vacío. Introduce bien el nombre.\n");
        entrada = Console.ReadLine();
    }

    videojuegos.Add(entrada);
    Console.WriteLine("\nVideojuego añadido correctamente.");
}

static void MostrarVideojuegos(List<string> videojuegos)
{
    if (videojuegos.Count == 0)
    {
        Console.WriteLine("\nNo hay ningún videojuego registrado.\n");
        return;
    }

    Console.WriteLine("Cantidad total de videojuegos: \n" +
    videojuegos.Count + ".");

    for (int i = 0; i < videojuegos.Count; i++)
    {
        Console.WriteLine($"Videojuego nº{i + 1}: {videojuegos[i]}");
    }
}

static void BuscarVideojuego(List<string> videojuegos)
{
    Console.WriteLine("Introduce la palabra o el videojuego a" +
        " buscar.");

    string? entrada = Console.ReadLine();

    while(string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("No puedes dejar el campo vacío.");
        entrada = Console.ReadLine();
    }

    bool encontrado = false;

    Console.WriteLine("\nResultado de la búsqueda:\n");

    for (int i = 0; i < videojuegos.Count; i++)
    {
        if (videojuegos[i].ToLower().Contains(entrada.ToLower()))
        {
            Console.WriteLine(videojuegos[i]);
            encontrado = true;
        }
    }

    if(!encontrado)
    {
        Console.WriteLine("No se han mostrado resultados.");
    }
}

static void EliminarVideojuego(List<string> videojuegos)
{
    if (videojuegos.Count == 0)
    {
        Console.WriteLine("\nNo hay ningún videojuego registrado" +
            " para eliminar.\n");
        return;
    }

    Console.WriteLine("Selecciona el número de la lista a" +
        " eliminar: \n");

    MostrarVideojuegos(videojuegos);

    string? entrada = Console.ReadLine();

    int numeroEliminar;

    while(!int.TryParse(entrada, out numeroEliminar) ||
        numeroEliminar < 1 || numeroEliminar > videojuegos.Count)
    {
        Console.WriteLine("Valor no válido. Introduce un número" +
            " de la lista.");
        entrada = Console.ReadLine();
    }

    videojuegos.RemoveAt(numeroEliminar - 1);
    Console.WriteLine("Videojuego eliminado correctamente.");
}