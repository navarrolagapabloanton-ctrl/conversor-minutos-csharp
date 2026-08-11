/* 1. Pedir productos al usuario uno por uno.
 * 2. Guardar cada producto.
 * 3. El usuario escribirá "fin" cuando no quiera añadir más.
 * 4. "fin" no debe guardarse como producto.
 * 5. No permitir productos vacíos.
 * 6. Al terminar, mostrar todos los productos numerados.
 * 7. Mostrar cuántos productos hay.
 */

Console.WriteLine("\nLISTA DE LA COMPRA\n");

List<string> productos = new List<string>();

Console.WriteLine("Ingrese un producto o escriba " +
        "\"FIN\" para terminar la lista.");

string? entrada = Console.ReadLine();

while (entrada?.ToLower() != "fin")
{
    while (string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("Valor no válido. Introduce un" +
            " producto.");
        entrada = Console.ReadLine();
    }

    if(entrada.ToLower() == "fin")
    {
        break;
    }

    productos.Add(entrada);
    Console.WriteLine("Ingrese un producto o escriba " +
        "\"FIN\" para terminar la lista.");
    entrada = Console.ReadLine();
}

Console.WriteLine("\nLista de la compra: \n");

for(int i = 0; i < productos.Count; i++)
{
    Console.WriteLine($"Producto nº{i + 1}: {productos[i]}");
}

Console.WriteLine($"\nProductos totales: {productos.Count}.");