# Ejercicios de C#

Repositorio personal de aprendizaje y práctica de C#.

Aquí voy guardando ejercicios realizados durante mi aprendizaje, desde programas básicos de consola hasta ejercicios con métodos, colecciones, clases y orientación a objetos.

El objetivo del repositorio no es mostrar aplicaciones terminadas, sino reflejar mi progreso, practicar la resolución de problemas y afianzar los fundamentos de C#.

---

## Conceptos practicados

A lo largo de los ejercicios he trabajado con:

- Variables y tipos de datos
- Condicionales (`if`, `else`, `switch`)
- Bucles (`for`, `while`, `do-while`, `foreach`)
- Validación de entradas con `TryParse`
- Métodos y parámetros
- Métodos con valores de retorno
- Arrays
- `List<T>`
- `Dictionary<TKey, TValue>`
- Manipulación de strings y caracteres
- Acumuladores, máximos, mínimos y medias
- Menús interactivos
- Separación del programa en métodos
- Clases y objetos
- Propiedades
- Constructores
- Métodos de instancia
- Objetos como parámetros de otros métodos
- Listas de objetos
- Interacción entre objetos
- Principios básicos de orientación a objetos

---

# Ejercicios realizados

## 01 - Conversor de minutos

Conversión de minutos a segundos con validación de entrada y posibilidad de repetir el programa.

**Conceptos:**
- `TryParse`
- `do-while`
- Validación
- Variables booleanas

---

## 02 - Clasificador de números

Clasifica un número según sea:

- Positivo
- Negativo
- Cero
- Par
- Impar

Primer ejercicio dividido en métodos.

---

## 03 - Calculadora básica

Calculadora de consola con:

- Suma
- Resta
- Multiplicación
- División
- Control de división entre cero

**Conceptos:**
- Métodos
- Parámetros
- Valores de retorno
- `switch`

---

## 04 - Tabla de multiplicar

Generación de la tabla de multiplicar de un número.

**Concepto principal:** primer uso de bucles `for`.

---

## 05 - Adivina el número

Juego en el que el programa genera un número aleatorio y el usuario debe adivinarlo.

Incluye pistas y contador de intentos.

**Conceptos:**
- `Random`
- Bucles
- Comparaciones
- Control del flujo

---

## 06 - Analizador de notas

Almacena varias notas y calcula:

- Media
- Nota máxima
- Nota mínima

**Conceptos:**
- Arrays
- Recorrido mediante bucles
- Acumuladores

---

## 07 - Contador de vocales

Analiza un texto y cuenta las diferentes vocales, incluyendo vocales acentuadas.

**Conceptos:**
- `string`
- `char`
- `foreach`
- `switch`
- Manipulación de texto

---

## 08 - Lista de la compra

Permite introducir productos dinámicamente hasta finalizar la entrada.

**Concepto principal:** introducción a `List<T>`.

---

## 09 - Gestor de tareas

Aplicación de consola con menú para:

- Añadir tareas
- Mostrar tareas
- Eliminar tareas
- Salir

Primer pequeño gestor CRUD mediante una lista.

---

## 10 - Cajero automático

Simulación sencilla de una cuenta bancaria:

- Consultar saldo
- Ingresar dinero
- Retirar dinero
- Controlar saldo disponible

**Concepto principal:** uso de `decimal` y modificación de estado.

---

## 11 - Registro de gastos

Gestor que permite:

- Añadir gastos
- Mostrar gastos
- Calcular estadísticas
- Eliminar registros

Incluye cálculo de:

- Total
- Media
- Máximo
- Mínimo

---

## 12 - Gestor de videojuegos

Gestión de una colección de videojuegos mediante métodos independientes.

Permite:

- Añadir
- Mostrar
- Buscar
- Eliminar

**Objetivo principal:** dividir un programa grande en métodos más pequeños y reutilizables.

---

## 13 - Carrito de compra

Carrito formado por una lista de precios.

Calcula:

- Subtotal
- IVA
- Total

**Conceptos:**
- Métodos con `return`
- Paso de valores entre métodos
- `List<decimal>`

