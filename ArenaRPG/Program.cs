/*ARENA RPG
 * 
 * 1. Mostrar personajes.
 * 2. Atacar.
 * 3. Curar personaje.
 * 4. Salir.
 */

List<Personaje> personajes = new List<Personaje>();

personajes.Add(new Personaje("Héroe", 300));
personajes.Add(new Personaje("Perro acompañante", 50));
personajes.Add(new Personaje("Goblin", 100));
personajes.Add(new Personaje("Jefe Goblin", 200));

while(true)
{
    MenuArenaRPG();

    Console.WriteLine("Selecciona una opción del 1 al 4.");

    string? entrada = Console.ReadLine();

    switch(entrada)
    {
        case "1":
            for(int i = 0; i < personajes.Count; i++)
            {
                Console.Write($"\n{i + 1}: ");
                personajes[i].MostrarPersonaje();
            }
            break;

        case "2":
            {
                for (int i = 0; i < personajes.Count; i++)
                {
                    Console.Write($"\n{i + 1}: {personajes[i].Nombre}");
                }

                Console.WriteLine("\n¿Quién ataca?" +
                    " Ingresa el número.");

                int numeroAtacante;

                entrada = Console.ReadLine();

                while(!int.TryParse(entrada, out 
                    numeroAtacante) || numeroAtacante < 1 ||
                    numeroAtacante > personajes.Count)
                {
                    Console.WriteLine("\nError. Número no" +
                        " válido. Seleccione otro.");
                    entrada = Console.ReadLine();
                }

                Personaje atacante = personajes[numeroAtacante - 1];

                Console.WriteLine("\n¿A quién atacará?");

                for (int i = 0; i < personajes.Count; i++)
                {
                    Console.Write($"\n{i + 1}: {personajes[i].Nombre}");
                }

                int numeroAtacado;

                entrada = Console.ReadLine();

                while (!int.TryParse(entrada, out
                    numeroAtacado) || numeroAtacado < 1 ||
                    numeroAtacado > personajes.Count)
                {
                    Console.WriteLine("\nError. Número no" +
                        " válido. Seleccione otro.");
                    entrada = Console.ReadLine();
                }

                Personaje atacado = personajes[numeroAtacado - 1];

                Console.WriteLine("\n¿Cuántos puntos de daño" +
                    " va a quitar?");

                int danio;

                entrada = Console.ReadLine();

                while (!int.TryParse(entrada, out danio) ||
                    danio < 0)
                {
                    Console.WriteLine("\nValor inválido. " +
                        "Seleccione otra cantidad.");
                    entrada = Console.ReadLine();
                }

                atacante.Atacar(atacado, danio);
                break;
            }

        case "3":
            {
                for(int i = 0; i < personajes.Count; i++)
                {
                    Console.WriteLine($"\n{i + 1}. {personajes[i].Nombre}");
                }

                Console.WriteLine("\n¿Qué personaje quieres que se" +
                    " cure? Elige el número.");

                int objetivoCurar;

                entrada = Console.ReadLine();

                while(!int.TryParse(entrada, out objetivoCurar) ||
                    objetivoCurar < 1 || objetivoCurar > personajes.Count)
                {
                    Console.WriteLine("Error. Selección no" +
                        " válida.");
                    entrada = Console.ReadLine();
                }

                Console.WriteLine("\n¿Cuántos puntos de vida" +
                    " se va a curar?");

                int cantidad;

                entrada = Console.ReadLine();

                while(!int.TryParse(entrada, out cantidad) ||
                    cantidad < 0)
                {
                    Console.WriteLine("\nError. Valor inválido." +
                        " Introduce otra cantidad de puntos a" +
                        " curar.");
                    entrada = Console.ReadLine();
                }

                personajes[objetivoCurar - 1].Curar(cantidad);
            }
            break;

        case "4":
            Console.WriteLine("\nSaliendo...");
            return;

        default:
            Console.WriteLine("\nSeleccione una de las opciones" +
                " del 1 al 4.");
            break;
    }
}

static void MenuArenaRPG()
{
    Console.WriteLine("\nARENA RPG");

    Console.WriteLine("1. Mostrar personajes.");
    Console.WriteLine("2. Atacar.");
    Console.WriteLine("3. Curar personaje.");
    Console.WriteLine("4. Salir.\n");
}

class Personaje
{
    public string Nombre { get; set; }
    public int Vida { get; set; }

    public Personaje(string nombre, int vida)
    {
        Nombre = nombre;
        Vida = vida;
    }

    public bool EstaVivo()
    {
        return Vida > 0;
    }

    public void MostrarPersonaje()
    {
        Console.WriteLine($"Nombre: {Nombre}.");
        Console.WriteLine($"Vida: {Vida}PS.");

        string estado = EstaVivo() ? "Vivo" : "Muerto";

        Console.WriteLine($"Estado: {estado}");
    }

    public void Atacar(Personaje objetivo, int danio)
    {
        if(!EstaVivo())
        {
            Console.WriteLine($"{Nombre} está muerto y no" +
                $" puede atacar.");
            return;
        }

        if(!objetivo.EstaVivo())
        {
            Console.WriteLine($"{objetivo.Nombre} ya está" +
                $" muerto.");
            return;
        }

        Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre}" +
            $" y le hace {danio} puntos de daño.");

        objetivo.RecibirDanio(danio);
    }

    public void RecibirDanio(int danio)
    {
        Vida -= danio;

        if(Vida < 0)
        {
            Vida = 0;
        }

        if(!EstaVivo())
        {
            Console.WriteLine($"{Nombre} ha muerto.");
        }
        else
        {
            Console.WriteLine($"{Nombre} recibe {danio} y le" +
                $" quedan {Vida}PS.");
        }
    }

    public void Curar(int cantidad)
    {
        if (!EstaVivo())
        {
            Console.WriteLine($"{Nombre} está muerto y no" +
                $" puede curarse.");
            return;
        }

        Vida += cantidad;
        Console.WriteLine($"{Nombre} tiene ahora {Vida}PS.");
    }
}