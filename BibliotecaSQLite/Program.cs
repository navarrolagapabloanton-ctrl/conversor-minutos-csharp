/* 1. Añadir libro.
 * 2. Mostrar libros.
 * 3. Salir.
 */

using Microsoft.Data.Sqlite;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=biblioteca.db";

        using (var connection = new SqliteConnection(
            connectionString))
        {
            connection.Open();

            CreateTable(connection);
            InsertData(connection, "Harry Pettas", "JK Rowling");
            InsertData(connection, "Papelo", "RM");

            ReadData(connection);
        }
    }

    static void CreateTable(SqliteConnection conn)
    {
        if (conn == null) throw new ArgumentNullException(nameof(conn));
        if (conn.State != System.Data.ConnectionState.Open)
            throw new InvalidOperationException("La conexión tiene" +
                " que estar abierta.");

        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            CREATE TABLE IF NOT EXISTS Libros(
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Titulo TEXT NOT NULL,
            Autor TEXT NOT NULL
            );";

        cmd.ExecuteNonQuery();

        Console.WriteLine("Tabla creada correctamente.");
    }

    static void InsertData(SqliteConnection conn, string titulo, string
        autor)
    {
        if (conn == null) throw new ArgumentNullException(nameof(conn));
        if (string.IsNullOrWhiteSpace(titulo))
            throw new ArgumentException("El título no puede estar" +
                " vacío.", nameof(titulo));
        if (string.IsNullOrWhiteSpace(autor))
            throw new ArgumentException("El autor no puede estar" +
                " vacío.", nameof(autor));

        using var cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO Libros (Titulo, autor) VALUES" +
            " (@titulo, @autor);";
        cmd.Parameters.AddWithValue("@titulo", titulo);
        cmd.Parameters.AddWithValue("@autor", autor);
        cmd.ExecuteNonQuery();
    }

    static void ReadData(SqliteConnection conn)
    {
        if (conn == null) throw new ArgumentNullException(nameof(conn));

        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT Id, Titulo, Autor FROM Libros;";

        using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
            Console.WriteLine($"ID: {reader.GetInt32(0)} " +
                $"Título: {reader.GetString(1)}" +
                $" - Autor: {reader.GetString(2)}");
            }
    }
}