---

## 14 - Agenda de contactos

Agenda formada por nombres y teléfonos.

Permite:

- Añadir contactos
- Mostrar contactos
- Buscar
- Eliminar

**Concepto principal:** introducción a `Dictionary<TKey, TValue>`.

---

## 15 - Gestor de inventario

Inventario donde cada producto tiene una cantidad asociada.

Permite:

- Añadir productos
- Aumentar stock
- Consultar productos
- Modificar cantidades
- Eliminar productos

**Conceptos:**
- `Dictionary<string, int>`
- Lectura y modificación de valores mediante claves

---

# Orientación a objetos

A partir de estos ejercicios comienzo a trabajar con clases y objetos.

---

## 16 - Gestor de alumnos

Primera aplicación utilizando una clase propia:

`Alumno`

Cada alumno contiene:

- Nombre
- Nota

La aplicación permite:

- Añadir alumnos
- Mostrar alumnos
- Buscar
- Calcular estadísticas
- Eliminar

**Conceptos:**
- Clases
- Objetos
- Propiedades
- `List<Alumno>`

---

## 17 - Biblioteca personal

Gestión de libros mediante una clase `Libro`.

Cada libro contiene:

- Título
- Autor
- Estado de préstamo

Permite:

- Añadir libros
- Mostrar biblioteca
- Buscar
- Prestar
- Devolver

**Conceptos:**
- Constructores
- Propiedades
- Estado de los objetos
- Operador ternario

---

## 18 - Cuenta bancaria

Cuenta bancaria modelada mediante una clase.

Cada cuenta tiene:

- Titular
- Saldo

Y puede:

- Ingresar dinero
- Retirar dinero
- Mostrar información

**Conceptos:**
- Métodos de instancia
- Diferencia entre métodos `static` y métodos pertenecientes a objetos

---

## 19 - Combate RPG

Pequeño sistema de combate mediante objetos `Personaje`.

Los personajes pueden:

- Recibir daño
- Curarse
- Comprobar si están vivos
- Mostrar su estado

**Conceptos:**
- Estado de un objeto
- Métodos que devuelven `bool`
- Reutilización de métodos

---

## 20 - Transferencias bancarias

Dos objetos `CuentaBancaria` pueden realizar transferencias entre ellos.

Ejemplo:

```csharp
cuentaPablo.Transferir(cuentaLaura, cantidad);

```

**Conceptos:**

- Objetos como parámetros
- Interacción entre objetos
- Modificación del estado de varios objetos
- Ámbito de variables dentro de bloques `{ }`

---

## 21 - Arena RPG

Sistema formado por varios personajes almacenados en una lista:

```csharp
List<Personaje> personajes = new List<Personaje>();
```

Permite:

- Mostrar personajes
- Elegir atacante
- Elegir objetivo
- Atacar
- Recibir daño
- Curar personajes
- Gestionar personajes vivos y muertos

Ejemplo:

```csharp
Personaje atacante = personajes[numeroAtacante - 1];
Personaje objetivo = personajes[numeroObjetivo - 1];

atacante.Atacar(objetivo, danio);
```

El método `Atacar` recibe otro objeto `Personaje` como parámetro:

```csharp
public void Atacar(Personaje objetivo, int danio)
{
    objetivo.RecibirDanio(danio);
}
```

**Conceptos:**

- Listas de objetos
- Selección de objetos mediante índices
- Objetos como argumentos
- Interacción entre objetos
- Métodos de instancia
- Métodos que llaman a métodos de otros objetos
- Métodos que devuelven `bool`
- Separación de responsabilidades entre métodos
- Gestión del estado de los objetos

---

# Codewars

También utilizo Codewars para practicar pequeños problemas de programación y mejorar mi capacidad para plantear soluciones.

### Count of positives / sum of negatives

Dado un array de enteros, el ejercicio consiste en devolver otro array donde:

- El primer elemento contiene el número de valores positivos.
- El segundo elemento contiene la suma de los valores negativos.
- El `0` no se considera positivo ni negativo.
- Si el array está vacío o es `null`, se devuelve un array vacío.

