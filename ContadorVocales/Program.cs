/* 1. Pedir al usuario una palabra o una frase.
 * 2. Comprobar que no esté vacía.
 * 3. Recorrer el texto carácter por carácter.
 * 4. Contar cuántas vocales contiene en total.
 * 5. Mostrar el resultado.
 */

Console.WriteLine("\nCONTADOR DE VOCALES\n");

Console.WriteLine("Ingrese una palabra o frase: ");

int contadorVocalA = 0;
int contadorVocalE = 0;
int contadorVocalI = 0;
int contadorVocalO = 0;
int contadorVocalU = 0;

string? entrada = Console.ReadLine();

while(string.IsNullOrWhiteSpace(entrada))
{
    Console.WriteLine("Valor no válido. Introduce una palabra.");
    entrada = Console.ReadLine();
}

for (int i = 0; i < entrada.Length; i++)
{
    char minusculas = char.ToLower(entrada[i]);

    switch(minusculas)
    {
        case 'a':
        case 'á':
            contadorVocalA++;
            break;

        case 'e':
        case 'é':
            contadorVocalE++;
            break;

        case 'i':
        case 'í':
            contadorVocalI++;
            break;

        case 'o':
        case 'ó':
            contadorVocalO++;
            break;

        case 'u':
        case 'ú':
        case 'ü':
            contadorVocalU++;
            break;
    }
}

Console.WriteLine($"El texto \"{entrada}\" tiene las siguientes vocales: ");
Console.WriteLine($"\nA: {contadorVocalA}.");
Console.WriteLine($"E: {contadorVocalE}.");
Console.WriteLine($"I: {contadorVocalI}.");
Console.WriteLine($"O: {contadorVocalO}.");
Console.WriteLine($"U: {contadorVocalU}.");

int vocalesTotal = contadorVocalA + contadorVocalE +
    contadorVocalI + contadorVocalO + contadorVocalU;

Console.WriteLine($"\nTiene {vocalesTotal} vocales.");
