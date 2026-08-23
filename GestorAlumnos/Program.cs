/*GESTOR DE ALUMNOS
 * 
 * 1. Añadir alumno:
 * 
 * - Pedir nombre y nota.
 * - El nombre no puede estar vacío.
 * - La nota tiene que ser decimal.
 * - Entre 0 y 10.
 * 
 * 2. Mostrar alumnos: Si está vacío, avisar.
 * 3. Buscar alumno: Pedir texto.
 * 4. Mostrar estadísticas:
 * 
 * - Media.
 * - Nota más alta.
 * - Nota más baja.
 * 
 * 5. Eliminar alumno: Mostrar alumnos numerados, pedir número.
 * 6. Salir.
 */

List<Alumno> alumnos = new List<Alumno>();

while(true)
{
    MenuGestorAlumnos();

    Console.WriteLine("Selecciona una de las opciones del 1" +
        " al 6:");

    string? entrada = Console.ReadLine();

    switch(entrada)
    {
        case "1":
            AñadirAlumno(alumnos);
            break;

        case "2":
            MostrarAlumnos(alumnos);
            break;

        case "3":
            BuscarAlumno(alumnos);
            break;

        case "4":
            MostrarEstadisticas(alumnos);
            break;

        case "5":
            EliminarAlumno(alumnos);
            break;

        case "6":
            Console.WriteLine("\nSaliendo...");
            return;

        default:
            Console.WriteLine("\nSeleccione una de las opciones" +
                " del 1 al 6.");
            break;
    }
}

static void AñadirAlumno(List<Alumno> alumnos)
{
    Console.WriteLine("\nIngrese el nombre del alumno/a: ");

    string? entrada = Console.ReadLine();

    while(string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("\nEl nombre del alumno/a no puede" +
            " estar vacío.");
        entrada = Console.ReadLine();
    }

    string nombreAlumno = entrada;

    Console.WriteLine($"\nIngrese la nota del alumno/a" +
        $" {nombreAlumno}: ");

    decimal notaAlumno;

    entrada = Console.ReadLine();

    while(!decimal.TryParse(entrada, out notaAlumno) ||
        notaAlumno < 0 || notaAlumno > 10)
    {
        Console.WriteLine("\nLa nota del alumno/a tiene que" +
            " ser un número del 0 al 10.");
        entrada = Console.ReadLine();
    }

    Alumno alumno = new Alumno();

    alumno.Nombre = nombreAlumno;
    alumno.Nota = notaAlumno;

    alumnos.Add(alumno);

    Console.WriteLine($"\nAlumno {alumno.Nombre} añadido" +
        " correctamente.");
}

static void MostrarAlumnos(List<Alumno> alumnos)
{
    if (alumnos.Count == 0)
    {
        Console.WriteLine("\nNo hay alumnos registrados.");
        return;
    }

    foreach(Alumno alumno in alumnos)
    {
        Console.WriteLine($"\nNombre: {alumno.Nombre}.");
        Console.WriteLine($"Nota: {alumno.Nota}.");
    }
}

static void BuscarAlumno(List<Alumno> alumnos)
{
    if(alumnos.Count == 0)
    {
        Console.WriteLine("\nNo hay alumnos registrados.");
        return;
    }

    Console.WriteLine("\nIngrese el nombre del alumno/a a" +
        " buscar: ");

    string? entrada = Console.ReadLine();

    string nombreAlumno;

    while(string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("\nError. No dejes el nombre vacío.");
        entrada = Console.ReadLine();
    }

    nombreAlumno = entrada;

    bool encontrado = false;

    foreach(Alumno alumno in alumnos)
    {
        if(alumno.Nombre.Contains(nombreAlumno))
        {
            Console.WriteLine($"\nNombre: {alumno.Nombre}.");
            Console.WriteLine($"Nota: {alumno.Nota}.");

            encontrado = true;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("\nBúsqueda sin resultados.");
    }
}

static void MostrarEstadisticas(List<Alumno> alumnos)
{
    if(alumnos.Count == 0)
    {
        Console.WriteLine("\nNo hay ninguna nota registrada.");
        return;
    }

    decimal notaMedia = 0;
    decimal notaMayor = alumnos[0].Nota;
    decimal notaMenor = alumnos[0].Nota;

    //Cálculo de nota media:

    foreach(Alumno alumno in alumnos)
    {
        notaMedia += alumno.Nota;
    }

    notaMedia = notaMedia / alumnos.Count;

    //Cálculo de nota mayor:

    for (int i = 0; i < alumnos.Count; i++)
    {
        if(notaMayor < alumnos[i].Nota)
        {
            notaMayor = alumnos[i].Nota;
        }
    }

    //Cálculo de nota menor:

    for (int i = 0; i < alumnos.Count; i++)
    {
        if (notaMenor > alumnos[i].Nota)
        {
            notaMenor = alumnos[i].Nota;
        }
    }

    Console.WriteLine($"\nNota media: {notaMedia}.");
    Console.WriteLine($"Nota mayor: {notaMayor}.");
    Console.WriteLine($"Nota menor: {notaMenor}.");
}

static void EliminarAlumno(List<Alumno> alumnos)
{
    if(alumnos.Count == 0)
    {
        Console.WriteLine("\nNo hay alumnos para eliminar.");
        return;
    }

    Console.WriteLine("\nIngresa el número de alumno/a" +
        " a eliminar:");

    for (int i = 0; i < alumnos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. Nombre: " +
            $" {alumnos[i].Nombre} - Nota: {alumnos[i].Nota}.");
    }

    string? entrada = Console.ReadLine();

    int numeroEliminar;

    while (!int.TryParse(entrada, out numeroEliminar) ||
        numeroEliminar < 1 || numeroEliminar > alumnos.Count)
    {
        Console.WriteLine("\nNúmero de la lista no válido.");
        entrada = Console.ReadLine();
    }

    alumnos.RemoveAt(numeroEliminar - 1);
    Console.WriteLine("Alumno eliminado correctamente.");
}

static void MenuGestorAlumnos()
{
    Console.WriteLine("\nGESTOR DE ALUMNOS\n");

    Console.WriteLine("1. Añadir alumno.");
    Console.WriteLine("2. Mostrar alumnos.");
    Console.WriteLine("3. Buscar alumno.");
    Console.WriteLine("4. Mostrar estadísticas.");
    Console.WriteLine("5. Eliminar alumno.");
    Console.WriteLine("6. Salir.\n");
}

class Alumno
{
    public string Nombre { get; set; } = "";
    public decimal Nota
    {
        get; set;
    }
}