Ejemplo de parte de la solución:

```csharp
if (input == null)
{
    return [];
}

if (input.Length == 0)
{
    return [];
}

int positiveCount = 0;
int negativeSum = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] > 0)
    {
        positiveCount++;
    }

    if (input[i] < 0)
    {
        negativeSum += input[i];
    }
}
```

**Conceptos reforzados:**

- Comprobación de `null` antes de acceder a un objeto.
- Diferencia entre un array `null` y un array vacío.
- Uso de `input.Length`.
- Recorrido de arrays mediante `for`.
- Uso de contadores.
- Uso de acumuladores.
- Arrays como valor de retorno.
- Sintaxis moderna `[]` para devolver un array vacío.

---

| Maximum and Minimum Values of a List | Arrays, métodos, valores de retorno, máximos y mínimos, recorrido con `for` |

### Maximum and Minimum Values of a List

Ejercicio basado en dos métodos que reciben un array de enteros:

- `Max()` devuelve el valor más alto.
- `Min()` devuelve el valor más bajo.

La búsqueda comienza utilizando el primer elemento del array como valor inicial y recorriendo posteriormente el resto de elementos.

```csharp
public int Max(int[] list)
{
    int max = list[0];

    for (int i = 1; i < list.Length; i++)
    {
        if (max < list[i])
        {
            max = list[i];
        }
    }

    return max;
}

public int Min(int[] list)
{
    int min = list[0];

    for (int i = 1; i < list.Length; i++)
    {
        if (min > list[i])
        {
            min = list[i];
        }
    }

    return min;
}
```

**Conceptos reforzados:**

- Inicialización de máximos y mínimos utilizando el primer elemento del array.
- Recorrido de arrays mediante `for`.
- Comparación y actualización de valores.
- Métodos que devuelven un `int`.
- Evitar comparar innecesariamente `list[0]` consigo mismo comenzando el bucle en `i = 1`.

---

## Are You Playing Banjo?

La función recibe un nombre y comprueba si su primera letra es una **R**, independientemente de que esté escrita en mayúscula o minúscula.

Si empieza por `R`, devuelve que esa persona toca el banjo. En caso contrario, devuelve que no lo toca.

### Solución

```csharp
class Kata
{
    public static string AreYouPlayingBanjo(string name)
    {
        return name.ToLower()[0] == 'r'
            ? name + " plays banjo"
            : name + " does not play banjo";
    }
}
```

### Versión ejecutable

Para probar la kata desde Visual Studio añadí un `Main` que solicita un nombre y comprueba que la entrada no esté vacía antes de llamar al método:

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa tu nombre:");
        string? entrada = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("Nombre no válido. Ingresa otro nombre.");
            entrada = Console.ReadLine();
        }

        Console.WriteLine(Kata.AreYouPlayingBanjo(entrada));
    }
}
```

### Conceptos reforzados

* Acceso a caracteres individuales de un `string` mediante índices.
* Diferencia entre `string` y `char`.
* Uso de `'r'` para representar un carácter y `"r"` para representar un string.
* Conversión de un string a minúsculas mediante `ToLower()`.
* Uso del operador ternario `condición ? valorSiTrue : valorSiFalse`.
* Validación de entradas mediante `string.IsNullOrWhiteSpace()`.
* Separación entre la lógica de la kata y el código utilizado para probarla en consola.

---

## Validate PIN Code — 7 kyu

Los cajeros automáticos solo aceptan códigos PIN de **4 o 6 dígitos**.

La función debe devolver:

- `true` si el PIN tiene exactamente 4 o 6 caracteres y todos son dígitos.
- `false` en cualquier otro caso.

### Solución

```csharp
public class Kata
{
    public static bool ValidatePin(string pin)
    {
        if (pin.Length == 4 || pin.Length == 6)
        {
            foreach (char character in pin)
            {
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }

            return true;
        }
        else
        {
            return false;
        }
    }
}
```

### Versión ejecutable

Para probar la kata desde consola añadí validación de entrada:

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un PIN.");

        string? entrada = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("Valor no válido. Introduce otro valor.");
            entrada = Console.ReadLine();
        }

        Console.WriteLine(Kata.ValidatePin(entrada));
    }
}
```

