/* AGENDA DE CONTACTOS
 * 
 * 1. Añadir contacto:
 * 
 * - Pedir nombre y teléfono.
 * - Ninguno puede estar vacío.
 * - No permitir dos contactos con el mismo nombre.
 * 
 * 2. Mostrar contactos:
 * 
 * - Si no hay ninguno avisar.
 * 
 * 3. Buscar contacto:
 * 
 * - Pedir un nombre y mostrar su teléfono.
 * - Si no existe, avisar.
 * 
 * 4. Eliminar contacto:
 * 
 * _ Pedir el nombre y eliminarlo si existe.
 * 
 * 5. Salir.
 */

Dictionary<string, string> contactos = new Dictionary<string,
    string>();

while(true)
{
    MenuAgendaContactos();

    string? entrada = Console.ReadLine();

    switch(entrada)
    {
        case "1":
            AñadirContacto(contactos);
            break;

        case "2":
            MostrarContactos(contactos);
            break;

        case "3":
            BuscarContacto(contactos);
            break;

        case "4":
            EliminarContacto(contactos);
            break;

        case "5":
            return;

        default:
            Console.WriteLine("\nValor no válido. Introduce una" +
                " opción del 1 al 5");
            break;
    }
}

static void AñadirContacto(Dictionary<string, string> contactos)
{
    Console.WriteLine("\nIntroduzca el nombre del contacto: ");

    string? entrada = Console.ReadLine();

    while(string.IsNullOrWhiteSpace(entrada) || contactos.ContainsKey(entrada))
    {
        Console.WriteLine("\nEl contacto no es válido o ya" +
            " existe.");
        entrada = Console.ReadLine();
    }

    string nombre = entrada;

    Console.WriteLine("\nIntroduzca el número del teléfono" +
        " del contacto.");

    entrada = Console.ReadLine();

    while(string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("\nEl teléfono no puede estar vacío.");
        entrada = Console.ReadLine();
    }

    string numeroContacto = entrada;

    contactos.Add(nombre, numeroContacto);
    Console.WriteLine("\nContacto añadido correctamente.");
}

static void MostrarContactos(Dictionary<string, string> contactos)
{
    if(contactos.Count == 0)
    {
        Console.WriteLine("\nNo hay ningún contacto registrado.");
        return;
    }

    foreach (KeyValuePair<string, string> contacto in contactos)
    {
        Console.WriteLine($"\nNombre: {contacto.Key}.");
        Console.WriteLine($"Teléfono: {contacto.Value}.");
    }
}

static void BuscarContacto(Dictionary<string, string> contactos)
{
    if(contactos.Count == 0)
    {
        Console.WriteLine("\nLa lista de contactos está vacía.");
        return;
    }

    Console.WriteLine("\nIntroduce el contacto o palabras a" +
        " buscar.");

    string? entrada = Console.ReadLine();

    while(string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("\nIntroduce contacto, letra o" +
            " palabra a buscar.");
        entrada = Console.ReadLine();
    }

    bool encontrado = false;

    foreach (KeyValuePair<string, string> contacto in contactos)
    {
        if(contacto.Key.Contains(entrada))
        {
            Console.WriteLine($"\nContacto: {contacto.Key}.");
            Console.WriteLine($"Teléfono: {contacto.Value}");

            encontrado = true;
        }
    }

    if(!encontrado)
    {
        Console.WriteLine("\nSin resultados de la búsqueda.");
    }
}

static void EliminarContacto(Dictionary<string, string> contactos)
{
    if(contactos.Count == 0)
    {
        Console.WriteLine("\nNo hay ningún contacto a eliminar.");
        return;
    }

    Console.WriteLine("\nIntroduzca el nombre exacto del" +
        " contacto a eliminar");

    string? entrada = Console.ReadLine();

    while(string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("\nEl contacto no puede estar vacío.");
        entrada = Console.ReadLine();
    }

    if(contactos.ContainsKey(entrada))
    {
        contactos.Remove(entrada);
        Console.WriteLine("\nContacto eliminado.");
    }
    else
    {
        Console.WriteLine("\nEl contacto a eliminar no existe");
    }
}

static void MenuAgendaContactos()
{
    Console.WriteLine("\nAGENDA DE CONTACTOS\n");

    Console.WriteLine("1. Añadir contacto.");
    Console.WriteLine("2. Mostrar contactos.");
    Console.WriteLine("3. Buscar contacto.");
    Console.WriteLine("4. Eliminar contacto.");
    Console.WriteLine("5. Salir.");
}
