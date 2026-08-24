/*COMBATE RPG
 * 
 * 1. Atacar enemigo: Restar int.
 * 2. Curar héroe: Sumar int.
 * 3. Mostrar estado: Muestra si está vivo o muerto.
 * 4. Salir.
 * */

Personaje heroe = new Personaje("Pablo Crack", 100);
Personaje goblin = new Personaje("Goblin", 50);

while(true)
{ 
    MenuCombate();

    Console.WriteLine("Seleccione una opción del 1 al 4.");

    string? entrada = Console.ReadLine();

    switch(entrada)
    {
        case "1":
            if(!goblin.EstaVivo())
            {
                Console.WriteLine("¡El goblin ya está muerto!");
                return;
            }

            Console.WriteLine("¿Cuántos puntos de ataque" +
                " tienes?");

            entrada = Console.ReadLine();

            int puntosAtaque;

            while(!int.TryParse(entrada, out puntosAtaque) ||
                puntosAtaque < 0)
            {
                Console.WriteLine("Puntos de ataque no" +
                    " válidos. Introduce otra cantidad.");
                entrada = Console.ReadLine();
            }

            goblin.RecibirDanio(puntosAtaque);

            if(!goblin.EstaVivo())
            {
                Console.WriteLine("¡Has derrotado al Goblin!");
            }

            break;

        case "2":
            Console.WriteLine("¿Cuántos puntos de vida" +
                " quieres recuperarte?");

            entrada = Console.ReadLine();

            int puntosVida;

            while(!int.TryParse(entrada, out puntosVida) ||
                puntosVida < 0)
            {
                Console.WriteLine("Puntos de vida no válidos." +
                    " Introduce otra cantidad.");
                entrada = Console.ReadLine();
            }

            heroe.Curar(puntosVida);
            break;

        case "3":
            heroe.MostrarEstado();
            goblin.MostrarEstado();
            break;

        case "4":
            Console.WriteLine("Huyes del combate...");
            return;

        default:
            Console.WriteLine("Selecciona una de las" +
                " acciones del 1 al 4.");
            break;
    }
}

static void MenuCombate()
{
    Console.WriteLine("\n¡ENTRAS EN COMBATE!\n");

    Console.WriteLine("1. Atacar enemigo.");
    Console.WriteLine("2. Curar héroe.");
    Console.WriteLine("3. Mostrar estado.");
    Console.WriteLine("4. Escapar.\n");
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

    public void RecibirDanio(int danio)
    {
        Vida -= danio;

        if (Vida < 0)
        {
            Vida = 0;
        }

        Console.WriteLine($"{Nombre} recibe {danio} de daño.");
        Console.WriteLine($"Le quedan {Vida} puntos de vida.");
    }

    public void Curar(int cantidad)
    {
        Vida += cantidad;
        Console.WriteLine($"{Nombre} recibe {cantidad} puntos" +
            $" de salud.");
        Console.WriteLine($"Ahora tiene {Vida} puntos de vida.");
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"\nNombre: {Nombre}.");
        Console.WriteLine($"PS: {Vida}.");

        if(EstaVivo())
        {
            Console.WriteLine("Vivo.");
        }
        else
        {
            Console.WriteLine("Muerto.");
        }
    }

    public bool EstaVivo()
    {
        return Vida > 0;
    }
}