### Conceptos reforzados

- Uso de `.Length` para conocer la longitud de un `string`.
- Recorrido de un `string` carácter a carácter mediante `foreach`.
- Uso del tipo `char`.
- Comprobación de caracteres numéricos mediante `char.IsDigit()`.
- Uso de `return false` para detener el método al encontrar un carácter inválido.
- Uso de expresiones booleanas como condiciones.
- Validación de entradas mediante `string.IsNullOrWhiteSpace()`.
- Diferencia entre comprobar si un texto puede convertirse en número con `TryParse()` y comprobar si está formado exclusivamente por dígitos.

### Aprendizaje

Inicialmente utilicé `int.TryParse()` para comprobar si el PIN era numérico.

Sin embargo, `TryParse()` comprueba si una cadena puede interpretarse como un número entero y puede aceptar valores como `+123` o `-123`.

En esta kata era necesario comprobar algo más específico: que **cada carácter del PIN fuese un dígito**.

Por ello, recorrí el `string` con un `foreach` y utilicé `char.IsDigit()` para validar cada carácter.

---

## Is this a Triangle? — 7 kyu

La función recibe tres valores enteros que representan las longitudes de los lados de un triángulo.

Debe devolver:

- `true` si los tres lados pueden formar un triángulo.
- `false` si no cumplen la condición necesaria.

Para que tres lados formen un triángulo, la suma de cada pareja de lados debe ser mayor que el lado restante.

### Solución

```csharp
public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}
```

### Versión ejecutable

Para probar la kata desde consola añadí un método reutilizable que solicita un número entero y valida la entrada:

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer lado del triángulo:");
        int a = LeerNumero();

        Console.WriteLine("Ingrese el segundo lado del triángulo.");
        int b = LeerNumero();

        Console.WriteLine("Ingrese el tercer lado del triángulo.");
        int c = LeerNumero();

        Console.WriteLine(Triangle.IsTriangle(a, b, c));
    }

    public static int LeerNumero()
    {
        string? entrada = Console.ReadLine();

        int num;

        while (!int.TryParse(entrada, out num))
        {
            Console.WriteLine("Valor no válido. Introduce un entero.");
            entrada = Console.ReadLine();
        }

        return num;
    }
}
```

### Conceptos reforzados

- Uso de expresiones booleanas.
- Operadores lógicos `&&`.
- Comparaciones con `>`.
- Devolución directa de un valor `bool` sin necesidad de usar `if`.
- Uso de métodos auxiliares para evitar repetir código.
- Validación de entrada mediante `int.TryParse()`.
- Uso de parámetros y valores de retorno.
- Separación entre la lógica de la kata y el código usado para probarla desde consola.

### Aprendizaje

Inicialmente podía plantearse la comprobación mediante un `if` o un operador ternario, pero la propia condición:

```csharp
a + b > c && a + c > b && b + c > a
```

ya devuelve directamente un valor booleano.

Por ello, no es necesario escribir:

```csharp
return condicion ? true : false;
```

y se puede devolver directamente la expresión.

También se creó el método `LeerNumero()` para reutilizar la validación de números enteros y evitar repetir tres veces el mismo bloque con `int.TryParse()`.

---

## Vowel Count — 7 kyu

La función recibe una cadena de texto formada por letras minúsculas y espacios y debe devolver el número total de vocales que contiene.

Las vocales consideradas son:

```text
a, e, i, o, u
```

### Solución

```csharp
public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        foreach (char character in str)
        {
            if ("aeiou".Contains(character))
            {
                vowelCount++;
            }
        }

        return vowelCount;
    }
}
```

### Versión ejecutable

Para probar la kata desde consola añadí una validación para evitar que el usuario introduzca una cadena vacía:

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un texto:");

        string? entrada = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("No puede estar el texto vacío.");
            entrada = Console.ReadLine();
        }

        Console.WriteLine(Kata.GetVowelCount(entrada));
    }
}
```

