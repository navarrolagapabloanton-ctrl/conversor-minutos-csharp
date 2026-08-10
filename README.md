# Fundamentos de programación en C#

Repositorio con ejercicios sencillos realizados durante mi aprendizaje de
fundamentos de programación en C#.

El objetivo es practicar progresivamente conceptos básicos como variables,
condicionales, bucles, métodos, validación de datos y control de versiones.

## Proyectos

### 1. Conversor de minutos a segundos

Aplicación de consola que solicita una cantidad de minutos y muestra su
equivalencia en segundos.

#### Funcionalidades

- Convierte minutos en segundos.
- Comprueba que la entrada sea un número entero.
- Rechaza números negativos.
- Permite realizar varias conversiones.
- Permite finalizar mediante una respuesta S/N.

#### Conceptos practicados

- Variables.
- `Console.ReadLine()`.
- `int.TryParse()`.
- Parámetros `out`.
- Condicionales.
- Bucles `while` y `do while`.
- Variables booleanas.
- Interpolación de cadenas.

---

### 2. Clasificador de números

Aplicación de consola que solicita un número entero y lo clasifica según su
signo y su paridad.

#### Funcionalidades

- Comprueba que la entrada sea un número entero.
- Indica si el número es positivo, negativo o cero.
- Indica si el número es par o impar.
- Permite probar varios números en una misma ejecución.
- Separa las distintas comprobaciones mediante métodos.

#### Conceptos practicados

- `if`, `else if` y `else`.
- Operador módulo `%`.
- Métodos `void`.
- Parámetros de métodos.
- Validación mediante `TryParse`.
- Bucles.

---

### 3. Calculadora básica

Calculadora de consola que permite realizar operaciones sencillas con dos
números enteros.

#### Funcionalidades

- Solicita y valida dos números enteros.
- Permite sumar, restar, multiplicar y dividir.
- Utiliza un `switch` para seleccionar la operación.
- Evita la división entre cero.
- Utiliza métodos para reutilizar la lectura y validación de números.
- Separa la presentación del menú en un método independiente.

#### Conceptos practicados

- `switch`.
- Métodos con valor de retorno.
- `return`.
- Métodos `void`.
- Reutilización de código.
- Validación de entrada.
- División entre enteros.

---

### 4. Tabla de multiplicar

Aplicación que solicita un número entero y muestra su tabla de multiplicar
desde el 1 hasta el 10.

#### Funcionalidades

- Comprueba que la entrada sea un número entero.
- Muestra automáticamente las diez multiplicaciones.
- Utiliza métodos para separar la lectura del número y la presentación
  de la tabla.

#### Conceptos practicados

- Bucle `for`.
- Contadores.
- Métodos con parámetros.
- Métodos con `return`.
- Interpolación de cadenas.

---

### 5. Adivina el número

Pequeño juego de consola en el que el programa genera aleatoriamente un número
entre 1 y 10 y el usuario debe intentar adivinarlo.

#### Funcionalidades

- Genera un número aleatorio.
- Solicita números entre 1 y 10.
- Valida la entrada del usuario.
- Indica si el número secreto es mayor o menor.
- Repite hasta que el usuario acierta.
- Cuenta todos los intentos realizados, incluyendo entradas no válidas.

#### Conceptos practicados

- `Random`.
- Estado del programa.
- Bucles `do while`.
- Condiciones de salida.
- Contadores.
- Comparaciones.
- Validación combinada de tipo y rango.

---

## Conceptos practicados hasta ahora

- Variables y tipos de datos.
- Entrada y salida por consola.
- `Console.ReadLine()` y `Console.WriteLine()`.
- Conversión y validación con `int.TryParse()`.
- Parámetros `out`.
- Condicionales `if`, `else if` y `else`.
- `switch`.
- Operadores aritméticos.
- Operador módulo `%`.
- Bucles `while`, `do while` y `for`.
- Variables booleanas.
- Métodos `void`.
- Métodos con parámetros.
- Métodos con valor de retorno.
- `return`.
- Generación de números aleatorios con `Random`.
- Reutilización y organización del código.
- Control de versiones con Git y GitHub.

## Ejecución

Los proyectos pueden ejecutarse desde la carpeta raíz del repositorio.

### Conversor de minutos

```bash
dotnet run --project ConversorMinutosApp/ConversorMinutosApp.csproj

### Clasificador de números

```bash
dotnet run --project ClasificadorNumeros/ClasificadorNumeros.csproj

### Calculadora básica

```bash
dotnet run --project CalculadoraBasica/CalculadoraBasica.csproj

### Tabla de multiplicar

```bash
dotnet run --project TablaMultiplicar/TablaMultiplicar.csproj

### Adivina el número

```bash
dotnet run --project AdivinaNumero/AdivinaNumero.csproj