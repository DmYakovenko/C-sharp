using MySql.Data.MySqlClient;
using System;

public class DatabaseConnection
{
    private string connectionString;

    public DatabaseConnection(string server, string database, string username, string password)
    {
        connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
}