### Conceptos reforzados

- Recorrido de un `string` carácter a carácter mediante `foreach`.
- Uso del tipo `char`.
- Uso de un contador.
- Incremento de variables mediante `++`.
- Uso de `string.Contains()` para comprobar si una cadena contiene un determinado carácter.
- Validación de entradas mediante `string.IsNullOrWhiteSpace()`.
- Simplificación de condiciones largas.

### Aprendizaje

Inicialmente comprobé cada vocal individualmente:

```csharp
if (character == 'a' ||
    character == 'e' ||
    character == 'i' ||
    character == 'o' ||
    character == 'u')
{
    vowelCount++;
}
```

Aunque esta solución funciona correctamente, puede simplificarse utilizando un `string` que contenga todas las vocales:

```csharp
if ("aeiou".Contains(character))
{
    vowelCount++;
}
```

De esta forma, en lugar de realizar cinco comparaciones distintas, se comprueba directamente si el carácter actual está contenido dentro de `"aeiou"`.

También reforcé la idea de que un `string` puede recorrerse carácter a carácter mediante un `foreach`.

---

## Find the Next Perfect Square! — 7 kyu

La función recibe un número entero no negativo.

Debe comprobar si el número es un **cuadrado perfecto**, es decir, si su raíz cuadrada es un número entero.

- Si es un cuadrado perfecto, devuelve el siguiente cuadrado perfecto.
- Si no lo es, devuelve `-1`.

Por ejemplo:

```text
121 = 11²

El siguiente cuadrado perfecto es:

12² = 144
```

Por tanto:

```text
121 → 144
```

Mientras que:

```text
72 → -1
```

porque `72` no es un cuadrado perfecto.

### Solución

```csharp
using System;

public class Kata
{
    public static long FindNextSquare(long num)
    {
        long sqr = (long)Math.Sqrt(num);

        return sqr * sqr == num
            ? (sqr + 1) * (sqr + 1)
            : -1;
    }
}
```

### Versión ejecutable

Para probar la kata desde consola añadí una entrada validada mediante `long.TryParse()`:

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(@"- Ingresa un número.
- Se hará su raíz cuadrada.
- Si no tiene decimales, se calculará la potencia al cuadrado del
siguiente número.
- Si no, el resultado será -1.");

        string? entrada = Console.ReadLine();

        long result;

        while (!long.TryParse(entrada, out result))
        {
            Console.WriteLine("Ingrese un número entero.");
            entrada = Console.ReadLine();
        }

        Console.WriteLine(Kata.FindNextSquare(result));
    }
}
```

### Conceptos reforzados

- Cálculo de raíces cuadradas mediante `Math.Sqrt()`.
- Conversión explícita o *casting* de `double` a `long`.
- Comprobación de cuadrados perfectos.
- Operador ternario.
- Operaciones con números de tipo `long`.
- Validación mediante `long.TryParse()`.
- Strings multilínea mediante `@"..."`.
- Diferencia entre realizar operaciones con enteros y con `double`.
- Importancia de la precisión numérica al trabajar con números grandes.

### Aprendizaje

Inicialmente intenté encontrar la raíz cuadrada mediante un bucle:

```csharp
long square = 0;

while (square * square < num)
{
    square++;
}
```

Esta solución funciona, pero para números muy grandes puede necesitar una enorme cantidad de iteraciones y provocar que el programa tarde demasiado.

Utilizando:

```csharp
Math.Sqrt(num)
```

se puede obtener directamente la raíz cuadrada.

Como `Math.Sqrt()` devuelve un `double`, convierto el resultado a `long`:

```csharp
long sqr = (long)Math.Sqrt(num);
```

Después compruebo si realmente era un cuadrado perfecto multiplicando el entero obtenido por sí mismo:

```csharp
sqr * sqr == num
```

Si la condición se cumple, el siguiente cuadrado perfecto se obtiene incrementando la raíz en uno:

```csharp
(sqr + 1) * (sqr + 1)
```

### Problema encontrado con `Math.Pow()`

En una primera versión utilicé:

```csharp
(long)Math.Pow(sqr, 2)
```

Aunque funcionaba para números pequeños, algunos tests con números muy grandes fallaban.

`Math.Pow()` trabaja con valores `double`, y estos pueden perder precisión al representar enteros muy grandes.

Por ello, para elevar al cuadrado un valor entero es preferible utilizar directamente:

```csharp
sqr * sqr
```

De esta forma la operación continúa realizándose con valores `long` y se evita la pérdida de precisión producida por `double`.

---

## Sum of Odd Numbers — 7 kyu

La kata muestra un triángulo formado por números impares consecutivos:

```text
             1
          3     5
       7     9     11
    13    15    17    19
 21    23    25    27    29
