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
