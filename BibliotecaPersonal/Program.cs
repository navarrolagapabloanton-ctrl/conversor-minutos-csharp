/*BIBLIOTECA PERSONAL
 * 
 * 1. Añadir libro:
 * 
 * - Pedir título y autor.
 * - No permitir que no haya texto vacío.
 * 
 * 2. Mostrar libros:
 * 
 * - Ordenados del 1 al final de la lista.
 * - Aquí aparece si el libro está disponible o prestado.
 * 
 * 3. Buscar libro:
 * 
 * - Pedir texto y buscar por título del libro.
 * 
 * 4. Prestar libro:
 * 
 * - De false a true.
 * - Mostrar los libros numerados, pedir un número y cambiar.
 * - Si ya estaba prestado no se puede prestar otra vez.
 * 
 * 5. Devolver libro: Lo contrario a prestar.
 * 6. Salir.
 */

List<Libro> libros = new List<Libro>();

while(true)
{
    MenuBibliotecaPersonal();

    Console.WriteLine("\nSeleccione una de las opciones del" +
        " 1 al 6.");

    string? entrada = Console.ReadLine();

    switch(entrada)
    {
        case "1":
            AñadirLibro(libros);
            break;

        case "2":
            MostrarLibros(libros);
            break;

        case "3":
            BuscarLibro(libros);
            break;

        case "4":
            PrestarLibro(libros);
            break;

        case "5":
            DevolverLibro(libros);
            break;

        case "6":
            Console.WriteLine("\nSaliendo...");
            return;

        default:
            Console.WriteLine("\nSeleccione una opción del" +
                " 1 al 6.");
            break;
    }
}

static void AñadirLibro(List<Libro> libros)
{
    Console.WriteLine("\nIngrese el nombre del libro: ");

    string nombreLibro;

    string? entrada = Console.ReadLine();

    while (string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("\nEl nombre del libro no puede" +
            " estar vacío");
        entrada = Console.ReadLine();
    }

    nombreLibro = entrada;

    Console.WriteLine("\nIngrese el autor del libro: ");

    string nombreAutor;

    entrada = Console.ReadLine();

    while (string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("\nEl nombre del autor no puede" +
            " estar vacío");
        entrada = Console.ReadLine();
    }

    nombreAutor = entrada;

    Libro libro = new Libro(nombreLibro, nombreAutor);

    libros.Add(libro);

    Console.WriteLine($"{nombreLibro} de {nombreAutor}" +
        $" añadido correctamente.");
}

static void MostrarLibros(List<Libro> libros)
{
    if (libros.Count == 0)
    {
        Console.WriteLine("\nNo se han añadido libros" +
            " todavía.");
        return;
    }

    for(int i = 0; i < libros.Count; i++)
    {
        Console.WriteLine($"\n{i + 1}. Título:" +
            $" {libros[i].Titulo}.");
        Console.WriteLine($"Autor: {libros[i].Autor}.");
        Console.WriteLine($"Estado: {(libros[i].Prestado ? "Prestado" : "Disponible")}.");
    }
}

static void BuscarLibro(List<Libro> libros)
{
    if (libros.Count == 0)
    {
        Console.WriteLine("\nNo hay libros para buscar.");
        return;
    }

    Console.WriteLine("\nIngrese el título del libro a buscar:");

    string? entrada = Console.ReadLine();

    string tituloLibro;

    while(string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("\nEl título del libro no puede estar" +
            " vacío.");
        entrada = Console.ReadLine();
    }

    tituloLibro = entrada;

    bool encontrado = false;

    foreach(Libro libro in libros)
    {
        if (libro.Titulo.Contains(tituloLibro))
        {
            Console.WriteLine($"\nLibro: {libro.Titulo}.");
            Console.WriteLine($"Autor: {libro.Autor}.");

            encontrado = true;
        }
    }

    if(!encontrado)
    {
        Console.WriteLine("\nNo se han encontrado resultados.");
    }
}

static void PrestarLibro(List<Libro> libros)
{
    if(libros.Count == 0)
    {
        Console.WriteLine("\nNo hay libros registrados.");
        return;
    }

    for (int i = 0; i < libros.Count; i++)
    {
        Console.WriteLine($"\n{i + 1}. Título:" +
            $" {libros[i].Titulo}.");
        Console.WriteLine($"Autor: {libros[i].Autor}.");
        Console.WriteLine($"Estado: {(libros[i].Prestado ? "Prestado" : "Disponible")}.");
    }

    Console.WriteLine("\nIngrese el número del libro que quieres" +
        " prestar.");

    int numeroLibro;

    string? entrada = Console.ReadLine();

    while(!int.TryParse(entrada, out numeroLibro)
        || numeroLibro < 1 || numeroLibro > libros.Count)
    {
        Console.WriteLine("\nError. Ingrese un número de la lista.");
        entrada = Console.ReadLine();
    }

    if(!libros[numeroLibro - 1].Prestado)
    {
        libros[numeroLibro - 1].Prestado = true;
        Console.WriteLine($"\nLibro cambiado a prestado.");
    }
    else
    {
        Console.WriteLine("\nLibro ya prestado.");
    }
}

static void DevolverLibro(List<Libro> libros)
{
    if (libros.Count == 0)
    {
        Console.WriteLine("\nNo hay libros registrados.");
        return;
    }

    for (int i = 0; i < libros.Count; i++)
    {
        Console.WriteLine($"\n{i + 1}. Título:" +
            $" {libros[i].Titulo}.");
        Console.WriteLine($"Autor: {libros[i].Autor}.");
        Console.WriteLine($"Estado: {(libros[i].Prestado ? "Prestado" : "Disponible")}.");
    }

    Console.WriteLine("\nIngrese el número del libro que quieres" +
        " devolver.");

    int numeroLibro;

    string? entrada = Console.ReadLine();

    while (!int.TryParse(entrada, out numeroLibro)
        || numeroLibro < 1 || numeroLibro > libros.Count)
    {
        Console.WriteLine("\nError. Ingrese un número de la lista.");
        entrada = Console.ReadLine();
    }

    if (libros[numeroLibro - 1].Prestado)
    {
        libros[numeroLibro - 1].Prestado = false;
        Console.WriteLine($"\nLibro cambiado a no prestado.");
    }
    else
    {
        Console.WriteLine("\nLibro ya devuelto.");
    }
}

static void MenuBibliotecaPersonal()
{
    Console.WriteLine("\nBIBLIOTECA PERSONAL\n");

    Console.WriteLine("1. Añadir libro.");
    Console.WriteLine("2. Mostrar libros.");
    Console.WriteLine("3. Buscar libros.");
    Console.WriteLine("4. Prestar libro.");
    Console.WriteLine("5. Devolver libro.");
    Console.WriteLine("6. Salir");
}

class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public bool Prestado { get; set; }

    public Libro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
        Prestado = false;
    }
}