```

La función recibe el número de una fila `n` y debe devolver la suma de todos los números que contiene esa fila.

Por ejemplo:

```text
Fila 1 → 1
Suma = 1

Fila 2 → 3 + 5
Suma = 8

Fila 4 → 13 + 15 + 17 + 19
Suma = 64
```

### Solución

```csharp
public static class Kata
{
    public static long RowSumOddNumbers(long n)
    {
        long sum = 0;
        long init = n * (n - 1) + 1;

        for (long i = 0; i < n; i++)
        {
            sum += init + (2 * i);
        }

        return sum;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Kata.RowSumOddNumbers(4));
    }
}
```

### Funcionamiento

Primero se calcula cuál es el primer número de la fila:

```csharp
long init = n * (n - 1) + 1;
```

Por ejemplo, para la fila 4:

```text
4 × (4 - 1) + 1
4 × 3 + 1
13
```

Por tanto, la fila comienza en `13`.

Como los números impares consecutivos aumentan de dos en dos, se recorre la fila mediante:

```csharp
for (long i = 0; i < n; i++)
{
    sum += init + (2 * i);
}
```

Para `n = 4`:

```text
i = 0 → 13 + (2 × 0) = 13
i = 1 → 13 + (2 × 1) = 15
i = 2 → 13 + (2 × 2) = 17
i = 3 → 13 + (2 × 3) = 19
```

Finalmente:

```text
13 + 15 + 17 + 19 = 64
```

### Conceptos reforzados

- Uso de bucles `for`.
- Uso de acumuladores.
- Cálculo de posiciones mediante fórmulas.
- Trabajo con secuencias de números impares.
- Uso de variables de tipo `long`.
- Diferencia entre el número de fila `n` y el índice utilizado dentro del bucle.
- Resolución previa del problema mediante dibujo y búsqueda de patrones.

### Aprendizaje

Una de las dificultades del ejercicio fue interpretar correctamente que el enunciado indica que **las filas empiezan a numerarse desde 1**.

Esto no significa que el índice del `for` tenga que comenzar también en `1`.

En esta solución:

```csharp
for (long i = 0; i < n; i++)
```

`n` representa el número de la fila, mientras que `i` se utiliza únicamente para calcular la posición de cada número dentro de esa fila.

También descubrí que el primer número de cada fila puede calcularse mediante:

```csharp
n * (n - 1) + 1
```

y que, a partir de ese número, los siguientes valores se obtienen sumando `2`.

### Patrón matemático

Después de resolverlo mediante el algoritmo anterior, se puede observar otro patrón:

```text
Fila 1 → 1   = 1³
Fila 2 → 8   = 2³
Fila 3 → 27  = 3³
Fila 4 → 64  = 4³
Fila 5 → 125 = 5³
```

Por tanto, la suma de cualquier fila `n` también puede calcularse directamente como:

```csharp
return n * n * n;
```

La solución con el bucle permite entender cómo se construye y se suma cada fila, mientras que la fórmula aprovecha directamente el patrón matemático.

---

## Two to One — 7 kyu

La función recibe dos cadenas formadas únicamente por letras minúsculas de la `a` a la `z`.

Debe devolver una nueva cadena que contenga todas las letras que aparecen en cualquiera de las dos cadenas:

- Sin repetir caracteres.
- Ordenadas alfabéticamente.

Por ejemplo:

```text
s1 = "xyaabbbccccdefww"
s2 = "xxxxyyyyabklmopq"

