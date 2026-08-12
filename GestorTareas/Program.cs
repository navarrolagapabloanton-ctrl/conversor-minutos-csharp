/* GESTOR DE TAREAS
 * 
 * 1. Añadir Tarea.
 * 2. Mostrar tareas.
 * 3. Eliminar tarea.
 * 4. Salir.
 * 
 * Elige una opción:
 * 
 * ----------------------
 * 
 * 1. Crea una List<string> vacía para almacenar las tareas.
 * 2. Mostrar el menú continuamente hasta que el usuario elija 4.
 * 3. Opción 1: pedir una tarea, comprobar que no esté vacía y
 * añadirla.
 * 4. Opción 2: mostrar todas las tareas numeradas.
 * 5. Opción 3: permitir eliminar una tarea.
 * 6. Opción 4: salir del programa.
 * 7. Si introduce una opción que no existe, mostrar un mensaje de
 * error.
 */

List<string> tarea = new List<string>();

while (true)
{
    MostrarMensajeMenu();

    string? entrada = Console.ReadLine();

    switch (entrada)
    {
        case "1":
            Console.WriteLine("\nAñade una tarea: \n");

            entrada = Console.ReadLine();

            while(string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Valor no válido." +
                    " Introduzca otra tarea.");
                entrada = Console.ReadLine();
            }

            tarea.Add(entrada);
            Console.WriteLine("Tarea añadida.");
            break;

        case "2":
            for (int i = 0; i < tarea.Count; i++)
            {
                Console.WriteLine($"\nTarea nº{i + 1}: {tarea[i]}");
            }
            break;

        case "3":
            for (int i = 0; i < tarea.Count; i++)
            {
                Console.WriteLine($"\nTarea nº{i + 1}: {tarea[i]}");
            }

            Console.WriteLine("\nEscribe el número de la tarea a" +
                " eliminar: ");

            entrada = Console.ReadLine();

            int numeroTarea;

            while (!int.TryParse(entrada, out numeroTarea) ||
                numeroTarea > tarea.Count || numeroTarea < 1)
            {
                Console.WriteLine("Valor no válido. Introduce el" +
                    " número de la tarea.");
                entrada = Console.ReadLine();
            }

            tarea.RemoveAt(numeroTarea - 1);
            Console.WriteLine("Tarea eliminada.");
            break;

        case "4":
            Console.WriteLine("Saliendo... ");
            return;

        default:
            Console.WriteLine("Valor no válido. " +
                "Introduce un número del menú.");
            break;
    }
}

static void MostrarMensajeMenu()
{
    Console.WriteLine("\nGESTOR DE TAREAS\n");
    Console.WriteLine("1. Añadir tarea.");
    Console.WriteLine("2. Mostrar tareas.");
    Console.WriteLine("3. Eliminar tarea.");
    Console.WriteLine("4. Salir.");

    Console.WriteLine("\nElige una opción: \n");
}