Resultado:

"abcdefklmopqwxy"
```

### Solución

```csharp
public class TwoToOne
{
    public static string Longest(string s1, string s2)
    {
        string s3 = s1 + s2;
        string finalString = "";

        for (char c = 'a'; c <= 'z'; c++)
        {
            if (s3.Contains(c))
            {
                finalString += c;
            }
        }

        return finalString;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main()
    {
        Console.WriteLine(
            TwoToOne.Longest("lallave", "dealfredo")
        );
    }
}
```

### Conceptos reforzados

- Concatenación de cadenas mediante `+`.
- Uso de `string.Contains()`.
- Recorrido mediante un bucle `for`.
- Uso del tipo `char`.
- Comparación de caracteres.
- Incremento de caracteres mediante `c++`.
- Eliminación indirecta de caracteres repetidos.
- Ordenación alfabética aprovechando el orden de los caracteres.
- Construcción progresiva de un `string`.

### Aprendizaje

Inicialmente resolví el ejercicio creando manualmente un array con todas las letras del alfabeto:

```csharp
string[] abc =
{
    "a", "b", "c", "d", "e", "f", "g", "h",
    "i", "j", "k", "l", "m", "n", "o", "p",
    "q", "r", "s", "t", "u", "v", "w", "x",
    "y", "z"
};
```

Después recorría ese array y comprobaba mediante `Contains()` si cada letra aparecía en las dos cadenas concatenadas.

La solución funcionaba, pero descubrí que no era necesario escribir manualmente todo el alfabeto.

Los caracteres de `'a'` a `'z'` están ordenados consecutivamente, por lo que se pueden recorrer directamente:

```csharp
for (char c = 'a'; c <= 'z'; c++)
{
    if (s3.Contains(c))
    {
        finalString += c;
    }
}
```

De esta forma, el propio bucle garantiza dos cosas:

1. Las letras se añaden en orden alfabético.
2. Cada letra se comprueba una sola vez, por lo que no aparecen caracteres repetidos.

### Primera solución

Antes de simplificarlo, utilicé esta aproximación:

```csharp
string s3 = s1 + s2;
string finalString = "";

string[] abc =
{
    "a", "b", "c", "d", "e", "f", "g", "h",
    "i", "j", "k", "l", "m", "n", "o", "p",
    "q", "r", "s", "t", "u", "v", "w", "x",
    "y", "z"
};

for (int i = 0; i < abc.Length; i++)
{
    if (s3.Contains(abc[i]))
    {
        finalString += abc[i];
    }
}

return finalString;
```

Esta primera solución era válida y permitió llegar al algoritmo antes de conocer una forma más sencilla de recorrer directamente los caracteres del alfabeto.

---

Esta sección irá creciendo a medida que complete nuevas katas y aprenda nuevas herramientas del lenguaje.

---

# Proyectos

Tras practicar los fundamentos de C# y comenzar con orientación a objetos, el siguiente objetivo es aplicar estos conocimientos en aplicaciones más completas.

Actualmente estoy desarrollando proyectos independientes orientados a portfolio utilizando C# y .NET.

Estos proyectos se mantienen en repositorios separados de este repositorio de ejercicios.

---

# Tecnologías y herramientas

- C#
- .NET
- Visual Studio
- Git
- GitHub

---

# Sobre este repositorio

Los ejercicios están realizados como parte de mi proceso de aprendizaje.

El código refleja mi evolución: algunos ejercicios podrían resolverse de forma más corta o utilizando técnicas más avanzadas, pero he preferido mantener las soluciones acordes a los conocimientos que tenía en cada momento.

De esta forma, el repositorio sirve también como registro de mi progreso como desarrollador.

El objetivo no es únicamente llegar a la solución, sino comprender progresivamente cómo estructurar programas, dividir problemas en partes más pequeñas y utilizar las herramientas del lenguaje de forma cada vez más natural.
